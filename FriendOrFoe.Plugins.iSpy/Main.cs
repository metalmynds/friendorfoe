using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Net.WebSockets;

namespace FriendOrFoe.Plugins.iSpy
{
    public class Main : IDisposable
    {
        private string _config = "";
        private bool _disposed;
        //internal int LineWidth = 1;
        public string Alert;

        private ClientWebSocket _whoGoesSocket;

        public Main()
        {
            _whoGoesSocket = new ClientWebSocket();

            
        }

        public Bitmap ProcessFrame(Bitmap frame)
        {

            // Base64 Encode the Image

            var encodedImage = Convert.ToBase64String(frame.ToByteArray(ImageFormat.Png));

            // Send to WhoGoesThere via WebSocket



            return frame;
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
            //if (_config != "")
            //{
            //    string[] cfg = _config.Split('|');
            //    LineWidth = Convert.ToInt32(cfg[0]);
            //}
        }

        public string Configure()
        {
            using (var cfg = new frmSetup(this))
            {

                if (cfg.ShowDialog() == DialogResult.OK)
                {
                    //_config = LineWidth.ToString();

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
