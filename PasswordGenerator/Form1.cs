using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        string possibleCharactersWithSymbols = "acbdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=[];,./{}:<>?|";
        string possibleCharactersNoSymbols = "acbdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        char selectedCharacter;

        StringBuilder eightCharacterPassword = new StringBuilder ("", 8);

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordBox.Text = String.Empty;
            eightCharacterPassword.Clear();

            for (int i = 0; i < 8; i++)
            {
                selectedCharacter = (possibleCharactersWithSymbols[rnd.Next(0, possibleCharactersWithSymbols.Length)]);
                eightCharacterPassword.Append(selectedCharacter);
            }

            passwordBox.Text = eightCharacterPassword.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordBox.Text = String.Empty;
            eightCharacterPassword.Clear();

            for (int i = 0; i < 16; i++)
            {
                selectedCharacter = (possibleCharactersWithSymbols[rnd.Next(0, possibleCharactersWithSymbols.Length)]);
                eightCharacterPassword.Append(selectedCharacter);
            }

            passwordBox.Text = eightCharacterPassword.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passwordBox.Text = String.Empty;
            eightCharacterPassword.Clear();

            for (int i = 0; i < 8; i++)
            {
                selectedCharacter = (possibleCharactersNoSymbols[rnd.Next(0, possibleCharactersNoSymbols.Length)]);
                eightCharacterPassword.Append(selectedCharacter);
            }

            passwordBox.Text = eightCharacterPassword.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passwordBox.Text = String.Empty;
            eightCharacterPassword.Clear();

            for (int i = 0; i < 16; i++)
            {
                selectedCharacter = (possibleCharactersNoSymbols[rnd.Next(0, possibleCharactersNoSymbols.Length)]);
                eightCharacterPassword.Append(selectedCharacter);
            }

            passwordBox.Text = eightCharacterPassword.ToString();
        }
    }
}
