﻿using System;
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
        int totalQuextions = 5;
        public ExamPage()
        {
            InitializeComponent();
        }

        private void ExamPage_Load(object sender, EventArgs e)
        {
            ShowQuetions();
            AskQuetions(QuestionNumber);

             
        }
        // ======================================global list to carry Answers===========================
        List<string[]> answers = new List<string[]>();
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


            string Answer1 = "False1,True,";
            string Answer2 = "Depends on DBA2,Depends on number of Columns,Only 1,Only 2,";
            string Answer3 = "False3,True,";
            string Answer4 = "Depends on DBA4,Depends on number of Columns,Only 1,Only 2,";
            string Answer5 = "False5,True,";

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
            }
        }

        // this function to know which choice Student select it
        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            RadioButton myChoice = (RadioButton) sender;
            // MessageBox.Show(myChoice.Text);
        }


        // this function do to the next Question

        private void next_Click(object sender, EventArgs e)
        {
            if (QuestionNumber <= totalQuextions)
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
    }
}
