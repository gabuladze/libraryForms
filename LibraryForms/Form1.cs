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
        User currentUser;

        public LoginForm()
        {
            InitializeComponent();
            this.StudentForm = new StudentForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // compare textbox values to db
            try { 
                currentUser = (
                    from u in LibraryDB.users
                    where u.email == emailTextBox.Text && u.password == passwordTextBox.Text
                    select new User {
                        id = u.id, 
                        first_name = u.first_name, 
                        last_name = u.last_name, 
                        email = u.email
                    }).First();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Credentials!");
            }
            // Check if user exists

            if (currentUser != null)
            {
                MessageBox.Show(currentUser.GetType().ToString());
                StudentForm.Show();
            }
        }
    }
}
