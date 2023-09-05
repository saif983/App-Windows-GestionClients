namespace Gestion
{
    partial class connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomUtilZT = new System.Windows.Forms.TextBox();
            this.MotDePasseZT = new System.Windows.Forms.TextBox();
            this.Seconnecter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 62);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Système De Gestion De Client";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 16);
            this.panel2.TabIndex = 1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 74);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(96, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom De Utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(96, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot De Passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomUtilZT
            // 
            this.NomUtilZT.Location = new System.Drawing.Point(101, 193);
            this.NomUtilZT.Name = "NomUtilZT";
            this.NomUtilZT.Size = new System.Drawing.Size(191, 31);
            this.NomUtilZT.TabIndex = 5;
            // 
            // MotDePasseZT
            // 
            this.MotDePasseZT.Location = new System.Drawing.Point(101, 273);
            this.MotDePasseZT.Name = "MotDePasseZT";
            this.MotDePasseZT.PasswordChar = '*';
            this.MotDePasseZT.Size = new System.Drawing.Size(191, 31);
            this.MotDePasseZT.TabIndex = 6;
            // 
            // Seconnecter
            // 
            this.Seconnecter.BackColor = System.Drawing.Color.DarkBlue;
            this.Seconnecter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Seconnecter.FlatAppearance.BorderSize = 0;
            this.Seconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seconnecter.ForeColor = System.Drawing.Color.White;
            this.Seconnecter.Location = new System.Drawing.Point(120, 333);
            this.Seconnecter.Name = "Seconnecter";
            this.Seconnecter.Size = new System.Drawing.Size(151, 42);
            this.Seconnecter.TabIndex = 7;
            this.Seconnecter.Text = "Se Connecter";
            this.Seconnecter.UseVisualStyleBackColor = false;
            this.Seconnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(138, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Relnitialiser";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seconnecter);
            this.Controls.Add(this.MotDePasseZT);
            this.Controls.Add(this.NomUtilZT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TextBox NomUtilZT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MotDePasseZT;
        private System.Windows.Forms.Button Seconnecter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

