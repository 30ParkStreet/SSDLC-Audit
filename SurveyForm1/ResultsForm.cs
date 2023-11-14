using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyForm1
{
    public partial class ResultsForm : Form
    {

        // Read Questions and Array Variables
        private const String filePathQuestions = "questions.txt";
        private const int MAXnumberOfQuestions = 100;
        private int[] maturityLevel = new int[MAXnumberOfQuestions];


        // Read Responses Variables and Response Array
        private const String filePathControlFile = "controlFile.txt";
        private String filePathResponses = "responses.txt";
        private string[] responses = new string[MAXnumberOfQuestions];

        // Question Processing Variables
        private int numberOfQuestions = 0;
        private int currentQuestion = 0;
        private const String NoResponse = "N";
        private const String YesResponse = "Y";

        //Response Processing Variables
        private String maturityLevelString;
        // Have to have 4 in arry because using the maturity level as the index 1 to 3, so 0 is unused
        private int[] responseAnswerCount = new int[4];
        private int[] levelQuestionCount = new int[4];

        private int percentOne = 0;
        private int percentTwo = 0;
        private int percentThr = 0;

        public ResultsForm()
        {
            InitializeComponent();
        }

        // Form Load
        private void ResultsForm_Load(object sender, EventArgs e)
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


            // READ QUESTIONS FILE
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
                            maturityLevelString = (line[1]);

                            try
                            {
                                maturityLevel[counter] = int.Parse(maturityLevelString);
                                numberOfQuestions = counter;
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
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

            // Display Results 
            {
                LevelOneResponseTextBox.Clear();

                for (var i = 0; i < numberOfQuestions; i++)
                {

                    // maturityLevel 1-3 is used as an index
                    levelQuestionCount[maturityLevel[i]]++;
 
                    if (responses[i] == YesResponse)
                    {
                        responseAnswerCount[maturityLevel[i]]++;
                    }
                }
                
                // Level Starts at 1, not zero 
                LevelOneResponseTextBox.Text += string.Format("{0}", responseAnswerCount[1]);
                Level2ResponseTextBox.Text += string.Format("{0}", responseAnswerCount[2]);
                Level3ResponseTextBox.Text += string.Format("{0}", responseAnswerCount[3]);

                Level1QuestionsCountTextBox.Text += string.Format("{0}", levelQuestionCount[1]);
                Level2QuestionsCountTextBox.Text += string.Format("{0}", levelQuestionCount[2]);
                Level3QuestionsCountTextBox.Text += string.Format("{0}", levelQuestionCount[3]);

                percentOne = ( (responseAnswerCount[1] * 100) / levelQuestionCount[1]) ;
                Level1PercentTextBox.Text += string.Format("{0} Percent", percentOne);
                percentTwo = ((responseAnswerCount[2] * 100) / levelQuestionCount[2]);
                Level2PercentTextBox.Text += string.Format("{0} Percent", percentTwo);
                percentThr = ((responseAnswerCount[2] * 100) / levelQuestionCount[2]);
                Level3PercentTextBox.Text += string.Format("{0} Percent", percentThr);
            }
        }
        // End Form Load


        private void ResultsQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            // Open questions form
            QuestionsForm QF = new QuestionsForm();
            QF.ShowDialog();
        }

        private void CriticalFindingsButton_Click(object sender, EventArgs e)
        {
            // Open Most Critcal Findings form
            Most_Critical_Findings CF = new Most_Critical_Findings();
            CF.ShowDialog();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
