
namespace QuizApp.Windows
{
    partial class ScoreForm
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
            this.lstScores = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.BackColor = System.Drawing.Color.White;
            this.lstScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstScores.HideSelection = false;
            this.lstScores.Location = new System.Drawing.Point(12, 12);
            this.lstScores.MultiSelect = false;
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(760, 537);
            this.lstScores.TabIndex = 2;
            this.lstScores.UseCompatibleStateImageBehavior = false;
            this.lstScores.View = System.Windows.Forms.View.List;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lstScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Table";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstScores;
    }
}