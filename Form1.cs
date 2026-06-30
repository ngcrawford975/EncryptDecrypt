using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        //Here, we are going to establish our dictionary and fill it with key/value pairs.
        //I am combining the encryption and decryption portions of this project so I'm putting the dictionary here so it can be handled by both button events.
        Dictionary<char, char> characterPairs = new Dictionary<char, char>()
        //this is where we actually fill it with pairs.
        {
            {'A', '!' }, {'B', ')' },
            {'C', '@' }, {'D', '(' },
            {'E', '#' }, {'F', '*' },
            {'G', '&' }, {'H', '$' },
            {'I', '%' }, {'J', '^' },
            {'K', '[' }, {'L', ']' },
            {'M', '{' }, {'N', '}' },
            {'O', '|' }, {'P', ';' },
            {'Q', ';' }, {'R', ':' },
            {'S', '"' }, {'T', ',' },
            {'U', '<' }, {'V', '.' },
            {'W', '>' }, {'X', '/' },
            {'Y', '?' }, {'Z', '-' },
            {'a', '_' }, {'b', '=' },
            {'c', '+' }, {'d', '1' },
            {'e', '2' }, {'f', '3' },
            {'g', '4' }, {'h', '5' },
            {'i', '6' }, {'j', '7' },
            {'k', '8' }, {'l', '9' },
            {'m', '0' }, {'n', '©' },
            {'o', 'ª' }, {'p', 'º' },
            {'q', '€' }, {'r', '©' },
            {'s', '®' }, {'t', '¯' },
            {'u', '³' }, {'v', '´' },
            {'w', '¸' }, {'x', '¹' },
            {'y', 'Ø' }, {'z', 'Š' }
            //thankful for Alt keyboard sequences
        };
        public Form1()
        {
            InitializeComponent();
        }

        //now that I have the shared dictionary established and filled up top, I can shove the meat of this program into the events when the user presses a button.
        //I have the encrypt button on the left and the decrypt button on the righ so I'll do the encryption first hear as well.

        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            //I'm adding a file picker window right here. I'm adding it here so the encryption button can start the process.
            //the user will see a file picker window pop up and be able to upload their own txt file for this part of the program to encrypt.
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            //right here i'm going to create a variable that will hold a line of text this program reads from the users .txt file. This will continue to get overwritten as we iterate through multiple lines.
            string lineOfText;

            //now that the user can select a desired file, we can work on openening their selected file.
            //Thank you chapter 5
            StreamReader userFile = File.OpenText(dialog.FileName);

            //Now, we have to create an output file for our program to write the encrypted message to.
            StreamWriter programFile = File.CreateText("Encoded.txt");

            //Im about to use a while loop for this next part because I have no idea how many lines of code the user will write in their .txt file, so we need to account for a ridiculous number.
            //since I want it to go until there are no lines left, I'll tell it while the line != null. This should also account for 'blank' lines if the user hits enter for a blank line between lines.
            // a blank line is "" not null
            while ((lineOfText = userFile.ReadLine()) != null)
            {
                //similar to our LineOfText variable, encodedLine holds the empty string in our encrypted file and we weill feel it as we iterate through.
                string encodedLine = "";

                //This inner loop will loop through the current line in the userfile one character at a time
                foreach (char i in lineOfText)
                {
                    //This is the meat of this loop. This if else statement compares the characters in the lines to our dictionary we made. If there is a match, it will replace that key with it's value as it writes to our encrypted text file.
                    //Ideally, we won't have to use the else part of this statement, but that was a lot of characters and I'm going to use it to test anyway, so i'm leaving it here.
                    //'i' is just a placeholder for our loop that I used a lot in python. Old habits.
                    if (characterPairs.ContainsKey(i))
                        encodedLine += characterPairs[i];
                    else
                        encodedLine += i;
                }

                //all this really does is just tell the program to write down the encryption it built. It will be whatever the endodedLine string is holding.
                programFile.WriteLine(encodedLine);
            }

            userFile.Close();
            programFile.Close();

            //I'm adding a message box just so the user has some confirmation.
            MessageBox.Show("Your file has been encrypted.");
        }
    }
}
