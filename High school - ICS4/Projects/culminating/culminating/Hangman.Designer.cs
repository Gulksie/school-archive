namespace culminating
{
    partial class Hangman
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessedChars = new System.Windows.Forms.Label();
            this.lblGuessedCharsTitle = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblHighScoreTitle = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(1111, 258);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(128, 47);
            this.txtGuess.TabIndex = 1;
            // 
            // lblGuessedChars
            // 
            this.lblGuessedChars.BackColor = System.Drawing.SystemColors.Control;
            this.lblGuessedChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuessedChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessedChars.Location = new System.Drawing.Point(752, 476);
            this.lblGuessedChars.Name = "lblGuessedChars";
            this.lblGuessedChars.Size = new System.Drawing.Size(500, 439);
            this.lblGuessedChars.TabIndex = 2;
            // 
            // lblGuessedCharsTitle
            // 
            this.lblGuessedCharsTitle.AutoSize = true;
            this.lblGuessedCharsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessedCharsTitle.Location = new System.Drawing.Point(748, 403);
            this.lblGuessedCharsTitle.Name = "lblGuessedCharsTitle";
            this.lblGuessedCharsTitle.Size = new System.Drawing.Size(491, 73);
            this.lblGuessedCharsTitle.TabIndex = 3;
            this.lblGuessedCharsTitle.Text = "Guessed Chars";
            // 
            // btnGuess
            // 
            this.btnGuess.AutoSize = true;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(1111, 311);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(128, 49);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(12, 866);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(91, 49);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblHighScoreTitle
            // 
            this.lblHighScoreTitle.AutoSize = true;
            this.lblHighScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreTitle.Location = new System.Drawing.Point(401, 415);
            this.lblHighScoreTitle.Name = "lblHighScoreTitle";
            this.lblHighScoreTitle.Size = new System.Drawing.Size(295, 61);
            this.lblHighScoreTitle.TabIndex = 6;
            this.lblHighScoreTitle.Text = "High score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(403, 476);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(49, 54);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = "0";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 924);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessedCharsTitle);
            this.Controls.Add(this.lblGuessedChars);
            this.Controls.Add(this.txtGuess);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuessedChars;
        private System.Windows.Forms.Label lblGuessedCharsTitle;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblHighScoreTitle;
        private System.Windows.Forms.Label lblHighScore;





    }
}

