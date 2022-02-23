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
        public ExamPage()
        {
            InitializeComponent();
        }

       
        // ======================================global list to carry Answers===========================
        List<string []> answers = new List<string []>();
        Dictionary<string, string[]> exam = new Dictionary<string, string[]>();
        List<String> Questions = new List<string>();

        //========================================function to split choices =============================
        public string[] SplitChoices(string choices)
        {
            string[] answer = choices.Split(',');
            return answer;

        }
        public void ShowQuetions()
        {
            //==============================perpare list of Quetions=================================
            Questions.Add("Q1:Which of the following is the root of the hierarchy of all .NET types ?");
            Questions.Add("Q2:Which of the following is the root of the hierarchy of all .NET types ?");
            Questions.Add("Q3:Which of the following is the root of the hierarchy of all .NET types ?");
            Questions.Add("Q4:Which of the following is the root of the hierarchy of all .NET types ?");
            Questions.Add("Q5:Which of the following is the root of the hierarchy of all .NET types ?");
            //==============================perpare list of Answers=================================

           
            string Answer1 = "Depends on DBA,Depends on number of Columns,Only 1,Only 2,";
            string Answer2 = "Depends on DBA,Depends on number of Columns,Only 1,Only 2,";
            string Answer3 = "Depends on DBA,Depends on number of Columns,Only 1,Only 2,";
            string Answer4 = "Depends on DBA,Depends on number of Columns,Only 1,Only 2,";
            string Answer5 = "Depends on DBA,Depends on number of Columns,Only 1,Only 2,";

            // i will call function 
            answers.Add(SplitChoices(Answer1));
            answers.Add(SplitChoices(Answer2));
            answers.Add(SplitChoices(Answer3));
            answers.Add(SplitChoices(Answer4));
            answers.Add(SplitChoices(Answer5));

            //=========================================  define dictionary which connect between Qustions & choices==============================
            for (int i = 0; i < Questions.Count; i++)
            {
                exam.Add(Questions[i], answers[i]);

            }


        }
        private void ExamPage_Load(object sender, EventArgs e)
        {
            ShowQuetions();
            AskQuetions(1);
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void AskQuetions(int Qnum)
        {
            switch (Qnum)
            {
                case 1:

                    //        lbQ.Text="hhhhhhhhhhh";

                    ////    lbQ.Text = Questions[1];
                    ////    btn1.Text = answers[1][1];
                    ////    btn2.Text = answers[1][2];
                    ////    btn3.Text = answers[1][3];
                    ////    btn4.Text = answers[1][4];
                    lbQ.Text = exam.Keys.ElementAt(0);
                    btn1.Text = exam.Values.ElementAt(0)[0];
                    btn2.Text = exam.Values.ElementAt(0)[1];
                    btn3.Text = exam.Values.ElementAt(0)[2];
                    btn4.Text = exam.Values.ElementAt(0)[3];

                    break;
            }

            
        }
    }
}
