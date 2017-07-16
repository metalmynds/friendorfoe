namespace FriendOrFoe.Plugins.iSpy
{
    partial class frmSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEndPointAddress = new System.Windows.Forms.Label();
            this.txtEndPointAddress = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.errEndPoint = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errEndPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndPointAddress
            // 
            this.lblEndPointAddress.AutoSize = true;
            this.lblEndPointAddress.Location = new System.Drawing.Point(22, 19);
            this.lblEndPointAddress.Name = "lblEndPointAddress";
            this.lblEndPointAddress.Size = new System.Drawing.Size(141, 20);
            this.lblEndPointAddress.TabIndex = 0;
            this.lblEndPointAddress.Text = "End Point Address";
            // 
            // txtEndPointAddress
            // 
            this.txtEndPointAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndPointAddress.Location = new System.Drawing.Point(169, 16);
            this.txtEndPointAddress.Name = "txtEndPointAddress";
            this.txtEndPointAddress.Size = new System.Drawing.Size(491, 26);
            this.txtEndPointAddress.TabIndex = 1;
            this.txtEndPointAddress.TextChanged += new System.EventHandler(this.txtEndPointAddress_TextChanged);
            // 
            // butSave
            // 
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(500, 64);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(77, 33);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(583, 64);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(77, 33);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // errEndPoint
            // 
            this.errEndPoint.ContainerControl = this;
            // 
            // frmSetup
            // 
            this.AcceptButton = this.butSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(687, 109);
            this.ControlBox = false;
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtEndPointAddress);
            this.Controls.Add(this.lblEndPointAddress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friend Or Foe Setup";
            ((System.ComponentModel.ISupportInitialize)(this.errEndPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndPointAddress;
        private System.Windows.Forms.TextBox txtEndPointAddress;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ErrorProvider errEndPoint;
    }
}