namespace SurveyForm1
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.button2DisplayResults = new System.Windows.Forms.Button();
            this.button3_Quit = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Next_Question = new System.Windows.Forms.Button();
            this.ControlFamilyTexBox = new System.Windows.Forms.TextBox();
            this.ControlFamilyLabel = new System.Windows.Forms.Label();
            this.ControlNameLabel = new System.Windows.Forms.Label();
            this.ControlNameTexBox = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentQuestionTextBox = new System.Windows.Forms.TextBox();
            this.TotalQuestionsTextBox = new System.Windows.Forms.TextBox();
            this.MostCriticalButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentFileTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonYes);
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(635, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(297, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Yes/No";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(20, 57);
            this.radioButtonYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(67, 26);
            this.radioButtonYes.TabIndex = 1;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(20, 31);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(59, 26);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(24, 165);
            this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(567, 186);
            this.QuestionTextBox.TabIndex = 1;
            // 
            // button2DisplayResults
            // 
            this.button2DisplayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2DisplayResults.Location = new System.Drawing.Point(24, 447);
            this.button2DisplayResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2DisplayResults.Name = "button2DisplayResults";
            this.button2DisplayResults.Size = new System.Drawing.Size(185, 33);
            this.button2DisplayResults.TabIndex = 3;
            this.button2DisplayResults.Text = "Display Results";
            this.button2DisplayResults.UseVisualStyleBackColor = true;
            this.button2DisplayResults.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_Quit
            // 
            this.button3_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Quit.Location = new System.Drawing.Point(793, 447);
            this.button3_Quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3_Quit.Name = "button3_Quit";
            this.button3_Quit.Size = new System.Drawing.Size(153, 34);
            this.button3_Quit.TabIndex = 4;
            this.button3_Quit.Text = "Exit Application";
            this.button3_Quit.UseVisualStyleBackColor = true;
            this.button3_Quit.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(20, 124);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(65, 17);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.Click += new System.EventHandler(this.label1_Question_Click);
            // 
            // Next_Question
            // 
            this.Next_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Question.Location = new System.Drawing.Point(793, 332);
            this.Next_Question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next_Question.Name = "Next_Question";
            this.Next_Question.Size = new System.Drawing.Size(153, 39);
            this.Next_Question.TabIndex = 0;
            this.Next_Question.Text = "Next Question";
            this.Next_Question.UseVisualStyleBackColor = true;
            this.Next_Question.Click += new System.EventHandler(this.Next_Question_Click);
            // 
            // ControlFamilyTexBox
            // 
            this.ControlFamilyTexBox.BackColor = System.Drawing.SystemColors.Control;
            this.ControlFamilyTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlFamilyTexBox.Location = new System.Drawing.Point(173, 21);
            this.ControlFamilyTexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ControlFamilyTexBox.Name = "ControlFamilyTexBox";
            this.ControlFamilyTexBox.Size = new System.Drawing.Size(369, 23);
            this.ControlFamilyTexBox.TabIndex = 7;
            // 
            // ControlFamilyLabel
            // 
            this.ControlFamilyLabel.AutoSize = true;
            this.ControlFamilyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlFamilyLabel.Location = new System.Drawing.Point(20, 21);
            this.ControlFamilyLabel.Name = "ControlFamilyLabel";
            this.ControlFamilyLabel.Size = new System.Drawing.Size(97, 17);
            this.ControlFamilyLabel.TabIndex = 8;
            this.ControlFamilyLabel.Text = "Control Family";
            // 
            // ControlNameLabel
            // 
            this.ControlNameLabel.AutoSize = true;
            this.ControlNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlNameLabel.Location = new System.Drawing.Point(20, 79);
            this.ControlNameLabel.Name = "ControlNameLabel";
            this.ControlNameLabel.Size = new System.Drawing.Size(94, 17);
            this.ControlNameLabel.TabIndex = 9;
            this.ControlNameLabel.Text = "Control Name";
            // 
            // ControlNameTexBox
            // 
            this.ControlNameTexBox.BackColor = System.Drawing.SystemColors.Control;
            this.ControlNameTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlNameTexBox.Location = new System.Drawing.Point(173, 71);
            this.ControlNameTexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ControlNameTexBox.Name = "ControlNameTexBox";
            this.ControlNameTexBox.Size = new System.Drawing.Size(369, 23);
            this.ControlNameTexBox.TabIndex = 10;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.Location = new System.Drawing.Point(635, 332);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(133, 39);
            this.PreviousButton.TabIndex = 11;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Questions";
            // 
            // CurrentQuestionTextBox
            // 
            this.CurrentQuestionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.CurrentQuestionTextBox.Location = new System.Drawing.Point(831, 25);
            this.CurrentQuestionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentQuestionTextBox.Name = "CurrentQuestionTextBox";
            this.CurrentQuestionTextBox.Size = new System.Drawing.Size(100, 22);
            this.CurrentQuestionTextBox.TabIndex = 14;
            // 
            // TotalQuestionsTextBox
            // 
            this.TotalQuestionsTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TotalQuestionsTextBox.Location = new System.Drawing.Point(831, 73);
            this.TotalQuestionsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalQuestionsTextBox.Name = "TotalQuestionsTextBox";
            this.TotalQuestionsTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalQuestionsTextBox.TabIndex = 15;
            // 
            // MostCriticalButton
            // 
            this.MostCriticalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostCriticalButton.Location = new System.Drawing.Point(247, 447);
            this.MostCriticalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MostCriticalButton.Name = "MostCriticalButton";
            this.MostCriticalButton.Size = new System.Drawing.Size(267, 33);
            this.MostCriticalButton.TabIndex = 16;
            this.MostCriticalButton.Text = "Display Most Critical Findings";
            this.MostCriticalButton.UseVisualStyleBackColor = true;
            this.MostCriticalButton.Click += new System.EventHandler(this.MostCriticalButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(557, 447);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(132, 33);
            this.CloseFormButton.TabIndex = 17;
            this.CloseFormButton.Text = "Close Form";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current SSDLC Audit File:";
            // 
            // CurrentFileTextBox
            // 
            this.CurrentFileTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.CurrentFileTextBox.Location = new System.Drawing.Point(219, 540);
            this.CurrentFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentFileTextBox.Name = "CurrentFileTextBox";
            this.CurrentFileTextBox.Size = new System.Drawing.Size(131, 22);
            this.CurrentFileTextBox.TabIndex = 19;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 625);
            this.Controls.Add(this.CurrentFileTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.MostCriticalButton);
            this.Controls.Add(this.TotalQuestionsTextBox);
            this.Controls.Add(this.CurrentQuestionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.ControlNameTexBox);
            this.Controls.Add(this.ControlNameLabel);
            this.Controls.Add(this.ControlFamilyLabel);
            this.Controls.Add(this.ControlFamilyTexBox);
            this.Controls.Add(this.Next_Question);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.button3_Quit);
            this.Controls.Add(this.button2DisplayResults);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionsForm";
            this.Text = "SurveyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button button2DisplayResults;
        private System.Windows.Forms.Button button3_Quit;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Button Next_Question;
        private System.Windows.Forms.TextBox ControlFamilyTexBox;
        private System.Windows.Forms.Label ControlFamilyLabel;
        private System.Windows.Forms.Label ControlNameLabel;
        private System.Windows.Forms.TextBox ControlNameTexBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentQuestionTextBox;
        private System.Windows.Forms.TextBox TotalQuestionsTextBox;
        private System.Windows.Forms.Button MostCriticalButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentFileTextBox;
    }
}

