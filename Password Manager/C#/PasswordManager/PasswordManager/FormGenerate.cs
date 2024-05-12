using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class FormGenerate : Form
    {
        public FormGenerate()
        {
            InitializeComponent();
        }

        private void FormGenerate_Load(object sender, EventArgs e)
        {

        }

        //this is the generate functionality.
        private string GeneratePassword()
        {
            Random random = new Random();
            const string LOWER = "qwertyuiopasdfghjklzxcvbnm";
            const string UPPER = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string NUMBER = "1234567890";
            const string SPECIAL = @"`!@#$%^&*()-+={[}]|\:;'<,>.?/";
            string custom = textCustom.Text;

            string include = "";
            if (checkLowercase.Checked) include += LOWER;
            if (checkUppercase.Checked) include += UPPER;
            if (checkNumbers.Checked) include += NUMBER;
            if (checkSpecial.Checked) include += SPECIAL;
            if (checkCustom.Checked) include += custom;

            int minCharacters = int.Parse(textMin.Text);
            int maxCharacters = int.Parse(textMax.Text);
            int passwordLength = random.Next(minCharacters, maxCharacters + 1);

            //this is done to ensure at least one of each from every selected category is used
            string password = "";
            if (checkLowercase.Checked) password += randomChar(LOWER, random);
            if (checkUppercase.Checked) password += randomChar(UPPER, random);
            if (checkNumbers.Checked) password += randomChar(NUMBER, random);
            if (checkSpecial.Checked) password += randomChar(SPECIAL, random);
            if (checkCustom.Checked) password += randomChar(custom, random);

            //this will finish populating the password randomly
            while (password.Length < passwordLength)
                password += include.Substring(random.Next(0, include.Length - 1), 1);

            return password;
        }

        //used to randomize a selection from the categories
        private char randomChar(string text, Random random)
        {
            int index = random.Next(text.Length);
            return text[index];
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textPassword.Text = GeneratePassword();
        }
    }
}
