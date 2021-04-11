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
            this.SuspendLayout();
            // 
            // lab_Titre
            // 
            this.lab_Titre.AutoSize = true;
            this.lab_Titre.Location = new System.Drawing.Point(41, 69);
            this.lab_Titre.Name = "lab_Titre";
            this.lab_Titre.Size = new System.Drawing.Size(28, 13);
            this.lab_Titre.TabIndex = 0;
            this.lab_Titre.Text = "Titre";
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Location = new System.Drawing.Point(41, 26);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(29, 13);
            this.lab_Nom.TabIndex = 0;
            this.lab_Nom.Text = "Nom";
            // 
            // tbx_Nom
            // 
            this.tbx_Nom.Location = new System.Drawing.Point(82, 23);
            this.tbx_Nom.Name = "tbx_Nom";
            this.tbx_Nom.Size = new System.Drawing.Size(317, 20);
            this.tbx_Nom.TabIndex = 1;
            // 
            // tbx_Titre
            // 
            this.tbx_Titre.Location = new System.Drawing.Point(82, 66);
            this.tbx_Titre.Name = "tbx_Titre";
            this.tbx_Titre.Size = new System.Drawing.Size(317, 20);
            this.tbx_Titre.TabIndex = 1;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(418, 44);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 2;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // FenetreAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 114);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.tbx_Titre);
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
    }
}