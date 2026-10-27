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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expeditie));
            this.btnIesire = new System.Windows.Forms.Button();
            this.lblExploratori = new System.Windows.Forms.Label();
            this.lblIesire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.Orange;
            this.btnIesire.Location = new System.Drawing.Point(613, 367);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(116, 30);
            this.btnIesire.TabIndex = 0;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblExploratori
            // 
            this.lblExploratori.AutoSize = true;
            this.lblExploratori.Location = new System.Drawing.Point(610, 100);
            this.lblExploratori.Name = "lblExploratori";
            this.lblExploratori.Size = new System.Drawing.Size(35, 13);
            this.lblExploratori.TabIndex = 1;
            this.lblExploratori.Text = "label1";
            // 
            // lblIesire
            // 
            this.lblIesire.AutoSize = true;
            this.lblIesire.Location = new System.Drawing.Point(584, 400);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(187, 13);
            this.lblIesire.TabIndex = 2;
            this.lblIesire.Text = "Iesire: click pe butonul Iesire sau tasta";
            // 
            // Expeditie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.lblExploratori);
            this.Controls.Add(this.btnIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Expeditie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expeditie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Expeditie_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label lblExploratori;
        private System.Windows.Forms.Label lblIesire;
    }
}