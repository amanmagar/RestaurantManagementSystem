using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm uf = new userForm();
            uf.ShowDialog();
        }

        private void catergoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryForm cf = new categoryForm();
            cf.ShowDialog();
        }

        private void foodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodForm ff = new foodForm();
            ff.ShowDialog();
        }

        private void companySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfoForm cif = new CompanyInfoForm();
            cif.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
