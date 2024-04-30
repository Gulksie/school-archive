using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using NAudio;
using NAudio.Wave;

namespace culminating
{
    public partial class Hangman : Form
    {

        public enum difficulty
        {
            easy,
            medium,
            hard
        }


        PictureBox[] pictures; //the hangman images
        Label[] letters; //each letter is a different box
        difficulty diff;
        string[] words; //all of the words you can choose from
        string word; //the current word to guess
        string guessdChars; //the characters that have been guessed
        int guesses; //the amount of guesses that have been taken
        int charsToGuess; //how many characters are left to guess in the word
        int attempts; //the number of incorrect guesses
        int highScore;

        IWavePlayer backgroundMusicWP; //background music player
        AudioFileReader backgroudMusicFileReader; //background music file reader

        public Hangman(difficulty diff = difficulty.medium)
        {
            InitializeComponent();

            //load pictures and words
            pictures = generatePictures();

            words = loadWords();
            word = pickWord(words);
            guessdChars = "";

            //load high score, if it doesnt exist it will be -1
            highScore = loadHighScore();
            if (highScore > -1)
            {
                lblHighScoreTitle.Visible = true;
                lblHighScore.Visible = true;
                lblHighScore.Text = highScore.ToString();
            }
            else
            {
                lblHighScoreTitle.Visible = false;
                lblHighScore.Visible = false;
            }

            guesses = 0;

            //set difficulty
            this.diff = diff;

            //setup music player for background music
            backgroundMusicWP = new WaveOut();
            backgroudMusicFileReader = new AudioFileReader("Music/background_" + 
                diff.ToString().ToLower() + ".mp3");

            backgroundMusicWP.Init(backgroudMusicFileReader);
            backgroundMusicWP.Play();
        }

