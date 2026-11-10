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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHrana = new System.Windows.Forms.Label();
            this.lblBogatii = new System.Windows.Forms.Label();
            this.lblIncarcatura = new System.Windows.Forms.Label();
            this.pcBoxExplorator = new System.Windows.Forms.PictureBox();
            this.pcBoxHrana = new System.Windows.Forms.PictureBox();
            this.pcBoxBogatii = new System.Windows.Forms.PictureBox();
            this.pcBoxIncarcatura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxExplorator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxHrana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxBogatii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxIncarcatura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.Orange;
            this.btnIesire.Location = new System.Drawing.Point(710, 619);
            this.btnIesire.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(165, 35);
            this.btnIesire.TabIndex = 0;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblExploratori
            // 
            this.lblExploratori.AutoSize = true;
            this.lblExploratori.Location = new System.Drawing.Point(57, 0);
            this.lblExploratori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExploratori.Name = "lblExploratori";
            this.lblExploratori.Size = new System.Drawing.Size(47, 19);
            this.lblExploratori.TabIndex = 1;
            this.lblExploratori.Text = "label1";
            // 
            // lblIesire
            // 
            this.lblIesire.AutoSize = true;
            this.lblIesire.Location = new System.Drawing.Point(397, 627);
            this.lblIesire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(309, 19);
            this.lblIesire.TabIndex = 2;
            this.lblIesire.Text = "Iesire: click pe butonul Iesire sau tasta ESC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 606);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Controls.Add(this.pcBoxIncarcatura, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcBoxHrana, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pcBoxExplorator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblExploratori, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHrana, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBogatii, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIncarcatura, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcBoxBogatii, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(656, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(187, 90);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblHrana
            // 
            this.lblHrana.AutoSize = true;
            this.lblHrana.Location = new System.Drawing.Point(56, 22);
            this.lblHrana.Name = "lblHrana";
            this.lblHrana.Size = new System.Drawing.Size(50, 19);
            this.lblHrana.TabIndex = 2;
            this.lblHrana.Text = "label2";
            // 
            // lblBogatii
            // 
            this.lblBogatii.AutoSize = true;
            this.lblBogatii.Location = new System.Drawing.Point(56, 44);
            this.lblBogatii.Name = "lblBogatii";
            this.lblBogatii.Size = new System.Drawing.Size(50, 19);
            this.lblBogatii.TabIndex = 3;
            this.lblBogatii.Text = "label3";
            // 
            // lblIncarcatura
            // 
            this.lblIncarcatura.AutoSize = true;
            this.lblIncarcatura.Location = new System.Drawing.Point(56, 68);
            this.lblIncarcatura.Name = "lblIncarcatura";
            this.lblIncarcatura.Size = new System.Drawing.Size(51, 19);
            this.lblIncarcatura.TabIndex = 4;
            this.lblIncarcatura.Text = "label4";
            // 
            // pcBoxExplorator
            // 
            this.pcBoxExplorator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcBoxExplorator.Image = global::Descoperiri.Properties.Resources.explorator;
            this.pcBoxExplorator.Location = new System.Drawing.Point(3, 3);
            this.pcBoxExplorator.Name = "pcBoxExplorator";
            this.pcBoxExplorator.Size = new System.Drawing.Size(47, 16);
            this.pcBoxExplorator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxExplorator.TabIndex = 5;
            this.pcBoxExplorator.TabStop = false;
            // 
            // pcBoxHrana
            // 
            this.pcBoxHrana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcBoxHrana.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxHrana.Image")));
            this.pcBoxHrana.Location = new System.Drawing.Point(3, 25);
            this.pcBoxHrana.Name = "pcBoxHrana";
            this.pcBoxHrana.Size = new System.Drawing.Size(47, 16);
            this.pcBoxHrana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxHrana.TabIndex = 6;
            this.pcBoxHrana.TabStop = false;
            // 
            // pcBoxBogatii
            // 
            this.pcBoxBogatii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcBoxBogatii.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxBogatii.Image")));
            this.pcBoxBogatii.Location = new System.Drawing.Point(3, 47);
            this.pcBoxBogatii.Name = "pcBoxBogatii";
            this.pcBoxBogatii.Size = new System.Drawing.Size(47, 16);
            this.pcBoxBogatii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxBogatii.TabIndex = 7;
            this.pcBoxBogatii.TabStop = false;
            // 
            // pcBoxIncarcatura
            // 
            this.pcBoxIncarcatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcBoxIncarcatura.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxIncarcatura.Image")));
            this.pcBoxIncarcatura.Location = new System.Drawing.Point(3, 71);
            this.pcBoxIncarcatura.Name = "pcBoxIncarcatura";
            this.pcBoxIncarcatura.Size = new System.Drawing.Size(47, 16);
            this.pcBoxIncarcatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxIncarcatura.TabIndex = 8;
            this.pcBoxIncarcatura.TabStop = false;
            // 
            // Expeditie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(937, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Expeditie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expeditie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Expeditie_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Expeditie_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxExplorator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxHrana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxBogatii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxIncarcatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label lblExploratori;
        private System.Windows.Forms.Label lblIesire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHrana;
        private System.Windows.Forms.Label lblBogatii;
        private System.Windows.Forms.Label lblIncarcatura;
        private System.Windows.Forms.PictureBox pcBoxHrana;
        private System.Windows.Forms.PictureBox pcBoxExplorator;
        private System.Windows.Forms.PictureBox pcBoxIncarcatura;
        private System.Windows.Forms.PictureBox pcBoxBogatii;
    }
}