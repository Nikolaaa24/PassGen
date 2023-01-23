using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Windows.Forms.Timer;

namespace passgen
{
    public partial class passgen : Form
    {
        public passgen()
        {
            InitializeComponent();
        }

        public static string GeneratePassword(int length, string validChars)
        {
            // Create a StringBuilder object to store the password
            StringBuilder res = new StringBuilder();

            // Create a RandomNumberGenerator object to generate random numbers
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                // Create a buffer to store the random bytes
                byte[] uintBuffer = new byte[sizeof(uint)];

                // Keep generating random characters until the desired length is reached
                while (length-- > 0)
                {
                    // Fill the buffer with random bytes
                    rng.GetBytes(uintBuffer);

                    // Convert the bytes to a uint (unsigned integer)
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);

                    // Use the uint to select a character from the validChars string
                    // and append it to the password string
                    res.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }
            }

            // Convert the StringBuilder object to a string and return it as the password
            return res.ToString();
        }
        private void csprngchk_CheckedChanged(object sender, EventArgs e)
        {
            if (csprngchk.Checked == true)
            {
                prngchk.Checked = false;
                csharpmethodchk.Checked = false;
                seedtxt.Visible = false;
                mathformtxt.Visible = false;
            }
        }

        private void prngchk_CheckedChanged(object sender, EventArgs e)
        {
            if (prngchk.Checked == true)
            {
                csprngchk.Checked = false;
                csharpmethodchk.Checked = false;
                seedtxt.Visible = true;
                mathformtxt.Visible = true;
            }
        }

        private void csharpmethodchk_CheckedChanged(object sender, EventArgs e)
        {
            if (csharpmethodchk.Checked == true)
            {
                csprngchk.Checked = false;
                prngchk.Checked = false;
                seedtxt.Visible = false;
                mathformtxt.Visible = false;
            }
        }

        private void genpassbtn_Click(object sender, EventArgs e)
        {
            string allowedchar = allowedchars.Text;
            string length = passlength.Text;
            int numberofchar;
            if (int.TryParse(length, out numberofchar))
            {
                if (numberofchar >= 1 && numberofchar <= 20)
                {
                    // The text box contains a number between 1 and 20
                    errortxt.Visible = false;
                    if (csprngchk.Checked)
                    {
                        passlength.BackColor = Color.FromArgb(45, 45, 45); ;
                        errortxt.Visible = false;
                        string password = GeneratePassword(numberofchar, allowedchars.Text);
                        passtxt.Text = password;
                    }
                    else if (prngchk.Checked)
                    {
                        // Text box 2 is checked
                    }
                    else if (csharpmethodchk.Checked)
                    {
                        // Text box 3 is checked
                    }
                    else
                    {
                        // None of the text boxes are checked
                    }
                }
                else
                {
                    // The text box does not contain a number between 1 and 20
                    passlength.BackColor = Color.DarkRed;
                    errortxt.Visible = true;
                    errortxt.Text = "Number needs to be between 1 and 20.";

                }
            }
            else
            {
                // The text box does not contain a valid number
                passlength.BackColor = Color.DarkRed;
                errortxt.Visible = true;
                errortxt.Text = "Provided number is invalid.";
            }
        }

        private void defaultchk_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultchk.Checked == true)
            {
                allowedchars.Enabled = false;
                customchk.Checked = false;
                allowedchars.ReadOnly = true;
                allowedchars.BackColor = Color.FromArgb(65, 65, 65);
                allowedchars.Text = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%&";
            }
        }


        private void customchk_CheckedChanged(object sender, EventArgs e)
        {
            if (customchk.Checked == true)
            {
                allowedchars.Enabled = true;
                defaultchk.Checked = false;
                allowedchars.ReadOnly = false;
                allowedchars.HideSelection = false;
                allowedchars.BackColor = Color.FromArgb(45, 45, 45);
            }
        }

        private void passgen_Load(object sender, EventArgs e)
        {
            if (defaultchk.Checked == true)
            {
                allowedchars.Enabled = false;
                customchk.Checked = false;
                allowedchars.ReadOnly = true;
                allowedchars.HideSelection = true;
                allowedchars.BackColor = Color.FromArgb(65, 65, 65);
                allowedchars.Text = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%&";
            }
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            cpdtxt.Visible = true;
            Clipboard.SetText(passtxt.Text);
            // Set the initial position of the Label
            cpdtxt.Location = new Point(550, 400);

            // Use a Timer to update the Top property of the Label
            // at regular intervals
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, e) =>
            {
                // Update the Top property of the Label
                cpdtxt.Top -= 3;

                // Stop the Timer when the Label reaches its final position
                if (cpdtxt.Top <= 350)
                {
                    timer.Stop();
                    cpdtxt.Visible = false;
                    cpdtxt.Location = new Point(550, 400);
                }
            };
            timer.Start();
        }
    }
}