        int loadHighScore() //returns -1 if no high score saved, otherwise returns the high score
        {
            if (File.Exists("highScore.txt"))
            {
                try
                {
                    StreamReader sr = new StreamReader("highScore.txt");

                    string scoreString = sr.ReadLine();
                    sr.Close();

                    return Convert.ToInt32(scoreString);
                }
                catch (FormatException) //save file corrupted
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        void saveHighScore() //save high score to a file
        {
            StreamWriter sw = new StreamWriter("highScore.txt");
            sw.Write(highScore.ToString());
            sw.Close();
        }

        PictureBox[] generatePictures() // make the hangman drawing on the screen
        {
            //load picture array
            pictures = new PictureBox[10];

            //setup first picturebox
            pictures[0] = new PictureBox();

            pictures[0].Location = new Point(12, 12); //set it up at 12, 12 pixels
            pictures[0].Size = new System.Drawing.Size(500, 500); //make it 500x500 pixels big
            pictures[0].ImageLocation = @"Images/0.png";
            pictures[0].SizeMode = PictureBoxSizeMode.Zoom; //the images are 250x250, so they need to be upscaled

            pictures[0].BackColor = Color.Transparent; //so you can see stuff behind
            pictures[0].Visible = false;
            this.Controls.Add(pictures[0]);

            //do this for all other things, the first one needs to be setup seperately
            //refer to comments above
            for (int i = 1; i < 10; i++)
            {
                pictures[i] = new PictureBox();

                pictures[i].Location = new Point(0, 0);
                pictures[i].Size = new System.Drawing.Size(500, 500);
                pictures[i].BackColor = Color.Transparent;
                pictures[i].SizeMode = PictureBoxSizeMode.Zoom;

                pictures[i].ImageLocation = @"Images/" + i + ".png";

                pictures[i].Visible = false;

                pictures[i - 1].Controls.Add(pictures[i]);
            }

            return pictures;
        }

        string[] loadWords()
        {
            StreamReader wordsFile = new StreamReader(@"W:\\files\\marnHangman.txt"); //open word file

            //split it into a string array (split on newlines)
            string[] words = wordsFile.ReadToEnd().Split(new string[] {System.Environment.NewLine}, System.StringSplitOptions.None);

            wordsFile.Close();

            return words;
        }

        string pickWord(string[] words)
        {
            Random rnd = new Random();

            string word = words[rnd.Next(0, words.Length)].ToLower(); //pick a random word

            charsToGuess = word.Length;

            letters = new Label[word.Length]; //create array of letters

            //dynamically generate boxes for each letter
            for (int i = 0; i < word.Length; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                //set font style and size
                lbl.Font = new System.Drawing.Font("Monospac821 BT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
                //starting location is 12, 700, add 50px each box
                lbl.Location = new Point(12 + (i * 50), 700);
                lbl.Text = " "; //space by defualt, set to its char when it's guessed

                //only display the border on non-spaces, also they dont need to guess spaces
                if (word[i] == ' ')
                {
                    charsToGuess--;
                }
                else
                {
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                }

                this.Controls.Add(lbl);
                letters[i] = lbl;
            }

            attempts = 0;
            return word;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guesses++;

            string text = txtGuess.Text;
            //we dont need to process spaces or no input
            if (text.Length < 1 || text == " ")
            {
                return;
            }
            if (text.Length > 1) //if its more than one char, guess a word
            {
                guessWord(text);
            }
            else //guess a letter
            {
                guessLetter(text[0]);
            }

            txtGuess.Text = ""; //reset it to nothing
        }

        void guessLetter(char letter)
        {
            if (guessdChars.Contains(letter)) //dont let them guess the same char twice
            {
                MessageBox.Show("Letter already guessed!");
            }
            else
            {
                List<Int32> indexes = new List<Int32>(); //each index is where a character is

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter) //if we find the word, add it to the list
                    {
                        indexes.Add(i);
                    }
                }

                lblGuessedChars.Text += letter.ToString() + " "; //add it to the box of guessed chars
                
                guessdChars += letter;

                if (indexes.Count <= 0) //not in the string
                {
                    attemptedGuess();
                }
                else
                {
                    foreach (int i in indexes) 
                    {
                        //display the character in its box
                        letters[i].Text = word[i].ToString();

                        //they have to guess less chars
                        charsToGuess--;
                    }
                }

                if (charsToGuess == 0)
                {
                    //they've guessed everything
                    win();
                }
            }
        }

        void guessWord(string word_) //check if its equal, if so, they win, otherwise, its a guess
        {
            if (word.Equals(word_))
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i].Text = word[i].ToString();
                }
                win();
            }
            else
            {
                attemptedGuess();
            }
        }

        void attemptedGuess()
        {

            //set the threshold (amount of guesses to lose) based on the difficulty
            int threshold = 10;
            switch (diff)
            {
                case difficulty.easy:
                    threshold = 20;
                    break;
                case difficulty.medium:
                    threshold = 10;
                    break;
                case difficulty.hard:
                    threshold = 5;
                    break;
            }

            if (attempts >= threshold)
            {
                lose();
            }

            else
            {
                attempts++;

                switch (diff) //set different things to visible depending on the difficulty
                {
                    case difficulty.easy: //set one element visible every 2 guesses
                        if (attempts % 2 == 0)
                        {
                            pictures[attempts/2 - 1].Visible = true;
                        }
                        break;
                    case difficulty.medium: //set one element visible each guess
                        pictures[attempts - 1].Visible = true;
                        break;
                    case difficulty.hard: //set 2 elements visible each guess
                        try
                        {
                            pictures[attempts * 2 - 1].Visible = true;
                            pictures[attempts * 2 - 2].Visible = true;
                        }
                        catch (IndexOutOfRangeException) { } //no things left to make visible
                        break;
                }
            }
        }

        void lose()
        {
            backgroundMusicWP.Stop(); //stop playing the music

            MessageBox.Show("You are out of guesses! You didnt guess the word. It was " + word + ".\n" +
                "Press the quit button if you would like to quit.");
            reload();
        }

        void win()
        {
            backgroundMusicWP.Stop(); //stop playing the music

            //setup audio player for victory sound
            IWavePlayer wp = new WaveOut();
            AudioFileReader afr = new AudioFileReader("Music/win.mp3");

            wp.Init(afr);
            wp.Play();

            if (guesses < highScore || highScore == -1)
            {
                MessageBox.Show("New high score!");
                highScore = guesses;
                saveHighScore();
            }

            MessageBox.Show("You guessed the word! Press the quit button to quit.");

            wp.Dispose();
            wp.Stop();
            afr.Dispose();

            reload();
        }

        void reload()
        {
            foreach (PictureBox i in pictures) //set all pictures to be invisible
            {
                i.Visible = false;
            }

            foreach (Label i in letters)
            {
                i.Text = " ";
                this.Controls.Remove(i);
            }

            if (highScore > -1) //set highscore to be visible if it exists
            {
                lblHighScoreTitle.Visible = true;
                lblHighScore.Visible = true;
                lblHighScore.Text = highScore.ToString();
            }
            else
            {
                lblHighScoreTitle.Visible = false;
                lblHighScore.Visible = false;
            }


            lblGuessedChars.Text = "";
            guessdChars = "";

            //pick new word, set guesses and stuff
            word = pickWord(words);
            guesses = 0;
            attempts = 0;

            //restart music
            backgroundMusicWP.Stop();
            backgroundMusicWP.Dispose();
            backgroudMusicFileReader.Dispose();

            backgroundMusicWP = new WaveOut();
            backgroudMusicFileReader = new AudioFileReader("Music/background_" +
                diff.ToString().ToLower() + ".mp3");

            backgroundMusicWP.Init(backgroudMusicFileReader);
            backgroundMusicWP.Play();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //stop music
            backgroundMusicWP.Stop();
            backgroundMusicWP.Dispose();
            backgroudMusicFileReader.Dispose();
            
            new Closing().Show();
            this.Hide();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //stop music and quit
            backgroundMusicWP.Stop();
            backgroundMusicWP.Dispose();
            backgroudMusicFileReader.Dispose();
            System.Environment.Exit(0);
        }
    }
}
