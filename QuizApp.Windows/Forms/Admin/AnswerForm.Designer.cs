
namespace QuizApp.Windows.Forms
{
    partial class AnswerForm
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSaveAnswer = new System.Windows.Forms.Button();
            this.checkBoxCorrectAnswer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 12);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(472, 84);
            this.txtAnswer.TabIndex = 0;
            // 
            // btnSaveAnswer
            // 
            this.btnSaveAnswer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAnswer.Location = new System.Drawing.Point(12, 140);
            this.btnSaveAnswer.Name = "btnSaveAnswer";
            this.btnSaveAnswer.Size = new System.Drawing.Size(472, 41);
            this.btnSaveAnswer.TabIndex = 1;
            this.btnSaveAnswer.Text = "Save";
            this.btnSaveAnswer.UseVisualStyleBackColor = false;
            this.btnSaveAnswer.Click += new System.EventHandler(this.BtnSaveAnswer_Click);
            // 
            // checkBoxCorrect
            // 
            this.checkBoxCorrectAnswer.AutoSize = true;
            this.checkBoxCorrectAnswer.Location = new System.Drawing.Point(12, 102);
            this.checkBoxCorrectAnswer.Name = "checkBoxCorrect";
            this.checkBoxCorrectAnswer.Size = new System.Drawing.Size(177, 32);
            this.checkBoxCorrectAnswer.TabIndex = 2;
            this.checkBoxCorrectAnswer.Text = "Correct Answer";
            this.checkBoxCorrectAnswer.UseVisualStyleBackColor = true;
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(496, 193);
            this.Controls.Add(this.checkBoxCorrectAnswer);
            this.Controls.Add(this.btnSaveAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answer Form";
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSaveAnswer;
        private System.Windows.Forms.CheckBox checkBoxCorrectAnswer;
    }
}