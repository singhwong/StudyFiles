using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._25_Panel控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            Regular myregular = new Regular();
            myregular.TopLevel = false;
            this.panel1.Controls.Add(myregular);
            myregular.FormBorderStyle = FormBorderStyle.None;
            myregular.BringToFront();
            myregular.Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download mydownload = new Download();
            mydownload.TopLevel = false;
            this.panel1.Controls.Add(mydownload);
            mydownload.FormBorderStyle = FormBorderStyle.None;
            mydownload.BringToFront();
            mydownload.Show();
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            Appearance myappearance = new Appearance();
            myappearance.TopLevel = false;
            this.panel1.Controls.Add(myappearance);
            myappearance.FormBorderStyle = FormBorderStyle.None;
            myappearance.BringToFront();
            myappearance.Show();
        }

        private void btnRemteDownload_Click(object sender, EventArgs e)
        {
            RemoteDownload myRD = new RemoteDownload();
            myRD.TopLevel = false;
            this.panel1.Controls.Add(myRD);
            myRD.FormBorderStyle = FormBorderStyle.None;
            myRD.BringToFront();
            myRD.Show();
        }
    }
}
