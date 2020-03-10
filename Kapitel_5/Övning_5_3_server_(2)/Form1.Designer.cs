namespace Övning_5_3_server__2_
{
    partial class FrmServer
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
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.gbxInkorg = new System.Windows.Forms.GroupBox();
            this.gbxInkorg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(6, 19);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxInkorg.Size = new System.Drawing.Size(377, 199);
            this.tbxInkorg.TabIndex = 1;
            // 
            // gbxInkorg
            // 
            this.gbxInkorg.Controls.Add(this.tbxInkorg);
            this.gbxInkorg.Location = new System.Drawing.Point(12, 12);
            this.gbxInkorg.Name = "gbxInkorg";
            this.gbxInkorg.Size = new System.Drawing.Size(389, 224);
            this.gbxInkorg.TabIndex = 2;
            this.gbxInkorg.TabStop = false;
            this.gbxInkorg.Text = "Inkorg";
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 257);
            this.Controls.Add(this.gbxInkorg);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.gbxInkorg.ResumeLayout(false);
            this.gbxInkorg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.GroupBox gbxInkorg;
    }
}

