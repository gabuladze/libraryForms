using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;

namespace LibraryForms
{
    public partial class LibrarianForm : Form
    {
        LibraryDBDataContext LibraryDB = new LibraryDBDataContext();
        List<Lendable> lendables;
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
            this.addColumnsToListView();
            this.fillUsersListBox();

        }

        private void saveUsersButton_Click(object sender, EventArgs e)
        {
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(librarydbDataSet.users);
            MessageBox.Show("Users have been updated!");
        }

        private void saveLendablesButton_Click(object sender, EventArgs e)
        {
            lendablesBindingSource.EndEdit();
            lendablesTableAdapter.Update(librarydbDataSet.lendables);
            MessageBox.Show("Lendables have been updated!");
        }

        private void saveCategoriesButton_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.EndEdit();
            categoriesTableAdapter.Update(librarydbDataSet.categories);
            MessageBox.Show("Categories have been updated!");
        }

        private void saveGenresButton_Click(object sender, EventArgs e)
        {
            genresBindingSource.EndEdit();
            genresTableAdapter.Update(librarydbDataSet.genres);
            MessageBox.Show("Genres have been updated!");
        }

        private void saveAuthorsButton_Click(object sender, EventArgs e)
        {
            authorsBindingSource.EndEdit();
            authorsTableAdapter.Update(librarydbDataSet.authors);
            MessageBox.Show("Authors have been updated!");
        }

        private void searchLendableButton_Click(object sender, EventArgs e)
        {         
            //validate search value
            if (searchValueTextBox.TextLength > 0)
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
                            join u in LibraryDB.users on finalItem.user_id equals u.id into userGroup
                            from userItem in userGroup.DefaultIfEmpty()
                            where SqlMethods.Like(l.display_name, "%" + searchValueTextBox.Text + "%")
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
                                },
                                user = new User
                                {
                                    id = userItem.id != null ? userItem.id : 0,
                                    first_name = userItem.first_name != null ? userItem.first_name : "",
                                    last_name = userItem.last_name != null ? userItem.last_name : ""
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
                    resultsListView.Items.Clear();

                    foreach (var item in this.lendables)
                    {
                        ListViewItem i1 = new ListViewItem(item.id.ToString());
                        i1.SubItems.Add(item.display_name);
                        i1.SubItems.Add(item.author.first_name+" "+item.author.last_name);
                        i1.SubItems.Add(item.category.display_name);
                        i1.SubItems.Add(item.genre.display_name);
                        i1.SubItems.Add(item.user.id != 0 ? "NO" : "YES");
                        i1.SubItems.Add(item.user.first_name != "" ? item.user.first_name + " " + item.user.last_name : "");

                        resultsListView.Items.Add(i1); 
                    }
	            }
                       
            }
        }

        private void addColumnsToListView() {
            ColumnHeader[] cols = new ColumnHeader[] { 
                new ColumnHeader { Text = "ID" },        
                new ColumnHeader { Text = "Name", Width = 120 },
                new ColumnHeader { Text = "Author",Width = 100 },
                new ColumnHeader { Text = "Category", Width = 100 },
                new ColumnHeader { Text = "Genre", Width = 100 },
                new ColumnHeader { Text = "Free", Width = 100 },
                new ColumnHeader { Text = "Lended To", Width = 100 },
            };

            resultsListView.Columns.AddRange(cols);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.librarydbDataSet.users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillUsersListBox()
        {
            usersListBox.DataSource = (
                from u in LibraryDB.users
                select new
                {
                    value = u.id,
                    text = u.first_name + " " + u.last_name
                }
            ).ToList();

            usersListBox.ValueMember = "value";
            usersListBox.DisplayMember = "text";
        }
    }
}
