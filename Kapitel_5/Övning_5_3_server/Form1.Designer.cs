namespace Övning_5_3_server
{
    partial class Form1
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
            this.btnStartaServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.btnTaEmot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartaServer
            // 
            this.btnStartaServer.Location = new System.Drawing.Point(27, 25);
            this.btnStartaServer.Name = "btnStartaServer";
            this.btnStartaServer.Size = new System.Drawing.Size(136, 23);
            this.btnStartaServer.TabIndex = 0;
            this.btnStartaServer.Text = "Starta server";
            this.btnStartaServer.UseVisualStyleBackColor = true;
            this.btnStartaServer.Click += new System.EventHandler(this.btnStartaServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inkorg";
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(27, 77);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.Size = new System.Drawing.Size(400, 197);
            this.tbxInkorg.TabIndex = 2;
            // 
            // btnTaEmot
            // 
            this.btnTaEmot.Location = new System.Drawing.Point(27, 281);
            this.btnTaEmot.Name = "btnTaEmot";
            this.btnTaEmot.Size = new System.Drawing.Size(400, 23);
            this.btnTaEmot.TabIndex = 3;
            this.btnTaEmot.Text = "Ta emot ett meddelande";
            this.btnTaEmot.UseVisualStyleBackColor = true;
            this.btnTaEmot.Click += new System.EventHandler(this.btnTaEmot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 339);
            this.Controls.Add(this.btnTaEmot);
            this.Controls.Add(this.tbxInkorg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartaServer);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartaServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.Button btnTaEmot;
    }
}

