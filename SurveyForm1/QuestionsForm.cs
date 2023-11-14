using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SurveyForm1
{
    
    public partial class QuestionsForm : Form
    {
        //Read Control File Variables
        private const String filePathControlFile = "controlFile.txt";

        // Read Questions and Array Variables
        private const String filePathQuestions = "questions.txt";
        private const int MAXnumberOfQuestions = 100;
        private string[] controlFamily = new string[MAXnumberOfQuestions];
        private string[] controlName = new string[MAXnumberOfQuestions];
        private string[] questions = new string[MAXnumberOfQuestions];
         
        // Read Responses Varialbes and Response Array
        private String filePathResponses = "responses.txt";
        private string[] responses = new string[MAXnumberOfQuestions];

        // Question Processing Variables
        private int numberOfQuestions = 0;
        private int currentQuestion = 0;
        private const String NoResponse = "N";
        private const String YesResponse = "Y";

        public QuestionsForm()
        {
            InitializeComponent();
        }
        // On Form Load 
        private void Form1_Load(object sender, EventArgs e)
        {

            // Read Control file for responses file name
            try
            {
                using (var sq = new StreamReader(filePathControlFile))
                {
                    while (!sq.EndOfStream)
                    {
                        var readLine = sq.ReadLine();
                        if (readLine != null)
                        {
                            filePathResponses = readLine;
                            CurrentFileTextBox.Text = filePathResponses;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            // End of Read Control File


            InintializeCheckBoxes();

            // Read Questions File
            try
            {
                using (var sq = new StreamReader(filePathQuestions))
                {
                    var counter = 0;
                    while (!sq.EndOfStream)
                    { 
                        var readLine = sq.ReadLine();
                        if (readLine != null)
                        {
                            var line = readLine.Split('|');
                            controlFamily[counter] = (line[2]);
                            controlName[counter] = (line[3]);
                            questions[counter] = (line[4]);
                            numberOfQuestions = counter;
                            counter++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            // End of Read Questions File

            // READ SCORES TEXT FILE
            try
            {
                using (var sr = new StreamReader(filePathResponses))
                {
                    var counter = 0;
                    while (!sr.EndOfStream)
                    {
                        var readLine = sr.ReadLine();
                        if (readLine != null)
                        {
                            var line = readLine.Split('|');
                            responses[counter] = (line[1]);
                            counter++;
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            // End of Read Scores File
            
            
            // Display initial Question

                ControlFamilyTexBox.Clear();
                ControlFamilyTexBox.Text += string.Format(controlFamily[currentQuestion]);

                ControlNameTexBox.Clear();
                ControlNameTexBox.Text += string.Format(controlName[currentQuestion]);

                CurrentQuestionTextBox.Clear();
                CurrentQuestionTextBox.Text += currentQuestion + 1;

                TotalQuestionsTextBox.Clear();
                TotalQuestionsTextBox.Text += numberOfQuestions;


                QuestionTextBox.Clear();
                QuestionTextBox.Text += string.Format("Question {0}: {1}\r\n", currentQuestion + 1, 
                    questions[currentQuestion]);

                //QuestionTextBox.Text += string.Format("  \r\n");
                //QuestionTextBox.Text += string.Format("DEBUG \r\n");
                //QuestionTextBox.Text += string.Format("currentQuestion index: ");
                //QuestionTextBox.Text += currentQuestion.ToString();

                InintializeCheckBoxes();
                if (responses[currentQuestion] == YesResponse)
                {
                    radioButtonYes.Checked = true;
                }
                if (responses[currentQuestion] == NoResponse)
                {
                    radioButtonNo.Checked = true;
                }
            // End of Display 
        }
        // End of FORM LOAD


        // Radio Buttons
        private void radioButton1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
        }
        // End or Radio Buttons


        //Display Results Button
        private void button2_Click(object sender, EventArgs e)
        {

            {
                CountCheckBoxes();
            }
            /// Write scores file
            {
                WriteResponseFile();
            }
            {
             // Open ressults form
                ResultsForm RF = new ResultsForm();
                RF.ShowDialog();
            }
        }
        // END of Display Results Button


        // Display most crical findings
        private void MostCriticalButton_Click(object sender, EventArgs e)
        {
            {
                CountCheckBoxes();
            }
            /// Write scores file
            {
                WriteResponseFile();
            }
            {
                // Open Most Critcal Findings form
                Most_Critical_Findings CF = new Most_Critical_Findings();
                CF.ShowDialog();
            }
        }
        // END of Display Most Critical Findings Button


        // QUIT BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            {
                CountCheckBoxes();
            }
            {
                WriteResponseFile();
            }
            {
                Application.Exit();
            }
        }
        // End of Quit Button
  
        
        // Next Question Button
        private void Next_Question_Click(object sender, EventArgs e)
        {
            CountCheckBoxes();

            currentQuestion++;

            InintializeCheckBoxes();
            
                if (currentQuestion < numberOfQuestions)
                 {
                    ControlFamilyTexBox.Clear();
                    ControlFamilyTexBox.Text += string.Format(controlFamily[currentQuestion]);

                    ControlNameTexBox.Clear();
                    ControlNameTexBox.Text += string.Format(controlName[currentQuestion]);

                    CurrentQuestionTextBox.Clear();
                    CurrentQuestionTextBox.Text += currentQuestion + 1;

                    TotalQuestionsTextBox.Clear();
                    TotalQuestionsTextBox.Text += numberOfQuestions;


                    QuestionTextBox.Clear();
                    QuestionTextBox.Text += string.Format("Question {0}: {1}\r\n", currentQuestion +1, questions[currentQuestion])
                    ;

                    //QuestionTextBox.Text += string.Format("  \r\n");
                    //QuestionTextBox.Text += string.Format("DEBUG \r\n");
                    //QuestionTextBox.Text += string.Format("currentQuestion index: ");
                    //QuestionTextBox.Text += currentQuestion.ToString();
                     
                }
                else
                {
                    QuestionTextBox.Clear();
                    QuestionTextBox.Text += string.Format("End of Questions");
                }

            if (responses[currentQuestion] == YesResponse)
            {
                radioButtonYes.Checked = true;
            }
            if (responses[currentQuestion] == NoResponse)
            {
                radioButtonNo.Checked = true;
            }
        }
        // END of next Question Button


        // Previous Button Click
        private void PreviousButton_Click(object sender, EventArgs e)
        {

            CountCheckBoxes();

            currentQuestion--;

            InintializeCheckBoxes();

            if (currentQuestion >= 0)
            {
                ControlFamilyTexBox.Clear();
                ControlFamilyTexBox.Text += string.Format(controlFamily[currentQuestion]);

                ControlNameTexBox.Clear();
                ControlNameTexBox.Text += string.Format(controlName[currentQuestion]);

                CurrentQuestionTextBox.Clear();
                CurrentQuestionTextBox.Text += currentQuestion + 1;

                TotalQuestionsTextBox.Clear();
                TotalQuestionsTextBox.Text += numberOfQuestions;


                QuestionTextBox.Clear();
                QuestionTextBox.Text += string.Format("Question {0}: {1}\r\n", currentQuestion + 1, questions[currentQuestion])
                ;

               // QuestionTextBox.Text += string.Format("  \r\n");
               // QuestionTextBox.Text += string.Format("DEBUG \r\n");
               // QuestionTextBox.Text += string.Format("currentQuestion index: ");
               // QuestionTextBox.Text += currentQuestion.ToString();

                InintializeCheckBoxes();
                if (responses[currentQuestion] == YesResponse)
                {
                    radioButtonYes.Checked = true;
                }
                if (responses[currentQuestion] == NoResponse)
                {
                    radioButtonNo.Checked = true;
                }
            }
            else
            {
                QuestionTextBox.Clear();
                QuestionTextBox.Text += string.Format("Start of Questions");
            }
        }
        // END Previous Button Click

        // Common Methods
        private void InintializeCheckBoxes()
        {
            radioButtonNo.Checked = false;
            radioButtonYes.Checked = false;
        }

        private void CountCheckBoxes()
        {
            if (radioButtonNo.Checked)
            {
                responses[currentQuestion] = NoResponse;
            }
            if (radioButtonYes.Checked)
            {
                responses[currentQuestion] = YesResponse;
            }
                        
        }
        private void WriteResponseFile()
        {
            try
            {
                using (var sw = new StreamWriter(filePathResponses))
                {
                    for (var i = 0; i < numberOfQuestions; i++)
                    {
                        sw.WriteLine((i + 1) + "|" + responses[i]);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

           private void label1_Question_Click(object sender, EventArgs e)
        {

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
