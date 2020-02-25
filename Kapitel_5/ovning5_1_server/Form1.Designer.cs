namespace ovning5_1_server
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
            this.tbxServerPortnr = new System.Windows.Forms.TextBox();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTagEmot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxServerPortnr
            // 
            this.tbxServerPortnr.Location = new System.Drawing.Point(150, 35);
            this.tbxServerPortnr.Name = "tbxServerPortnr";
            this.tbxServerPortnr.Size = new System.Drawing.Size(84, 20);
            this.tbxServerPortnr.TabIndex = 0;
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(6, 19);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.Size = new System.Drawing.Size(188, 75);
            this.tbxInkorg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serverns portnummer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxInkorg);
            this.groupBox1.Location = new System.Drawing.Point(34, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inkorg";
            // 
            // btnTagEmot
            // 
            this.btnTagEmot.Location = new System.Drawing.Point(34, 191);
            this.btnTagEmot.Name = "btnTagEmot";
            this.btnTagEmot.Size = new System.Drawing.Size(200, 23);
            this.btnTagEmot.TabIndex = 4;
            this.btnTagEmot.Text = "Tag emot";
            this.btnTagEmot.UseVisualStyleBackColor = true;
            this.btnTagEmot.Click += new System.EventHandler(this.btnTagEmot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 249);
            this.Controls.Add(this.btnTagEmot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxServerPortnr);
            this.Name = "Form1";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxServerPortnr;
        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTagEmot;
    }
}

