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
            this.picExplorator = new System.Windows.Forms.PictureBox();
            this.lblRegula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picExplorator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExploratori
            // 
            this.lblExploratori.AutoSize = true;
            this.lblExploratori.Location = new System.Drawing.Point(245, 40);
            this.lblExploratori.Name = "lblExploratori";
            this.lblExploratori.Size = new System.Drawing.Size(97, 13);
            this.lblExploratori.TabIndex = 0;
            this.lblExploratori.Text = "Cati exploratori ai?";
            // 
            // txtExploratori
            // 
            this.txtExploratori.Location = new System.Drawing.Point(360, 37);
            this.txtExploratori.Name = "txtExploratori";
            this.txtExploratori.Size = new System.Drawing.Size(53, 20);
            this.txtExploratori.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Orange;
            this.btnSet.Location = new System.Drawing.Point(248, 87);
            this.btnSet.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(165, 35);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // picExplorator
            // 
            this.picExplorator.Image = global::Descoperiri.Properties.Resources.explorator;
            this.picExplorator.Location = new System.Drawing.Point(55, 21);
            this.picExplorator.Name = "picExplorator";
            this.picExplorator.Size = new System.Drawing.Size(109, 124);
            this.picExplorator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExplorator.TabIndex = 3;
            this.picExplorator.TabStop = false;
            // 
            // lblRegula
            // 
            this.lblRegula.AutoSize = true;
            this.lblRegula.Location = new System.Drawing.Point(291, 60);
            this.lblRegula.Name = "lblRegula";
            this.lblRegula.Size = new System.Drawing.Size(122, 13);
            this.lblRegula.TabIndex = 4;
            this.lblRegula.Text = "un numar intre 30 si 200";
            // 
            // Exploratori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(457, 155);
            this.Controls.Add(this.lblRegula);
            this.Controls.Add(this.picExplorator);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtExploratori);
            this.Controls.Add(this.lblExploratori);
            this.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Exploratori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exploratori";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exploratori_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picExplorator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExploratori;
        private System.Windows.Forms.TextBox txtExploratori;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.PictureBox picExplorator;
        private System.Windows.Forms.Label lblRegula;
    }
}