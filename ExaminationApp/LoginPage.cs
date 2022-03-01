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
    public partial class LoginPage : Form
    {
        List<Student> students;
        List<Instructor> instructors;
        public static int student_id;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool checkd= checkBox1.Checked; //checkbox state 
            DataAccess da = new DataAccess();
            bool userFound = false; // user state 

            try
            {
                string nId = textBox1.Text;
                string password = textBox2.Text;

                if (!checkd)
                {
                    students = da.getAllStudents();
                    foreach (Student student in students)
                    {
                        if (student.St_National_id == int.Parse(nId) && student.St_Password == password)
                        {
                            userFound = true;                  
                            DataAccess.UserIdToken = student.St_id;
                            student_id = student.St_id;
                            StudentWelcomPage welcomePage = new StudentWelcomPage();
                          
                            welcomePage.Show();                          
                            this.Hide();            
                            break;
                        }
                    }
                    
                }
                else
                {
                    instructors = da.getAllInstructors();

                    foreach (Instructor instructor in instructors)
                    {
                        //if (instructor.Ins_National_id == int.Parse(nId) && instructor.Ins_Password == password)
                        //{
                        //    userFound = true;
                        //    DataAccess.UserIdToken = instructor.Ins_id;
                        //  //  InstructorWelcomPage welcomeInsPage =new InstructorWelcomPage();
                        //    welcomeInsPage.Show();
                        //    this.Hide();
                          
                        //    break;
                        //}
                    }
                }
                if (!userFound)
                {
                    MessageBox.Show("User Not Found, Please check username and password again", "Error");
                }

            }
            catch (Exception ex)
            {
               
             
                MessageBox.Show(ex.Message);

            }


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            checkBox1.BackColor= System.Drawing.Color.Transparent;

        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
     



    }
}
