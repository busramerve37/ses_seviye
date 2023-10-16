namespace button.ornek._27
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
            this.tbSes = new System.Windows.Forms.TrackBar();
            this.lblSesSeviyesi = new System.Windows.Forms.Label();
            this.lblSeviyeDeger = new System.Windows.Forms.Label();
            this.lblSes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSes
            // 
            this.tbSes.Location = new System.Drawing.Point(149, 23);
            this.tbSes.Maximum = 100;
            this.tbSes.Name = "tbSes";
            this.tbSes.Size = new System.Drawing.Size(438, 45);
            this.tbSes.TabIndex = 0;
            this.tbSes.Scroll += new System.EventHandler(this.tbSes_Scroll);
            // 
            // lblSesSeviyesi
            // 
            this.lblSesSeviyesi.AutoSize = true;
            this.lblSesSeviyesi.Location = new System.Drawing.Point(45, 39);
            this.lblSesSeviyesi.Name = "lblSesSeviyesi";
            this.lblSesSeviyesi.Size = new System.Drawing.Size(67, 13);
            this.lblSesSeviyesi.TabIndex = 1;
            this.lblSesSeviyesi.Text = "Ses Seviyesi";
            // 
            // lblSeviyeDeger
            // 
            this.lblSeviyeDeger.AutoSize = true;
            this.lblSeviyeDeger.Location = new System.Drawing.Point(611, 39);
            this.lblSeviyeDeger.Name = "lblSeviyeDeger";
            this.lblSeviyeDeger.Size = new System.Drawing.Size(71, 13);
            this.lblSeviyeDeger.TabIndex = 2;
            this.lblSeviyeDeger.Text = "Seviye Değer";
            // 
            // lblSes
            // 
            this.lblSes.AutoSize = true;
            this.lblSes.Location = new System.Drawing.Point(146, 113);
            this.lblSes.Name = "lblSes";
            this.lblSes.Size = new System.Drawing.Size(28, 13);
            this.lblSes.TabIndex = 3;
            this.lblSes.Text = "Ses ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 384);
            this.Controls.Add(this.lblSes);
            this.Controls.Add(this.lblSeviyeDeger);
            this.Controls.Add(this.lblSesSeviyesi);
            this.Controls.Add(this.tbSes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbSes;
        private System.Windows.Forms.Label lblSesSeviyesi;
        private System.Windows.Forms.Label lblSeviyeDeger;
        private System.Windows.Forms.Label lblSes;
    }
}

