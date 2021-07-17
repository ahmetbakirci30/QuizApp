
namespace QuizApp.Windows.Forms
{
    partial class QuizForm
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
            this.txtQuizTitle = new System.Windows.Forms.TextBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblQuizTitle = new System.Windows.Forms.Label();
            this.btnAddNewQuestion = new System.Windows.Forms.Button();
            this.lblQuestionsTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuizTitle
            // 
            this.txtQuizTitle.BackColor = System.Drawing.Color.White;
            this.txtQuizTitle.Location = new System.Drawing.Point(306, 121);
            this.txtQuizTitle.Name = "txtQuizTitle";
            this.txtQuizTitle.Size = new System.Drawing.Size(488, 29);
            this.txtQuizTitle.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFormTitle.Location = new System.Drawing.Point(443, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(99, 28);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Quiz Info";
            // 
            // lblQuizTitle
            // 
            this.lblQuizTitle.AutoSize = true;
            this.lblQuizTitle.Location = new System.Drawing.Point(186, 124);
            this.lblQuizTitle.Name = "lblQuizTitle";
            this.lblQuizTitle.Size = new System.Drawing.Size(90, 21);
            this.lblQuizTitle.TabIndex = 2;
            this.lblQuizTitle.Text = "Quiz Title :";
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.Location = new System.Drawing.Point(821, 231);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(149, 71);
            this.btnAddNewQuestion.TabIndex = 6;
            this.btnAddNewQuestion.Text = "Add Question";
            this.btnAddNewQuestion.UseVisualStyleBackColor = false;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.BtnAddNewQuestion_Click);
            // 
            // lblQuestionsTitle
            // 
            this.lblQuestionsTitle.AutoSize = true;
            this.lblQuestionsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblQuestionsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblQuestionsTitle.Location = new System.Drawing.Point(446, 194);
            this.lblQuestionsTitle.Name = "lblQuestionsTitle";
            this.lblQuestionsTitle.Size = new System.Drawing.Size(96, 25);
            this.lblQuestionsTitle.TabIndex = 8;
            this.lblQuestionsTitle.Text = "Questions";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(821, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 67);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Quiz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQuestions.FullRowSelect = true;
            this.lstQuestions.HideSelection = false;
            this.lstQuestions.Location = new System.Drawing.Point(164, 231);
            this.lstQuestions.MultiSelect = false;
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(651, 298);
            this.lstQuestions.TabIndex = 10;
            this.lstQuestions.UseCompatibleStateImageBehavior = false;
            this.lstQuestions.View = System.Windows.Forms.View.List;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(821, 308);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 71);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Question";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(821, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 71);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Question";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(982, 540);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQuestionsTitle);
            this.Controls.Add(this.btnAddNewQuestion);
            this.Controls.Add(this.lblQuizTitle);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.txtQuizTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Form";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuizTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblQuizTitle;
        private System.Windows.Forms.Button btnAddNewQuestion;
        private System.Windows.Forms.Label lblQuestionsTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstQuestions;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}