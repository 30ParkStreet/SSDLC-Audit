using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SurveyForm1
{
    public partial class Most_Critical_Findings : Form
    {
        // Read Questions and Array Variables
        private const String filePathQuestions = "questions.txt";
        private const int MAXnumberOfQuestions = 100;
        private int[] maturityLevel = new int[MAXnumberOfQuestions];
        private string[] criticalFindingsLevel = new string[MAXnumberOfQuestions];
        private string[] criticalFindingsScore = new string[MAXnumberOfQuestions];
        private string[] criticalFindingsQuestion = new string[MAXnumberOfQuestions];

        // Read Responses Variables and Response Array
        private const String filePathControlFile = "controlFile.txt";
        private String filePathResponses = "responses.txt";
        private string[] responses = new string[MAXnumberOfQuestions];
        private string[] criticalArray = new string[MAXnumberOfQuestions];

        // Question Processing Variables
        private int numberOfQuestions = 0;
        private int currentQuestion = 0;
        private const String NoResponse = "N";
        private const String YesResponse = "Y";

        //Response Processing Variables
        private String maturityLevelString;
        List<string> criticalList = new List<string>();

        //Print Variables
        Bitmap screenImage;

        public Most_Critical_Findings()
        {
            InitializeComponent();
        }
        // Form Load
        private void Most_Critical_Findings_Load_1(object sender, EventArgs e)
       
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
                            CurrentSSDLCAuditFileTextBox.Text += string.Format("{0}", filePathResponses);
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
                            criticalFindingsScore[counter] = (line[0]);
                            criticalFindingsLevel[counter] = (line[1]);
                            criticalFindingsQuestion[counter] = (line[4]);
                            
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
            // End of read Questions


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
                            if (responses[counter] != YesResponse)
                                criticalList.Add("Maturity Level: "
                                    + criticalFindingsLevel[counter]
                                    + "  Critical Priority: "
                                    + criticalFindingsScore[counter] 
                                    + "  Question: "
                                    + criticalFindingsQuestion[counter]);
                        }
                            counter++;
                     }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            // END of READ SCORES FILE 


            //Sort the critical list 
            criticalList.Sort();  // Sort the list in an ascending order

            // Display Results 
            textBox1.Text += string.Format("{0}", criticalList[0]);
            textBox2.Text += string.Format("{0}", criticalList[1]);
            textBox3.Text += string.Format("{0}", criticalList[2]);
            textBox4.Text += string.Format("{0}", criticalList[3]);
            textBox5.Text += string.Format("{0}", criticalList[4]);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuestionsButton_Click(object sender, EventArgs e)
        {
            // Open questions form
            QuestionsForm QF = new QuestionsForm();
            QF.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Print Form
        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            
            screenImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(screenImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }
      
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(screenImage, 0, 0);
        }
    }
}
