﻿using System;
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

        public LoginForm()
        {
            InitializeComponent();
            this.StudentForm = new StudentForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            StudentForm.Show();
        }
    }
}
