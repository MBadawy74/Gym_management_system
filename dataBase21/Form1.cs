using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace dataBase21
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unTxtBox_MouseHover(object sender, EventArgs e)
        {
            if (unTxtBox.Text.Equals("Enter Username..."))
                unTxtBox.Text = "";
            userNamePanel.BackColor = Color.Blue;
            unTxtBox.ForeColor = Color.DimGray;
            if (unTxtBox.BackColor == Color.Red)
            {
                unTxtBox.BackColor = Color.White;
            }
        }

        private void unTxtBox_MouseLeave(object sender, EventArgs e)
        {
            if (unTxtBox.Text.Equals(""))
                unTxtBox.Text = "Enter Username...";
            userNamePanel.BackColor = Color.DimGray;
        }

        private void pTxtBox_MouseHover(object sender, EventArgs e)
        {
            if (pTxtBox.Text.Equals("Enter Password..."))
                pTxtBox.Text = "";
            pPanel.BackColor = Color.Blue;
            if (pTxtBox.BackColor == Color.Red)
            {
                pTxtBox.BackColor = Color.White;
            }
        }

        private void pTxtBox_MouseLeave(object sender, EventArgs e)
        {
            if (pTxtBox.Text.Equals(""))
                pTxtBox.Text = "Enter Password...";
            pPanel.BackColor = Color.DimGray;
        }

        

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void logLabel_MouseHover(object sender, EventArgs e)
        {
            logLabel.ForeColor = Color.Black;
        }

        private void logLabel_MouseLeave(object sender, EventArgs e)
        {
            logLabel.ForeColor = Color.LightSeaGreen;
        }

        private void pTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            pTxtBox.PasswordChar = 'x';
        }

        private void logLabel_Click(object sender, EventArgs e)
        {
            if (unTxtBox.Text.Equals("admin") && pTxtBox.Text.Equals("admin"))
            {
                var dash = new dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID LOGIN CARDENTIALS!");
                unTxtBox.BackColor = Color.Red;
                pTxtBox.BackColor = Color.Red;
                unTxtBox.Text = "";
                pTxtBox.Text = "";
            }
        }

    }
}
