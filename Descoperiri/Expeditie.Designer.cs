namespace Descoperiri
{
    partial class Expeditie
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
            this.btnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.Orange;
            this.btnIesire.Location = new System.Drawing.Point(529, 306);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(116, 30);
            this.btnIesire.TabIndex = 0;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // Expeditie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIesire);
            this.Name = "Expeditie";
            this.Text = "Expeditie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Expeditie_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Expeditie_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIesire;
    }
}