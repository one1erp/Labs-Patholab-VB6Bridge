namespace VB6Bridge
{
    partial class OrganBridge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganBridge));
            this.axOrganCtrl1 = new AxOrgan.AxOrganCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.axOrganCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axOrganCtrl1
            // 
            this.axOrganCtrl1.Enabled = true;
            this.axOrganCtrl1.Location = new System.Drawing.Point(0, 0);
            this.axOrganCtrl1.Name = "axOrganCtrl1";
            this.axOrganCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOrganCtrl1.OcxState")));
            this.axOrganCtrl1.Size = new System.Drawing.Size(122, 50);
            this.axOrganCtrl1.TabIndex = 0;
            this.axOrganCtrl1.ClickEvent += new System.EventHandler(this.axOrganCtrl2_ClickEvent);
            this.axOrganCtrl1.Leave += new System.EventHandler(this.axOrganCtrl1_Leave);
            // 
            // OrganBridge
            // 
            this.Controls.Add(this.axOrganCtrl1);
            this.Name = "OrganBridge";
            this.Size = new System.Drawing.Size(124, 52);
            ((System.ComponentModel.ISupportInitialize)(this.axOrganCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxOrgan.AxOrganCtrl axOrganCtrl1;
    }
}
