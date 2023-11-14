using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyForm1
{
    public partial class Menu : Form
    {
        // Menu File Variables
        private const String filePathControlFile = "controlFile.txt";
        private String filePathResponses = "responses.txt";
        public Menu()
        {
            InitializeComponent();
        }

        // New Audit
        private void button1_Click(object sender, EventArgs e)
        {
            filePathResponses = NewFileNameTextBox.Text;
            WriteControlFile();
            WriteResponseFile();
            // Open questions form
            QuestionsForm QF = new QuestionsForm();
            QF.ShowDialog();
        }

        // Previious Audit
        private void PreviousAuditButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
                //Delete NewFileNameTextBox.Text = openFileDialog1.FileName;
                // System.IO.Path.GetFileNameWithoutExtension trims to just the file name, remove for path
                filePathResponses = System.IO.Path.GetFileName(openFileDialog1.FileName);
                WriteControlFile();
            
            // Open questions form
            QuestionsForm QF = new QuestionsForm();
            QF.ShowDialog();
        }
        // End Previous Audit


        // Quit Audit Session
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // End Quit Audit Session

        
        private void WriteControlFile()
        {
            try
            {
                using (var sw = new StreamWriter(filePathControlFile))
                {
                    {
                        sw.WriteLine(filePathResponses);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteResponseFile()
        {
            try
            {
                using (var sw = new StreamWriter(filePathResponses))
                {
                    for (var i = 0; i < 100; i++)
                    {
                        sw.WriteLine((i + 1) + "|" + " ");
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            NewFileNameTextBox.Text = " ";
        }

        private void ReadMeButton_Click(object sender, EventArgs e)
        {
            // Open ReadMeForm
            ReadMeForm RMF = new ReadMeForm();
            RMF.ShowDialog();
        }
    }
}
