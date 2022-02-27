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
        int QuestionNumber = 1;
        int totalQuestions = 10;



       

        List<Exam> listExams;
        int c_id; 
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
        //List<string[]> answers = new List<string[]>();
        Dictionary<string, string[]> exam = new Dictionary<string, string[]>();
        //List<String> Questions = new List<string>();

        //========================================function to split choices =============================
        //public string[] SplitChoices(string choices)
        //{
        //    string[] answer = choices.Split(',');
        //    return answer;

        //}
        public void ShowQuetions()
        {
            DataAccess da = new DataAccess();
            //Getting Quetions and it's choices from database
           listExams = da.GetExamQuestionsAndChoices(c_id);
            ////==============================perpare list of Quetions=================================
            //Questions.Add("Q1:Which of the following is the root of the hierarchy of all .NET types ?");
            //Questions.Add("Q2:Which of the following is the root of the hierarchy of all .NET types ?");
            //Questions.Add("Q3:Which of the following is the root of the hierarchy of all .NET types ?");
            //Questions.Add("Q4:Which of the following is the root of the hierarchy of all .NET types ?");
            //Questions.Add("Q5:Which of the following is the root of the hierarchy of all .NET types ?");
            //==============================perpare list of Answers=================================


            //string Answer1 = "False1,True,";
            //string Answer2 = "Depends on DBA2,Depends on number of Columns,Only 1,Only 2,";
            //string Answer3 = "False3,True,";
            //string Answer4 = "Depends on DBA4,Depends on number of Columns,Only 1,Only 2,";
            //string Answer5 = "False5,True,";

            //// i will call function 
            //answers.Add(SplitChoices(Answer1));
            //answers.Add(SplitChoices(Answer2));
            //answers.Add(SplitChoices(Answer3));
            //answers.Add(SplitChoices(Answer4));
            //answers.Add(SplitChoices(Answer5));

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
                Choice1.Text = choices[0];
                Choice2.Text = choices[1];
                Choice3.Text = choices[2];
                Choice3.Show();
                Choice4.Text = choices[3];
                Choice4.Show();
            }
            else if (choices.Length == 3)
            {
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
            switch (Qnum)
            {
                case 1:
                    lbQ.Text = exam.Keys.ElementAt(0);
                    DisplayChoices(exam.Values.ElementAt(0));
                    break;
                case 2:
                    lbQ.Text = exam.Keys.ElementAt(1);
                    DisplayChoices(exam.Values.ElementAt(1));
                    break;
                case 3:
                    lbQ.Text = exam.Keys.ElementAt(2);
                    DisplayChoices(exam.Values.ElementAt(2));
                    break;

                case 4:
                    lbQ.Text = exam.Keys.ElementAt(3);
                    DisplayChoices(exam.Values.ElementAt(3));
                    break;
                case 5:
                    lbQ.Text = exam.Keys.ElementAt(4);
                    DisplayChoices(exam.Values.ElementAt(4));
                    break;
                case 6:
                    lbQ.Text = exam.Keys.ElementAt(5);
                    DisplayChoices(exam.Values.ElementAt(5));
                    break;
                case 7:
                    lbQ.Text = exam.Keys.ElementAt(6);
                    DisplayChoices(exam.Values.ElementAt(6));
                    break;
                case 8:
                    lbQ.Text = exam.Keys.ElementAt(7);
                    DisplayChoices(exam.Values.ElementAt(7));
                    break;

                case 9:
                    lbQ.Text = exam.Keys.ElementAt(8);
                    DisplayChoices(exam.Values.ElementAt(8));
                    break;
                case 10:
                    lbQ.Text = exam.Keys.ElementAt(9);
                    DisplayChoices(exam.Values.ElementAt(9));
                    break;
            }
        }

        // this function to know which choice Student select it
        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            RadioButton myChoice = (RadioButton) sender;
            this.Text = myChoice.Text;
        }


        // this function do to the next Question

        private void next_Click(object sender, EventArgs e)
        {
            if (QuestionNumber < totalQuestions)
            {
                QuestionNumber++;
                AskQuetions(QuestionNumber);
            }
            else
            {
                lbQ.Text = "Exam finished,best wishes ";
                Choice1.Hide();
                Choice2.Hide();
                Choice3.Hide();
                Choice4.Hide();
                next.Hide();
            }
           

        }

        private void Choice1_Paint(object sender, PaintEventArgs e)
        {
            Choice1.Checked = false;
            Choice2.Checked = false;
            Choice3.Checked = false;
            Choice4.Checked = false;
        }

    }
}
