namespace QuizApp.Windows
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lstQuizzes = new System.Windows.Forms.ListView();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.ForeColor = System.Drawing.Color.Olive;
            this.lblFormTitle.Location = new System.Drawing.Point(248, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(374, 28);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Welcome To Ahmet\'s Quiz Application";
            // 
            // lstQuizzes
            // 
            this.lstQuizzes.BackColor = System.Drawing.Color.White;
            this.lstQuizzes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQuizzes.HideSelection = false;
            this.lstQuizzes.Location = new System.Drawing.Point(12, 89);
            this.lstQuizzes.MultiSelect = false;
            this.lstQuizzes.Name = "lstQuizzes";
            this.lstQuizzes.Size = new System.Drawing.Size(860, 417);
            this.lstQuizzes.TabIndex = 1;
            this.lstQuizzes.UseCompatibleStateImageBehavior = false;
            this.lstQuizzes.View = System.Windows.Forms.View.List;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(12, 512);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(860, 37);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.BtnStartQuiz_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNote.Location = new System.Drawing.Point(12, 65);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(529, 21);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Please select a quiz below and click the start quiz button to get started.";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lstQuizzes);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ListView lstQuizzes;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Label lblNote;
    }
}