using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MatchedBox.Text = "";
            Search(TextBox.Text, PatternBox.Text);
        }

        private void Search(string text, string pattern)
        {
            if (IsMatched(text, pattern))
            {
                string[] ListOfWords = text.Split(' ');
                foreach (string word in ListOfWords)
                {
                    if(word.Contains(pattern))
                    {
                        MatchedBox.Text += word + ", ";
                    }
                }
            }
        }

        private bool IsMatched(string text, string pattern)
        {
            string beginning = "^";
            string ending = "$";
            string final = beginning + pattern + ending;
            return Regex.Match(text, final) != null ? true : false;

        }
    }
}
