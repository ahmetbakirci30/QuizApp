
namespace QuizApp.Windows
{
    partial class AdministratorForm
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
            this.btnAddNewQuiz = new System.Windows.Forms.Button();
            this.lstQuizzes = new System.Windows.Forms.ListView();
            this.lblQuizzesTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnMemberLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewQuiz
            // 
            this.btnAddNewQuiz.BackColor = System.Drawing.Color.Blue;
            this.btnAddNewQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewQuiz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewQuiz.Location = new System.Drawing.Point(735, 23);
            this.btnAddNewQuiz.Name = "btnAddNewQuiz";
            this.btnAddNewQuiz.Size = new System.Drawing.Size(235, 40);
            this.btnAddNewQuiz.TabIndex = 1;
            this.btnAddNewQuiz.Text = "Add New Quiz";
            this.btnAddNewQuiz.UseVisualStyleBackColor = false;
            this.btnAddNewQuiz.Click += new System.EventHandler(this.BtnAddNewQuiz_Click);
            // 
            // lstQuizzes
            // 
            this.lstQuizzes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstQuizzes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQuizzes.FullRowSelect = true;
            this.lstQuizzes.HideSelection = false;
            this.lstQuizzes.Location = new System.Drawing.Point(12, 69);
            this.lstQuizzes.MultiSelect = false;
            this.lstQuizzes.Name = "lstQuizzes";
            this.lstQuizzes.Size = new System.Drawing.Size(958, 341);
            this.lstQuizzes.TabIndex = 2;
            this.lstQuizzes.UseCompatibleStateImageBehavior = false;
            this.lstQuizzes.View = System.Windows.Forms.View.List;
            // 
            // lblQuizzesTitle
            // 
            this.lblQuizzesTitle.AutoSize = true;
            this.lblQuizzesTitle.Location = new System.Drawing.Point(445, 33);
            this.lblQuizzesTitle.Name = "lblQuizzesTitle";
            this.lblQuizzesTitle.Size = new System.Drawing.Size(68, 21);
            this.lblQuizzesTitle.TabIndex = 0;
            this.lblQuizzesTitle.Text = "Quizzes";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(494, 416);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(235, 44);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Quiz";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(735, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 44);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Quiz";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.SteelBlue;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScore.Location = new System.Drawing.Point(253, 416);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(235, 44);
            this.btnScore.TabIndex = 4;
            this.btnScore.Text = "View Score Table";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // btnMemberLogin
            // 
            this.btnMemberLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMemberLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMemberLogin.Location = new System.Drawing.Point(12, 416);
            this.btnMemberLogin.Name = "btnMemberLogin";
            this.btnMemberLogin.Size = new System.Drawing.Size(235, 44);
            this.btnMemberLogin.TabIndex = 3;
            this.btnMemberLogin.Text = "Log In As Member";
            this.btnMemberLogin.UseVisualStyleBackColor = false;
            this.btnMemberLogin.Click += new System.EventHandler(this.BtnMemberLogin_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(982, 472);
            this.Controls.Add(this.btnMemberLogin);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblQuizzesTitle);
            this.Controls.Add(this.lstQuizzes);
            this.Controls.Add(this.btnAddNewQuiz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorForm_FormClosed);
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuiz;
        private System.Windows.Forms.ListView lstQuizzes;
        private System.Windows.Forms.Label lblQuizzesTitle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnMemberLogin;
    }
}