using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.b.Word_Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text.ToLower();
            bool isPalindrome = IsPalindrome(word);
            if (isPalindrome)
            {
                MessageBox.Show($"The word '{word}' is a palindrome.", "Palindrome Checker");
            }
            else
            {
                MessageBox.Show($"The word '{word}' is not a palindrome.", "Palindrome Checker");
            }
        }

            private bool IsPalindrome(string word)
            {
                int left = 0;
                int right = word.Length - 1;

                while (left < right)
                {
                    if (word[left] != word[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                return true;
            }
        }
    }

