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
        }

        public class var_class
        {
            public static string random_word = "";
            public static string correct_chars = "";
            public static string correct_letters = "";
            public static string wrong_letters = "";
            public static string correct_output = "";
            public static string typed_letters = "";

            public static bool correct = false;
            public static bool woord_geraden = false;
            public static bool duplicate_input = false;
            //public static List<char> typed_letters = new List<char>();

            public static int wrong_guesses = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable game over and success components
            popup_panel.Hide();
            lbl_game_state.Visible = false;
            btn_restart.Visible = false;
            lbl_word_was_txt.Visible = false;
            lbl_word_was.Visible = false;

            string[] cars = { "GYMZAAL", "CLUBPAS", "CUPCAKE", "PLOFKIP", "WIJNZAK", "WEBSHOP", "KETCHUP" };

            Random rnd = new Random();
            int indx = rnd.Next(0, cars.Length);
            var_class.random_word = cars[indx].ToLower();

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
            var_class.duplicate_input = false;
            Debug.WriteLine("The START");

            if (is_game_over())
            {
                Debug.WriteLine("Game Over");

                lbl_word_was.Text = var_class.random_word;
                lbl_game_state.Text = "Game Over";

                popup_panel.Show();
                lbl_game_state.Visible = true;
                btn_restart.Visible = true;
                lbl_word_was_txt.Visible = true;
                lbl_word_was.Visible = true;
            }

            string userInput = textBox1.Text;
            Debug.WriteLine(userInput);

            textBox1.Text = "";

            var_class.correct = false;

            check_input(userInput);

            char[] random_word_array_chars = var_class.random_word.ToCharArray();

            int i = 0;
            foreach (char random_word_char in random_word_array_chars)
            {
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    // Check if current character is in random_word
                    if (Char.ToLower(userInput[0]) == random_word_char)
                    {
                        var_class.correct = true;

                        StringBuilder sb = new StringBuilder(var_class.correct_output);
                        sb[i] = userInput[0];

                        var_class.correct_output = sb.ToString();

                        var_class.correct_letters += userInput;
                        Debug.WriteLine($"Check {var_class.correct_letters}");
                        Debug.WriteLine($"Correct_output: {var_class.correct_output}");
                        //if (var_class.correct_letters.Length == var_class.random_word.Length)
                        if (is_correct_word())
                        {
                            var_class.woord_geraden = true;
                            Debug.WriteLine("Woord is compleet");
                            // TODO: POPUP "Gefeliciteerd \n Opnieuw?"
                        }
                    }
                    else if (!Char.IsLetter(userInput[0]))
                    {
                        var_class.correct = true;
                    }
                }
                else
                {
                    var_class.correct = true;
                }

                i++;
            }


            if (var_class.correct == false && var_class.duplicate_input == false)
            {
                if (var_class.wrong_guesses < 6)
                {
                    var_class.wrong_guesses++;
                }
                
                this.img_galgje.ImageLocation = $"images\\{var_class.wrong_guesses}.png";
                var_class.wrong_letters += userInput;
                this.lbl_output.Text = var_class.wrong_letters;

            }
            else if (var_class.correct == true)
            {
               
                Debug.WriteLine("gelukt");
            }
            
            if (var_class.woord_geraden == true)
            {
                lbl_game_state.Text = "Success";

                popup_panel.Show();
                lbl_game_state.Visible = true;
                btn_restart.Visible = true;
                //lbl_word_was_txt.Visible = true;
                //lbl_word_was.Visible = true;
            }

            if (var_class.duplicate_input == true)
            {
                this.lbl_output.Text = var_class.wrong_letters;
            }

            this.label1.Text = var_class.correct_output;
        }

        static bool is_game_over()
        {
            return (var_class.wrong_guesses > 5);
        }

        static bool is_correct_word()
        {
            if (var_class.correct_output == var_class.random_word)
            {
                return true;
            }
            return false;
        }

        static void start_up()
        {

        }

        private void lbl_output_Click(object sender, EventArgs e)
        {
        }

        private void img_galgje_Click(object sender, EventArgs e)
        {

        }

        private void game_over_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_word_was_txt_Click(object sender, EventArgs e)
        {

        }

        private void lbl_word_was_Click(object sender, EventArgs e)
        {
        }

        static void check_input(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                Debug.WriteLine(var_class.typed_letters);
                if (var_class.typed_letters.ToLower().Contains(userInput.ToLower()))
                {
                    Debug.WriteLine($"letter {userInput} al gebruikt");
                    var_class.duplicate_input = true;
                }
                var_class.typed_letters += userInput;
                Debug.WriteLine($"Gebruikte letters: {var_class.typed_letters}");
            }
            else { Debug.WriteLine("geen letter gebuirkt"); }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            // Reset everything
            var_class.random_word = "";
            var_class.correct_chars = "";
            var_class.correct_letters = "";
            var_class.wrong_letters = "";
            var_class.correct_output = "";
            var_class.typed_letters = "";

            var_class.correct = false;
            var_class.woord_geraden = false;
            var_class.duplicate_input = false;

            var_class.woord_geraden = false;

            var_class.correct_output = "";
            this.img_galgje.ImageLocation = "images\\-1.png";
            var_class.wrong_guesses = -1;
            var_class.wrong_letters = "";

            // Disable game over and success components
            popup_panel.Hide();
            lbl_game_state.Visible = false;
            btn_restart.Visible = false;
            lbl_word_was_txt.Visible = false;
            lbl_word_was.Visible = false;

            string[] cars = { "GYMZAAL", "CLUBPAS", "CUPCAKE", "PLOFKIP", "WIJNZAK", "WEBSHOP", "KETCHUP" };

            Random rnd = new Random();
            int indx = rnd.Next(0, cars.Length);
            var_class.random_word = cars[indx].ToLower();

            for (int i = 0; i < var_class.random_word.Length; i++)
            {
                var_class.correct_output += "-";
            }
            this.label1.Text = var_class.correct_output;
            this.lbl_output.Text = "";
        }
    }

}