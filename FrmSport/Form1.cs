using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtSport_TextChanged(object sender, EventArgs e)
        {
            if(TxtSport.Text.Length >= 2)
            {
                BtnAjout.Enabled = true;
            }
            else
            {
                BtnAjout.Enabled = false;
            }
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            // Création checkbox
            CheckBox checkBox = new CheckBox();
            checkBox.Text = this.TxtSport.Text;


            // Ajout checkbox dans la liste
            this.GrpSports.Controls.Add(checkBox);
            int position = GrpSports.Controls.Count * 20;
            checkBox.Location = new Point(checkBox.Location.X + 10, position);

            
            this.TxtSport.Text = "";
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bah pourquoi t'a cliquer sur la croix alors fils de pute");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
