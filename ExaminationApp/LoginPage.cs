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
                           StudentWelcomPage welcomePage = new StudentWelcomPage();
                            welcomePage.Show();
                            this.Hide();
                            //this.Close();
                            break;
                        }
                    }
                    
                }
                else
                {
                    instructors = da.getAllInstructors();

                    foreach (Instructor instructor in instructors)
                    {
                        if (instructor.Ins_National_id == int.Parse(nId) && instructor.Ins_Password == password)
                        {
                            userFound = true;
                            DataAccess.UserIdToken = instructor.Ins_id;
                            WelcomeInsPage welcomeInsPage=new WelcomeInsPage();
                            welcomeInsPage.Show();
                            this.Hide();
                            //this.Close();
                            break;
                        }
                    }
                }
                if (!userFound)
                {
                    MessageBox.Show("User Not Found, Please check username and password again", "Error");
                }

            }
            catch (Exception ex)
            {
               
               // MessageBox.Show("Please Inputs valid data First", "Error");
                MessageBox.Show(ex.Message);

            }



            /*
                        if (!checkd) { 
                        try
                        {
                            string nId = textBox1.Text;
                            string password = textBox2.Text;
                            students = da.getAllStudents();
                            bool userFound = false;

                            foreach (Student student in students)
                            {
                                if (student.St_National_id ==int.Parse(nId) && student.St_Password == password)
                                {
                                    userFound = true;
                                    DataAccess.UserIdToken = student.St_id;
                                    WelcomePage welcomePage = new WelcomePage();
                                    welcomePage.Show();
                                    this.Hide();
                                    //this.Close();
                                    break;
                                }  
                            }
                            if (!userFound)
                            {
                                MessageBox.Show("User Not Found, Please check username and password again", "Error");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please Inputs valid data First", "Error");
                        }
                        }
                        else
                        {
                            try
                            {
                                bool userFound = false;
                                string nId = textBox1.Text;
                                string password = textBox2.Text;
                                instructors = da.getAllInstructors();

                                foreach (Instructor instructor in instructors)
                                {
                                    if (instructor.Ins_National_id == int.Parse(nId) && instructor.Ins_Password == password)
                                    {
                                        userFound = true;
                                        DataAccess.UserIdToken = instructor.Ins_id;
                                        WelcomePage welcomePage = new WelcomePage();
                                        welcomePage.Show();
                                        this.Hide();
                                        //this.Close();
                                        break;
                                    }
                                }
                                if (!userFound)
                                {
                                    MessageBox.Show("User Not Found, Please check username and password again", "Error");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Please Inputs valid data First", "Error");
                            }
                        }
            */
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            checkBox1.BackColor= System.Drawing.Color.Transparent;


        }
        /*
* 
* 
* 
instructors = da.getAllInstructors();

                foreach (Instructor instructor in instructors)
                {
                    if (instructor.Ins_National_id == int.Parse(nId) && instructor.Ins_Password == password)
                    {
                        userFound = true;
                        DataAccess.UserIdToken = instructor.Ins_id;
                        WelcomePage welcomePage = new WelcomePage();
                        welcomePage.Show();
                        this.Hide();
                        //this.Close();
                        break;
                    }
                }
                if (!userFound)
                {
                    MessageBox.Show("User Not Found, Please check username and password again", "Error");
                }
* */



    }
}
