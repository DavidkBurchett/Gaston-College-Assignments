using Microsoft.Win32;
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
    public partial class Form1 : Form
    {
        //establish variables
        List<PasswordModel> passwords = new List<PasswordModel>();
        private string masterPassword = "";
        public Form1()
        {
            InitializeComponent();
        }

        //this loads the database into the data grid view
        private void LoadPasswordList()
        {
            passwords = SqliteDataAccess.LoadPasswords();
            dataGridView.DataSource = passwords;
        }

        //returns the result from the dialog of the input box. useful if only looking for the cancel selection
        private DialogResult InputBox(string prompt, out string result)
        {
            FormInput dialog = new FormInput();
            dialog.Text = prompt;
            dialog.labelFormInput.Text = prompt;

            DialogResult dialogResult = dialog.ShowDialog();

            result = dialog.textBox.Text;
            return dialogResult;
        }

        //this pulls master password and confirms it matches
        private void VerifyMasterPassword()
        {
            //closes application if user selects cancel
            if(InputBox("Login: ", out masterPassword) == DialogResult.Cancel)
            {
                Close();
                return;
            }

            //checks password
            string fetchedMaster = MasterPassword.GetPassword("");
            if(fetchedMaster.Length != 0)
            {
                if(masterPassword != fetchedMaster)
                {
                    MessageBox.Show("Incorrect master password", "Incorrect master password", MessageBoxButtons.OK);
                    masterPassword = "";
                    Close();
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerifyMasterPassword();
            LoadPasswordList();

            //this allocates space for the button columns
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCopy,
            this.colGenerate,
            this.colDelete});

            //this would create an exception because the data grid view would not load if the user did not sign in, so i catch it but since the application is closing anyways it does nothing
            try
            {
                dataGridView.Columns.Remove("ID");
            }
            catch {}
        }
        
        //save new master password on closing, if they didnt enter a new master on first sign in it doesnt save
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (masterPassword.Length == 0) return;

            MasterPassword.SavePassword(masterPassword);
        }

        //this creates the button columns and their functionalities
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //copy password to clipboard
            if (dataGridView.Columns[e.ColumnIndex].Name == "colCopy")
            {
                Clipboard.Clear();
                Clipboard.SetText(dataGridView.Rows[e.RowIndex].Cells["Password"].Value.ToString());
            }
            //delete a password from the database
            if (dataGridView.Columns[e.ColumnIndex].Name == "colDelete")
            {
                LoadPasswordList();
                SqliteDataAccess.RemovePassword(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value)); 
                LoadPasswordList();
                dataGridView.Columns.Remove("ID");
            }
            //generates a new password by taking user to generate form
            if(dataGridView.Columns[e.ColumnIndex].Name == "colGenerate")
            {
                FormGenerate form = new FormGenerate();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPasswordList();
                    SqliteDataAccess.SaveGeneratedPassword(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value), form.textPassword.Text);
                    LoadPasswordList();
                    dataGridView.Columns.Remove("ID");
                }
            }
        }

        //adds a new entry to the database through user input
        private void addPasword_Click(object sender, EventArgs e)
        {
            PasswordModel p = new PasswordModel();

            p.Application = textApplication.Text;
            p.Password = textPassword.Text;

            SqliteDataAccess.SaveNewPassword(p);

            textApplication.Text = "";
            textPassword.Text = "";
            LoadPasswordList();
            dataGridView.Columns.Remove("ID");
        }

        //search database through user input
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + textBoxSearch.Text);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        //change the master password
        private void changeMasterPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput formChangeMaster = new FormInput();
            formChangeMaster.Text = "Change Master Password";
            formChangeMaster.labelFormInput.Text = "Change Master Password";

            if(formChangeMaster.ShowDialog() == DialogResult.OK)
            {
                masterPassword = formChangeMaster.textBox.Text;
            }

            MessageBox.Show("Master password changed.", "Success", MessageBoxButtons.OK);
        }

        //refresh data grid view by repopulating from database
        private void refreshDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPasswordList();
            dataGridView.Columns.Remove("ID");
        }
        
        //close application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
