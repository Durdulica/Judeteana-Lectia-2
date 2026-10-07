namespace Descoperiri
{
    partial class Exploratori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exploratori));
            this.lblExploratori = new System.Windows.Forms.Label();
            this.txtExploratori = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExploratori
            // 
            this.lblExploratori.AutoSize = true;
            this.lblExploratori.Location = new System.Drawing.Point(245, 40);
            this.lblExploratori.Name = "lblExploratori";
            this.lblExploratori.Size = new System.Drawing.Size(93, 13);
            this.lblExploratori.TabIndex = 0;
            this.lblExploratori.Text = "Cati exploratori ai?";
            // 
            // txtExploratori
            // 
            this.txtExploratori.Location = new System.Drawing.Point(376, 37);
            this.txtExploratori.Name = "txtExploratori";
            this.txtExploratori.Size = new System.Drawing.Size(53, 20);
            this.txtExploratori.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Orange;
            this.btnSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSet.Location = new System.Drawing.Point(248, 80);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(181, 34);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Descoperiri.Properties.Resources.explorator;
            this.pictureBox1.Location = new System.Drawing.Point(55, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Exploratori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 155);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtExploratori);
            this.Controls.Add(this.lblExploratori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exploratori";
            this.Text = "Exploratori";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exploratori_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExploratori;
        private System.Windows.Forms.TextBox txtExploratori;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}