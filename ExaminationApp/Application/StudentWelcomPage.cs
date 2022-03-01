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
    public partial class StudentWelcomPage : Form
    {
        Student student;
        DataAccess da = new DataAccess();
        List<StudentGrades> studentGrades = new List<StudentGrades>();
      
        public StudentWelcomPage()
        {
            InitializeComponent();
        }

        private void StudentWelcomPage_Load(object sender, EventArgs e)
        {
            student = da.getStudent();
            int id = student.St_id;
            header_stname_btn.Text = $"Welcome { student.StF_Name } {student.StL_Name}";
            studentGrades = da.getStudentGrades(id);
            addCoursesToPanel();
        }

        int flag = 0;
        private void grade_btn_Click(object sender, EventArgs e)
        {   
            if (flag == 0) {     
                cours_grade_Panel.Visible = true;
                flag = 1;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
                cours_grade_Panel.Visible = false;
                flag = 0;   
            }
        }

        private void course_btn_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                course_Panel.Visible = true;
                flag = 1;
            }
            else
            {
                course_Panel.Visible = false;
                flag = 0;
            }

        }

        private void course_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addCoursesToPanel() {
            for (int i = 0; i < studentGrades.Count; i++)
            {
                //1524587
                if (studentGrades[i].Crs_grade != 0) {
                    Button b = new Button();
                    b.Name = "showGrade";
                    b.Text = studentGrades[i].Crs_Name;
                    Console.WriteLine(studentGrades[i].Crs_Name);
                    b.BackColor = Color.LightGray;
                    cours_grade_Panel.Controls.Add(b);
                    b.Size = new System.Drawing.Size(216, 32);
                    b.Click += new EventHandler(showGrade_Click);

                }
                else
                {
                    Console.WriteLine(studentGrades[i].Crs_grade);
                    Button b = new Button();
                    b.Name = "open_Exam";              
                    b.Text = studentGrades[i].Crs_Name+"-"+ (studentGrades[i].Crs_id+100);
                    b.BackColor = Color.LightGray;
                    course_Panel.Controls.Add(b);
                    b.Size = new System.Drawing.Size(216, 32);
                    b.Click += new EventHandler(open_Exam_Click);
                   
                }
            }


        }

        private void open_Exam_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
<<<<<<< HEAD:ExaminationApp/StudentWelcomPage.cs
            int id = int.Parse(s.Text.Substring(s.Text.IndexOf('-') + 1))-100; 
            
=======
            int id = int.Parse(s.Text.Substring(s.Text.IndexOf('-') + 1))-100;
>>>>>>> 367f9845335f8c3ec4ddc10bcdc03a48058c6049:ExaminationApp/Application/StudentWelcomPage.cs
            new ExamPage(id).Visible = true;
        }
        private void showGrade_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;        
            for (int i = 0; i < studentGrades.Count; i++)
            {
                if (s.Text == studentGrades[i].Crs_Name)
                {
                    crsNameLabel.Text = studentGrades[i].Crs_Name;
                    gradeLabel.Text = studentGrades[i].Crs_grade.ToString();
                    tableLayoutPanel1.Visible = true;
               
                }
            }
        }

<<<<<<< HEAD:ExaminationApp/StudentWelcomPage.cs
        private void StudentWelcomPage_FormClosing(object sender, FormClosingEventArgs e)
        {
          Application.Exit();
=======
        private void StudentWelcomPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
>>>>>>> 367f9845335f8c3ec4ddc10bcdc03a48058c6049:ExaminationApp/Application/StudentWelcomPage.cs
        }
    }
}