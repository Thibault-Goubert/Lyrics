namespace Lyrics
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
            this.cbx_Names = new System.Windows.Forms.ComboBox();
            this.rtb_Texte = new System.Windows.Forms.RichTextBox();
            this.tbx_Titre = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Bold = new System.Windows.Forms.Button();
            this.btn_Gray = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_Names
            // 
            this.cbx_Names.FormattingEnabled = true;
            this.cbx_Names.Location = new System.Drawing.Point(12, 12);
            this.cbx_Names.Name = "cbx_Names";
            this.cbx_Names.Size = new System.Drawing.Size(308, 21);
            this.cbx_Names.TabIndex = 0;
            this.cbx_Names.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            this.cbx_Names.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // rtb_Texte
            // 
            this.rtb_Texte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Texte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb_Texte.Location = new System.Drawing.Point(326, 39);
            this.rtb_Texte.Name = "rtb_Texte";
            this.rtb_Texte.Size = new System.Drawing.Size(462, 399);
            this.rtb_Texte.TabIndex = 1;
            this.rtb_Texte.Text = "";
            // 
            // tbx_Titre
            // 
            this.tbx_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Titre.Location = new System.Drawing.Point(326, 13);
            this.tbx_Titre.Name = "tbx_Titre";
            this.tbx_Titre.ReadOnly = true;
            this.tbx_Titre.Size = new System.Drawing.Size(460, 20);
            this.tbx_Titre.TabIndex = 2;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Ajouter.Location = new System.Drawing.Point(12, 415);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 3;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.Location = new System.Drawing.Point(245, 415);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Bold
            // 
            this.btn_Bold.Location = new System.Drawing.Point(291, 68);
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(29, 23);
            this.btn_Bold.TabIndex = 6;
            this.btn_Bold.Text = "B";
            this.btn_Bold.UseVisualStyleBackColor = true;
            this.btn_Bold.Click += new System.EventHandler(this.btn_Bold_Click);
            // 
            // btn_Gray
            // 
            this.btn_Gray.Location = new System.Drawing.Point(291, 97);
            this.btn_Gray.Name = "btn_Gray";
            this.btn_Gray.Size = new System.Drawing.Size(29, 23);
            this.btn_Gray.TabIndex = 7;
            this.btn_Gray.Text = "G";
            this.btn_Gray.UseVisualStyleBackColor = true;
            this.btn_Gray.Click += new System.EventHandler(this.btn_Gray_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Supprimer.Location = new System.Drawing.Point(12, 386);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 8;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Gray);
            this.Controls.Add(this.btn_Bold);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.tbx_Titre);
            this.Controls.Add(this.rtb_Texte);
            this.Controls.Add(this.cbx_Names);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Names;
        private System.Windows.Forms.RichTextBox rtb_Texte;
        private System.Windows.Forms.TextBox tbx_Titre;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Bold;
        private System.Windows.Forms.Button btn_Gray;
        private System.Windows.Forms.Button btn_Supprimer;
    }
}

