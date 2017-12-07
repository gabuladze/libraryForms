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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarydbDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.librarydbDataSet.categories);
            // TODO: This line of code loads data into the 'librarydbDataSet.authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.librarydbDataSet.authors);
            // TODO: This line of code loads data into the 'librarydbDataSet.lendables' table. You can move, or remove it, as needed.
            this.lendablesTableAdapter.Fill(this.librarydbDataSet.lendables);
            this.addColumnsToListView();
        }

        private void addColumnsToListView()
        {
            ColumnHeader[] cols = new ColumnHeader[] { 
                        new ColumnHeader { Text = "Name", Width = 120 },
                        new ColumnHeader { Text = "Author",Width = 100 },
                        new ColumnHeader { Text = "Category", Width = 100 }, 
                        new ColumnHeader { Text = "Genre", Width = 100 }
                    };

            borrowedItemListView.Columns.AddRange(cols);
        }
    }
}
