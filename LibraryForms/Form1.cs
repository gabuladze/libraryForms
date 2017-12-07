using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryForms
{
    public partial class LoginForm : Form
    {
        LibraryDBDataContext LibraryDB = new LibraryDBDataContext();
        StudentForm StudentForm;
        LibrarianForm LibrarianForm;
        User currentUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.tryLogin())
            {
                this.openDashboard();
            }
        }

        private bool tryLogin()
        {
            // compare textbox values to db
            try
            {
                this.currentUser = (
                    from u in LibraryDB.users
                    where u.email == emailTextBox.Text && u.password == passwordTextBox.Text
                    select new User
                    {
                        id = u.id,
                        first_name = u.first_name,
                        last_name = u.last_name,
                        email = u.email ,
                        role = u.role
                    }).First();
                return true;
            }
            catch (Exception ex)
            {
                // use ^ that ex var maybe??
                MessageBox.Show("Invalid Credentials!");
                return false;
            }
        }

        private void openDashboard()
        {
            // check for role
            switch (this.currentUser.role)
            {
                case "USER":
                    this.StudentForm = new StudentForm(currentUser);
                    this.StudentForm.Show();
                    break;
                case "LIBRARIAN":
                    this.LibrarianForm = new LibrarianForm();
                    this.LibrarianForm.Show();
                    break;
                default:
                    break;
            }
            // reset input values, duh
            this.resetInputValues();

        }

        private void resetInputValues()
        {
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
