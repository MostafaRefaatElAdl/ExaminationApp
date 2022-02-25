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
    public partial class WelcomeStPage : Form
    {
        Student student;
        DataAccess da = new DataAccess();
        List<StudentGrades> studentGrades = new List<StudentGrades>();
        public WelcomeStPage()
        {
            InitializeComponent();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            lblName.BackColor = System.Drawing.Color.Transparent;
            
            button2.BackColor=System.Drawing.Color.Transparent;
            button3.BackColor= System.Drawing.Color.Transparent;

            listBox.Hide();

            student = da.getStudent();
            lblName.Text = student.StF_Name+" "+student.StL_Name; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Show();
          //  studentGrades = da.getStudentGrades();
            
            listBox.DataSource=studentGrades;
            listBox.DisplayMember = "Student_Status";

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //listBox.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
