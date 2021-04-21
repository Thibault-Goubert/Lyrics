namespace Lyrics
{
    partial class FenetreAjouter
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
            this.lab_Titre = new System.Windows.Forms.Label();
            this.lab_Nom = new System.Windows.Forms.Label();
            this.tbx_Nom = new System.Windows.Forms.TextBox();
            this.tbx_Titre = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.lab_Link = new System.Windows.Forms.Label();
            this.tbx_Link = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_Titre
            // 
            this.lab_Titre.AutoSize = true;
            this.lab_Titre.Location = new System.Drawing.Point(18, 15);
            this.lab_Titre.Name = "lab_Titre";
            this.lab_Titre.Size = new System.Drawing.Size(28, 13);
            this.lab_Titre.TabIndex = 0;
            this.lab_Titre.Text = "Titre";
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Location = new System.Drawing.Point(18, 51);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(29, 13);
            this.lab_Nom.TabIndex = 0;
            this.lab_Nom.Text = "Nom";
            // 
            // tbx_Nom
            // 
            this.tbx_Nom.Location = new System.Drawing.Point(59, 48);
            this.tbx_Nom.Name = "tbx_Nom";
            this.tbx_Nom.Size = new System.Drawing.Size(317, 20);
            this.tbx_Nom.TabIndex = 1;
            // 
            // tbx_Titre
            // 
            this.tbx_Titre.Location = new System.Drawing.Point(59, 12);
            this.tbx_Titre.Name = "tbx_Titre";
            this.tbx_Titre.Size = new System.Drawing.Size(317, 20);
            this.tbx_Titre.TabIndex = 1;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(400, 12);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 92);
            this.btn_Valider.TabIndex = 2;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // lab_Link
            // 
            this.lab_Link.AutoSize = true;
            this.lab_Link.Location = new System.Drawing.Point(18, 87);
            this.lab_Link.Name = "lab_Link";
            this.lab_Link.Size = new System.Drawing.Size(27, 13);
            this.lab_Link.TabIndex = 0;
            this.lab_Link.Text = "Link";
            // 
            // tbx_Link
            // 
            this.tbx_Link.Location = new System.Drawing.Point(59, 84);
            this.tbx_Link.Name = "tbx_Link";
            this.tbx_Link.Size = new System.Drawing.Size(317, 20);
            this.tbx_Link.TabIndex = 1;
            // 
            // FenetreAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 127);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.tbx_Titre);
            this.Controls.Add(this.tbx_Link);
            this.Controls.Add(this.lab_Link);
            this.Controls.Add(this.tbx_Nom);
            this.Controls.Add(this.lab_Nom);
            this.Controls.Add(this.lab_Titre);
            this.Name = "FenetreAjouter";
            this.Text = "FenetreAjouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Titre;
        private System.Windows.Forms.Label lab_Nom;
        private System.Windows.Forms.TextBox tbx_Nom;
        private System.Windows.Forms.TextBox tbx_Titre;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Label lab_Link;
        private System.Windows.Forms.TextBox tbx_Link;
    }
}