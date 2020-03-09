namespace Övning_5_4_klient
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
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnVänster = new System.Windows.Forms.Button();
            this.btnHöger = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.tbxIPadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpp
            // 
            this.btnUpp.Location = new System.Drawing.Point(155, 100);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(75, 23);
            this.btnUpp.TabIndex = 13;
            this.btnUpp.Text = "Upp";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.btnUpp_Click);
            // 
            // btnVänster
            // 
            this.btnVänster.Location = new System.Drawing.Point(50, 172);
            this.btnVänster.Name = "btnVänster";
            this.btnVänster.Size = new System.Drawing.Size(75, 23);
            this.btnVänster.TabIndex = 12;
            this.btnVänster.Text = "Vänster";
            this.btnVänster.UseVisualStyleBackColor = true;
            this.btnVänster.Click += new System.EventHandler(this.btnVänster_Click);
            // 
            // btnHöger
            // 
            this.btnHöger.Location = new System.Drawing.Point(249, 172);
            this.btnHöger.Name = "btnHöger";
            this.btnHöger.Size = new System.Drawing.Size(75, 23);
            this.btnHöger.TabIndex = 11;
            this.btnHöger.Text = "Höger";
            this.btnHöger.UseVisualStyleBackColor = true;
            this.btnHöger.Click += new System.EventHandler(this.btnHöger_Click);
            // 
            // btnNer
            // 
            this.btnNer.Location = new System.Drawing.Point(155, 242);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(75, 23);
            this.btnNer.TabIndex = 10;
            this.btnNer.Text = "Ner";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.btnNer_Click);
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(220, 4);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 9;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // tbxIPadress
            // 
            this.tbxIPadress.Location = new System.Drawing.Point(114, 6);
            this.tbxIPadress.Name = "tbxIPadress";
            this.tbxIPadress.Size = new System.Drawing.Size(100, 20);
            this.tbxIPadress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Serverns IP-adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 317);
            this.Controls.Add(this.btnUpp);
            this.Controls.Add(this.btnVänster);
            this.Controls.Add(this.btnHöger);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxIPadress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.Button btnVänster;
        private System.Windows.Forms.Button btnHöger;
        private System.Windows.Forms.Button btnNer;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.TextBox tbxIPadress;
        private System.Windows.Forms.Label label1;
    }
}

