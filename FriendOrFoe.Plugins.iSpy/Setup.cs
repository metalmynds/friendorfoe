using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendOrFoe.Plugins.iSpy
{
    public partial class frmSetup : Form
    {
        private readonly Main _owner;
        private static Regex regexValidateUrl = new Regex(
      "(?<Protocol>\\w+):\\/\\/(?<Domain>[\\w@][\\w.:@]+)\\/?[\\w\\." +
      "?=%&=\\-@/$,]*",
    RegexOptions.IgnoreCase
    | RegexOptions.CultureInvariant
    | RegexOptions.IgnorePatternWhitespace
    | RegexOptions.Compiled
    );


        public frmSetup(Main owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            

            _owner.EndPoint = txtEndPointAddress.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtEndPointAddress_TextChanged(object sender, EventArgs e)
        {
            butSave.Enabled = false;

            // Validate Url

            var endPoint = txtEndPointAddress.Text;

            try
            {


                var endPointUri = new Uri(endPoint);

                if (endPointUri.Scheme != "ws")
                {
                    errEndPoint.SetError(txtEndPointAddress, "The End Point Must Be a WebSocket!");

                    return;

                }

                if (!endPoint.EndsWith("/input"))
                {
                    errEndPoint.SetError(txtEndPointAddress, "The End Point Must Finsh with /input");

                    return;

                }

            }
            catch (Exception ex)
            {

                errEndPoint.SetError(txtEndPointAddress, $"The End Point Url Format is Not Valid!\nError: {ex.Message}");

                return;
            }

            errEndPoint.Clear();

            butSave.Enabled = true;
        }
    }
}
