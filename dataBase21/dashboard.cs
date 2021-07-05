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
    public partial class dashboard : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=new_password;";
        OracleConnection conn;
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var loginPanel = new Form1();
            loginPanel.Show();
            this.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Color.Black;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Color.White;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.tRAINERSTableAdapter1.Fill(dataSet3.TRAINERS);
            this.mEMBERSTableAdapter.Fill(dataSet1.MEMBERS);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from members";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            memCounter.Text = dr[0].ToString();
              
        }

        private void memberAddPic_MouseHover(object sender, EventArgs e)
        {
            addNewMem.ForeColor = Color.Black;
            memberAddPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void memberAddPic_MouseLeave(object sender, EventArgs e)
        {
            addNewMem.ForeColor = Color.White;
            memberAddPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void NewInstructorAddPic_MouseHover(object sender, EventArgs e)
        {
            addNewInstruc.ForeColor = Color.Black;
            NewInstructorAddPic.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void NewInstructorAddPic_MouseLeave(object sender, EventArgs e)
        {
            addNewInstruc.ForeColor = Color.White;
            NewInstructorAddPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void viewMemberPic_MouseHover(object sender, EventArgs e)
        {
            viewMemInfo.ForeColor = Color.Black;
            viewMemberPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void viewMemberPic_MouseLeave(object sender, EventArgs e)
        {
            viewMemInfo.ForeColor = Color.White;
            viewMemberPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void viewInstrucPic_MouseHover(object sender, EventArgs e)
        {
            ViewInstrucInfo.ForeColor = Color.Black;
            viewInstrucPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void viewInstrucPic_MouseLeave(object sender, EventArgs e)
        {
            ViewInstrucInfo.ForeColor = Color.White;
            viewInstrucPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ManageMemPic_MouseHover(object sender, EventArgs e)
        {
            ManageMem.ForeColor = Color.Black;
            ManageMemPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ManageMemPic_MouseLeave(object sender, EventArgs e)
        {
            ManageMem.ForeColor = Color.White;
            ManageMemPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ManageInstrucPic_MouseHover(object sender, EventArgs e)
        {
            ManageInstruc.ForeColor = Color.Black;
            ManageInstrucPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ManageInstrucPic_MouseLeave(object sender, EventArgs e)
        {
            ManageInstruc.ForeColor = Color.White;
            ManageInstrucPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void GenReport_MouseHover(object sender, EventArgs e)
        {
            GenReport.ForeColor = Color.Black;
        }

        private void GenReport_MouseLeave(object sender, EventArgs e)
        {
            GenReport.ForeColor = Color.White;
        }
    }
}
