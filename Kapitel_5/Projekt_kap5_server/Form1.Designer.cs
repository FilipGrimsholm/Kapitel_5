﻿namespace Projekt_kap5_server
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.btnSänd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxChatrum = new System.Windows.Forms.ListBox();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.gbxUtkorg = new System.Windows.Forms.GroupBox();
            this.gbxUtkorg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(237, 23);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 2;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // btnSänd
            // 
            this.btnSänd.Location = new System.Drawing.Point(12, 56);
            this.btnSänd.Name = "btnSänd";
            this.btnSänd.Size = new System.Drawing.Size(298, 23);
            this.btnSänd.TabIndex = 3;
            this.btnSänd.Text = "Sänd";
            this.btnSänd.UseVisualStyleBackColor = true;
            this.btnSänd.Click += new System.EventHandler(this.btnSänd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chatrum";
            // 
            // lbxChatrum
            // 
            this.lbxChatrum.FormattingEnabled = true;
            this.lbxChatrum.Location = new System.Drawing.Point(30, 113);
            this.lbxChatrum.Name = "lbxChatrum";
            this.lbxChatrum.ScrollAlwaysVisible = true;
            this.lbxChatrum.Size = new System.Drawing.Size(316, 147);
            this.lbxChatrum.TabIndex = 5;
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(12, 30);
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(298, 20);
            this.tbxMeddelande.TabIndex = 6;
            // 
            // gbxUtkorg
            // 
            this.gbxUtkorg.Controls.Add(this.tbxMeddelande);
            this.gbxUtkorg.Controls.Add(this.btnSänd);
            this.gbxUtkorg.Location = new System.Drawing.Point(30, 266);
            this.gbxUtkorg.Name = "gbxUtkorg";
            this.gbxUtkorg.Size = new System.Drawing.Size(316, 90);
            this.gbxUtkorg.TabIndex = 7;
            this.gbxUtkorg.TabStop = false;
            this.gbxUtkorg.Text = "Utkorg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 385);
            this.Controls.Add(this.gbxUtkorg);
            this.Controls.Add(this.lbxChatrum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUtkorg.ResumeLayout(false);
            this.gbxUtkorg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.Button btnSänd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.GroupBox gbxUtkorg;
        private System.Windows.Forms.ListBox lbxChatrum;
    }
}
