namespace VB6Bridge
{
    partial class RequestRemarksBridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestRemarksBridge));
            this.axRequestRemarkCtrl1 = new AxRequestRemark.AxRequestRemarkCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.axRequestRemarkCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axRequestRemarkCtrl1
            // 
            this.axRequestRemarkCtrl1.Enabled = true;
            this.axRequestRemarkCtrl1.Location = new System.Drawing.Point(0, 0);
            this.axRequestRemarkCtrl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axRequestRemarkCtrl1.Name = "axRequestRemarkCtrl1";
            this.axRequestRemarkCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRequestRemarkCtrl1.OcxState")));
            this.axRequestRemarkCtrl1.Size = new System.Drawing.Size(61, 35);
            this.axRequestRemarkCtrl1.TabIndex = 0;
            // 
            // RequestRemarksBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axRequestRemarkCtrl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RequestRemarksBridge";
            this.Size = new System.Drawing.Size(60, 36);
            this.Leave += new System.EventHandler(this.RequestRemarksBridge_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.axRequestRemarkCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxRequestRemark.AxRequestRemarkCtrl axRequestRemarkCtrl1;
    }
}
