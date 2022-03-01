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
    public partial class ExamPage : Form
    {
        // Global Atrributes
        int QuestionNumber = 0;
        int totalQuestions = 10;
        List<Exam> listExams;
        int c_id;
        DataAccess da;
        static string st_answer;
        
        public ExamPage(int id)
        {
            c_id = id;     
            InitializeComponent();

        }
        
        private void ExamPage_Load(object sender, EventArgs e)
        {
            
            ShowQuetions();
            if (listExams.Count == 0)
            {
                MessageBox.Show("not Available");
                this.Close();
            }
            else
            {
                AskQuetions(QuestionNumber);
        }

    }
        // ======================================global list to carry Answers===========================
        
        Dictionary<string, string[]> exam = new Dictionary<string, string[]>();
     
        public void ShowQuetions()
        {
            da = new DataAccess();
            //Getting Quetions and it's choices from database
           listExams = da.GetExamQuestionsAndChoices(c_id);
  
            //=========================================  define dictionary which connect between Qustions & choices==============================
            for (int i = 0; i < listExams.Count; i++)
            {
                exam.Add(listExams[i].Q_desc, listExams[i].SplitChoices());
            }
            

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // this function use to display choices , increasing length by one because there are comma(,) in the end of input
        private void DisplayChoices(string[] choices)
        {
            if (choices.Length == 5)
            {
                this.Text = "Please, Choose the right answer (multiple-choice question)";
                Choice1.Text = choices[0];
                Choice2.Text = choices[1];
                Choice3.Text = choices[2];
                Choice3.Show();
                Choice4.Text = choices[3];
                Choice4.Show();
            }
            else if (choices.Length == 3)
            {
                this.Text = "Please, Choose the right answer (True & False)";
                Choice1.Text = choices[0];
                Choice2.Text = choices[1];
                Choice3.Hide();
                Choice4.Hide();

            }
            else
            {
                Console.WriteLine("Invalid choices");
            }


        }


        // this function use to display Quesrions with its choices
        private void AskQuetions(int Qnum)
        {
            lbQ.Text = exam.Keys.ElementAt(Qnum);
            DisplayChoices(exam.Values.ElementAt(Qnum));
        }

        // this function to know which choice Student select it
        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            RadioButton myChoice = (RadioButton) sender;
            
            st_answer = myChoice.Text;
            
        }


        // this function do to the next Question

        private void next_Click(object sender, EventArgs e)
        {
            if (st_answer != null)
            {
                da.InsertStudentAnswer(st_answer, listExams[QuestionNumber].Q_id, LoginPage.student_id, listExams[QuestionNumber].Exam_id);
                QuestionNumber++;
                if (QuestionNumber < totalQuestions)
                {
                    AskQuetions(QuestionNumber);
                    ClearRadio();
                }
                else
                {
                    lbQ.Text = "Exam finished,best wishes ";
                    Choice1.Hide();
                    Choice2.Hide();
                    Choice3.Hide();
                    Choice4.Hide();
                    next.Hide();
                    da.GetExamGrade(LoginPage.student_id,c_id);
                    btnFinish.Show();

                }
            }
            else {
                MessageBox.Show("Please choose an answer!", "Warning!");
            }
            
            

        }

     

        private void ClearRadio() {
            Choice1.Checked = false;
            Choice2.Checked = false;
            Choice3.Checked = false;
            Choice4.Checked = false;
            st_answer = null;
        }

        private void ExamPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
