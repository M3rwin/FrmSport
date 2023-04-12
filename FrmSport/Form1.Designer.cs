
namespace FrmSport
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpSports = new System.Windows.Forms.GroupBox();
            this.GrpSaisieSport = new System.Windows.Forms.GroupBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.TxtSport = new System.Windows.Forms.TextBox();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.GrpSaisieSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSports
            // 
            this.GrpSports.AutoSize = true;
            this.GrpSports.Location = new System.Drawing.Point(235, 12);
            this.GrpSports.Name = "GrpSports";
            this.GrpSports.Size = new System.Drawing.Size(221, 79);
            this.GrpSports.TabIndex = 0;
            this.GrpSports.TabStop = false;
            this.GrpSports.Text = "Sports";
            this.GrpSports.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GrpSaisieSport
            // 
            this.GrpSaisieSport.Controls.Add(this.BtnAjout);
            this.GrpSaisieSport.Controls.Add(this.TxtSport);
            this.GrpSaisieSport.Location = new System.Drawing.Point(12, 12);
            this.GrpSaisieSport.Name = "GrpSaisieSport";
            this.GrpSaisieSport.Size = new System.Drawing.Size(200, 52);
            this.GrpSaisieSport.TabIndex = 1;
            this.GrpSaisieSport.TabStop = false;
            this.GrpSaisieSport.Text = "Saisie d\'un sport";
            // 
            // BtnAjout
            // 
            this.BtnAjout.Enabled = false;
            this.BtnAjout.Location = new System.Drawing.Point(112, 21);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(75, 23);
            this.BtnAjout.TabIndex = 1;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // TxtSport
            // 
            this.TxtSport.Location = new System.Drawing.Point(6, 22);
            this.TxtSport.Name = "TxtSport";
            this.TxtSport.Size = new System.Drawing.Size(100, 23);
            this.TxtSport.TabIndex = 0;
            this.TxtSport.TextChanged += new System.EventHandler(this.TxtSport_TextChanged);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(699, 400);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(89, 38);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.GrpSaisieSport);
            this.Controls.Add(this.GrpSports);
            this.Name = "Form1";
            this.Text = "Exercice 2";
            this.GrpSaisieSport.ResumeLayout(false);
            this.GrpSaisieSport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpSports;
        private System.Windows.Forms.GroupBox GrpSaisieSport;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.TextBox TxtSport;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

