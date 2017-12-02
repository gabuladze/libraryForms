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
        StudentForm StudentForm;
        LibraryDBDataContext LibraryDB = new LibraryDBDataContext();

        public LoginForm()
        {
            InitializeComponent();
            this.StudentForm = new StudentForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // compare textbox values to db
            StudentForm.Show();
        }
    }
}
