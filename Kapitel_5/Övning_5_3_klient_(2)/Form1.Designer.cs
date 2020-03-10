namespace Övning_5_3_klient__2_
{
    partial class FrmKlient
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
            this.tbxIPaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxUtkorg = new System.Windows.Forms.TextBox();
            this.btnSänd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxIPaddress
            // 
            this.tbxIPaddress.Location = new System.Drawing.Point(169, 22);
            this.tbxIPaddress.Name = "tbxIPaddress";
            this.tbxIPaddress.Size = new System.Drawing.Size(100, 20);
            this.tbxIPaddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serverns IP-address";
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(169, 48);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(100, 23);
            this.btnAnslut.TabIndex = 2;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxUtkorg);
            this.groupBox1.Location = new System.Drawing.Point(32, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utkorg";
            // 
            // tbxUtkorg
            // 
            this.tbxUtkorg.Location = new System.Drawing.Point(6, 19);
            this.tbxUtkorg.Multiline = true;
            this.tbxUtkorg.Name = "tbxUtkorg";
            this.tbxUtkorg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxUtkorg.Size = new System.Drawing.Size(225, 75);
            this.tbxUtkorg.TabIndex = 4;
            // 
            // btnSänd
            // 
            this.btnSänd.Enabled = false;
            this.btnSänd.Location = new System.Drawing.Point(32, 183);
            this.btnSänd.Name = "btnSänd";
            this.btnSänd.Size = new System.Drawing.Size(237, 23);
            this.btnSänd.TabIndex = 5;
            this.btnSänd.Text = "Sänd";
            this.btnSänd.UseVisualStyleBackColor = true;
            this.btnSänd.Click += new System.EventHandler(this.btnSänd_Click);
            // 
            // FrmKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 245);
            this.Controls.Add(this.btnSänd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIPaddress);
            this.Name = "FrmKlient";
            this.Text = "Klient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIPaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxUtkorg;
        private System.Windows.Forms.Button btnSänd;
    }
}

