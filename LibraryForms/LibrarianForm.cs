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
    public partial class LibrarianForm : Form
    {
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarydbDataSet.authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.librarydbDataSet.authors);
            // TODO: This line of code loads data into the 'librarydbDataSet.genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.librarydbDataSet.genres);
            // TODO: This line of code loads data into the 'librarydbDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.librarydbDataSet.categories);
            // TODO: This line of code loads data into the 'librarydbDataSet.lendables' table. You can move, or remove it, as needed.
            this.lendablesTableAdapter.Fill(this.librarydbDataSet.lendables);
            // TODO: This line of code loads data into the 'librarydbDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.librarydbDataSet.users);
            // TODO: This line of code loads data into the 'librarydbDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.librarydbDataSet.users);

        }
    }
}
