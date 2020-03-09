namespace Övning_5_4_server
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
            this.pbxCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCar
            // 
            this.pbxCar.Image = global::Övning_5_4_server.Properties.Resources._1;
            this.pbxCar.Location = new System.Drawing.Point(101, 94);
            this.pbxCar.Name = "pbxCar";
            this.pbxCar.Size = new System.Drawing.Size(189, 106);
            this.pbxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCar.TabIndex = 1;
            this.pbxCar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 294);
            this.Controls.Add(this.pbxCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCar;
    }
}

