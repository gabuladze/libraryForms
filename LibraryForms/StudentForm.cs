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
    public partial class StudentForm : Form
    {
        List<Lendable> lendables;
        LibraryDBDataContext LibraryDB = new LibraryDBDataContext();
        User currentUser;

        public StudentForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
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
            this.fetchBorrowedItems();
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

        private void fetchBorrowedItems()
        {
            try
            {
                this.lendables = (
                        from l in LibraryDB.lendables
                        join a in LibraryDB.authors on l.author_id equals a.id
                        join c in LibraryDB.categories on l.category_id equals c.id
                        join g in LibraryDB.genres on l.genre_id equals g.id
                        join lu in LibraryDB.lendable_users on l.id equals lu.lendable_id into finalGroup
                        from finalItem in finalGroup.DefaultIfEmpty()
                        where finalItem.user_id == this.currentUser.id
                        select new Lendable
                        {
                            id = l.id,
                            slug = l.slug,
                            display_name = l.display_name,
                            author = new Author
                            {
                                id = a.id,
                                first_name = a.first_name,
                                last_name = a.last_name
                            },
                            category = new Category
                            {
                                id = c.id,
                                slug = c.slug,
                                display_name = c.display_name
                            },
                            genre = new Genre
                            {
                                id = g.id,
                                slug = g.slug,
                                display_name = g.display_name
                            }
                        }
                    ).ToList<Lendable>();
            }
            catch (Exception)
            {
                MessageBox.Show("No lendables have been found");
                throw;
            }

            if (this.lendables != null)
	        {
                borrowedItemListView.Items.Clear();

                foreach (var item in this.lendables)
                {
                    ListViewItem i1 = new ListViewItem(item.display_name);
                    i1.SubItems.Add(item.author.first_name+" "+item.author.last_name);
                    i1.SubItems.Add(item.category.display_name);
                    i1.SubItems.Add(item.genre.display_name);

                    borrowedItemListView.Items.Add(i1); 
                }
	        }
        }
    }
}
