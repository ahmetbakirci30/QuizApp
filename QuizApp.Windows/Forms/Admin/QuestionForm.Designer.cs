
namespace QuizApp.Windows.Forms
{
    partial class QuestionForm
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lstAnswers = new System.Windows.Forms.ListView();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            this.btnEditAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFormTitle.Location = new System.Drawing.Point(430, 21);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(168, 28);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Question Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(854, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 83);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Question";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(185, 80);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(663, 89);
            this.txtQuestion.TabIndex = 2;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuestionText.Location = new System.Drawing.Point(25, 112);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(121, 21);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Question Text :";
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddAnswer.Location = new System.Drawing.Point(854, 223);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(165, 42);
            this.btnAddAnswer.TabIndex = 5;
            this.btnAddAnswer.Text = "Add Answer";
            this.btnAddAnswer.UseVisualStyleBackColor = false;
            this.btnAddAnswer.Click += new System.EventHandler(this.BtnAddAnswer_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNote.Location = new System.Drawing.Point(185, 192);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(382, 21);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Please add answers and choose the correct answer!";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOptions.Location = new System.Drawing.Point(78, 321);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(80, 21);
            this.lblOptions.TabIndex = 4;
            this.lblOptions.Text = "Answers :";
            // 
            // lstAnswers
            // 
            this.lstAnswers.HideSelection = false;
            this.lstAnswers.Location = new System.Drawing.Point(185, 223);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(663, 226);
            this.lstAnswers.TabIndex = 8;
            this.lstAnswers.UseCompatibleStateImageBehavior = false;
            this.lstAnswers.View = System.Windows.Forms.View.List;
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAnswer.Location = new System.Drawing.Point(854, 320);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(165, 40);
            this.btnDeleteAnswer.TabIndex = 7;
            this.btnDeleteAnswer.Text = "Delete Answer";
            this.btnDeleteAnswer.UseVisualStyleBackColor = false;
            this.btnDeleteAnswer.Click += new System.EventHandler(this.BtnDeleteAnswer_Click);
            // 
            // btnEditAnswer
            // 
            this.btnEditAnswer.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditAnswer.Location = new System.Drawing.Point(854, 271);
            this.btnEditAnswer.Name = "btnEditAnswer";
            this.btnEditAnswer.Size = new System.Drawing.Size(165, 40);
            this.btnEditAnswer.TabIndex = 6;
            this.btnEditAnswer.Text = "Edit Answer";
            this.btnEditAnswer.UseVisualStyleBackColor = false;
            this.btnEditAnswer.Click += new System.EventHandler(this.BtnEditAnswer_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1031, 461);
            this.Controls.Add(this.btnDeleteAnswer);
            this.Controls.Add(this.btnEditAnswer);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Details Form";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ListView lstAnswers;
        private System.Windows.Forms.Button btnDeleteAnswer;
        private System.Windows.Forms.Button btnEditAnswer;
    }
}