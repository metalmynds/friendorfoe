using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendOrFoe.Plugins.iSpy
{
    public partial class frmSetup : Form
    {
        private readonly Main _owner;

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
    }
}
