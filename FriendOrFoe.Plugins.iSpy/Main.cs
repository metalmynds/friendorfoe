using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;
using System.Text;

namespace FriendOrFoe.Plugins.iSpy
{
    public class Main : IDisposable
    {
        private string _config = "";
        private bool _disposed;
        internal String EndPoint = "ws://localhost:21505/input";
        public string Alert;

        private ClientWebSocket _whoGoesSocket;

        public Main()
        {
            _whoGoesSocket = new ClientWebSocket();
        }

        public Bitmap ProcessFrame(Bitmap frame)
        {

            // Send to WhoGoesThere via WebSocket

            AsyncHelpers.RunSync(() => SendImagesAsync(frame));

            return frame;
        }

        private async System.Threading.Tasks.Task SendImagesAsync(Bitmap frame)
        {
            Uri serverUri = new Uri("ws://localhost:49889/");

            if (_whoGoesSocket.State != WebSocketState.Open)
            {
                await _whoGoesSocket.ConnectAsync(serverUri, CancellationToken.None);
            }

            ArraySegment<byte> bytesToSend = new ArraySegment<byte>(frame.ToByteArray(ImageFormat.Png));

            await _whoGoesSocket.SendAsync(bytesToSend, WebSocketMessageType.Binary, true, CancellationToken.None);
        }

        public string Configuration
        {
            get { return _config; }
            set
            {
                _config = value;
                InitConfig();
            }
        }

        private void InitConfig()
        {
            if (_config != "")
            {
                string[] cfg = _config.Split('|');
                EndPoint = cfg[0];
            }
        }

        public string Configure()
        {
            using (var cfg = new frmSetup(this))
            {

                if (cfg.ShowDialog() == DialogResult.OK)
                {
                    _config = EndPoint;

                    InitConfig();
                }
            }

            return Configuration;
        }

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                    if (_whoGoesSocket != null && _whoGoesSocket.State == WebSocketState.Open)
                    {
                        AsyncHelpers.RunSync(() => _whoGoesSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "iSpy Plugin Shutting down.", CancellationToken.None);
                    }
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                _disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~Main()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

    }
}
