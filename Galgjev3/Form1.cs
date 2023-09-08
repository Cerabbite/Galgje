using System.Diagnostics;
using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Galgjev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // test();
        }

        public class var_class
        {
            public static string random_word = "";
            public static string correct_chars = "";
            public static string correct_letters = "";
            public static string typed_letters = "";
            public static string wrong_letters = "";
            public static string correct_output = "";

            public static int wrong_guesses = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars = { "GYMZAAL", "CLUBPAS", "CUPCAKE", "PLOFKIP", "WIJNZAK", "WEBSHOP", "KETCHUP" };
            Random rnd = new Random();
            int indx = rnd.Next(0, cars.Length);
            var_class.random_word = cars[indx].ToLower();
            Debug.WriteLine(var_class.random_word);
            for (int i = 0; i < var_class.random_word.Length; i++)
            {
                var_class.correct_output += "-";
            }
            this.label1.Text = var_class.correct_output;
            this.lbl_output.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("The START");
            if (var_class.wrong_guesses >= 6)
            {
                Debug.WriteLine("Game Over");
                //TODO: GAME OVER
            }

            string userInput = textBox1.Text;
            Debug.WriteLine(userInput);

            /*
             * TODO: VALIDATE INPUT 
            */

            textBox1.Text = "";

            // TODO: Remove letters from userInput that are in typed_letters
            var_class.typed_letters += userInput;

            char[] random_word_array_chars = var_class.random_word.ToCharArray();

            int i = 0;
            bool correct = false;
            //int c = 0;
            foreach (char random_word_char in random_word_array_chars)
            {
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    // Check if current character is in random_word
                    if (Char.ToLower(userInput[0]) == random_word_char)
                    {
                        correct = true;
                        //c = 1;

                        StringBuilder sb = new StringBuilder(var_class.correct_output);
                        sb[i] = userInput[0];

                        var_class.correct_output = sb.ToString();

                        var_class.correct_letters += userInput;
                        Debug.WriteLine($"Check {var_class.correct_letters}");
                        //TODO: correcte letters invullen op ___
                        if (var_class.correct_letters.Length == var_class.random_word.Length)
                        {
                            Debug.WriteLine("Woord is compleet");
                            // TODO: POPUP "Gefeliciteerd \nOpnieuw?"
                        }
                    }
                    else if (!Char.IsLetter(userInput[0]))
                    {
                        correct = true;
                    }
                }
                else
                {
                    correct = true;
                }
                //
                Debug.WriteLine($"[RANDOMWORD] = {var_class.random_word} - {userInput} | Substring: {random_word_char}");

                i++;
            }

            Debug.WriteLine($"Voor: {correct}");
            Debug.WriteLine($"A: {var_class.wrong_guesses}");

            if (correct == false && correct != true)
            {
                Debug.WriteLine($"Tijdens: {correct}");
                var_class.wrong_guesses++;
                Debug.WriteLine($"B: {var_class.wrong_guesses}");
                this.img_galgje.ImageLocation = $"\\images\\{var_class.wrong_guesses}.png";

                var_class.wrong_letters += userInput;
                this.lbl_output.Text = var_class.wrong_letters;
            }
            else if (correct == true) { Debug.WriteLine("gelukt"); }

            Debug.WriteLine($"Na: {correct}");
            Debug.WriteLine($"C: {var_class.wrong_guesses}");
            Debug.WriteLine($"IMG SRC: {this.img_galgje.ImageLocation}");

            this.label1.Text = var_class.correct_output;
            //Thread.Sleep(500);
        }

        private void lbl_output_Click(object sender, EventArgs e)
        {
        }

        private void img_galgje_Click(object sender, EventArgs e)
        {

        }
    }

}