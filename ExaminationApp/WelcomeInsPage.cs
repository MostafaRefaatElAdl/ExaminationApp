using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationApp
{
    public partial class WelcomeInsPage : Form
    {
        DataAccess da=new DataAccess();
        Instructor Instructor;
        public WelcomeInsPage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void WelcomeInsPage_Load(object sender, EventArgs e)
        {
            Instructor=da.getInstructor();
            lblName.Text = Instructor.InsF_Name + " " + Instructor.InsL_Name;
        }
    }
}
