namespace LibraryForms
{
    partial class LibrarianForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.librarydbDataSet = new LibraryForms.librarydbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.usersTableAdapter();
            this.lendablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendablesTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.lendablesTableAdapter();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.categoriesTableAdapter();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.genresTableAdapter();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.authorsTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slugDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slugDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genreidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // librarydbDataSet
            // 
            this.librarydbDataSet.DataSetName = "librarydbDataSet";
            this.librarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.librarydbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lendablesBindingSource
            // 
            this.lendablesBindingSource.DataMember = "lendables";
            this.lendablesBindingSource.DataSource = this.librarydbDataSet;
            // 
            // lendablesTableAdapter
            // 
            this.lendablesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.librarydbDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "genres";
            this.genresBindingSource.DataSource = this.librarydbDataSet;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.librarydbDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(760, 563);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Authors";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.firstnameDataGridViewTextBoxColumn1,
            this.lastnameDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.authorsBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(754, 557);
            this.dataGridView5.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            // 
            // lastnameDataGridViewTextBoxColumn1
            // 
            this.lastnameDataGridViewTextBoxColumn1.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn1.Name = "lastnameDataGridViewTextBoxColumn1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(760, 563);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Genres";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.slugDataGridViewTextBoxColumn2,
            this.displaynameDataGridViewTextBoxColumn2});
            this.dataGridView4.DataSource = this.genresBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(754, 557);
            this.dataGridView4.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // slugDataGridViewTextBoxColumn2
            // 
            this.slugDataGridViewTextBoxColumn2.DataPropertyName = "slug";
            this.slugDataGridViewTextBoxColumn2.HeaderText = "Slug";
            this.slugDataGridViewTextBoxColumn2.Name = "slugDataGridViewTextBoxColumn2";
            // 
            // displaynameDataGridViewTextBoxColumn2
            // 
            this.displaynameDataGridViewTextBoxColumn2.DataPropertyName = "display_name";
            this.displaynameDataGridViewTextBoxColumn2.HeaderText = "Display Name";
            this.displaynameDataGridViewTextBoxColumn2.Name = "displaynameDataGridViewTextBoxColumn2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Categories";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.slugDataGridViewTextBoxColumn1,
            this.displaynameDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.categoriesBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(754, 557);
            this.dataGridView3.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // slugDataGridViewTextBoxColumn1
            // 
            this.slugDataGridViewTextBoxColumn1.DataPropertyName = "slug";
            this.slugDataGridViewTextBoxColumn1.HeaderText = "Slug";
            this.slugDataGridViewTextBoxColumn1.Name = "slugDataGridViewTextBoxColumn1";
            // 
            // displaynameDataGridViewTextBoxColumn1
            // 
            this.displaynameDataGridViewTextBoxColumn1.DataPropertyName = "display_name";
            this.displaynameDataGridViewTextBoxColumn1.HeaderText = "Display Name";
            this.displaynameDataGridViewTextBoxColumn1.Name = "displaynameDataGridViewTextBoxColumn1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lendables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.slugDataGridViewTextBoxColumn,
            this.displaynameDataGridViewTextBoxColumn,
            this.authoridDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.genreidDataGridViewTextBoxColumn,
            this.user_id});
            this.dataGridView2.DataSource = this.lendablesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(754, 557);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 557);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // slugDataGridViewTextBoxColumn
            // 
            this.slugDataGridViewTextBoxColumn.DataPropertyName = "slug";
            this.slugDataGridViewTextBoxColumn.HeaderText = "Slug";
            this.slugDataGridViewTextBoxColumn.Name = "slugDataGridViewTextBoxColumn";
            // 
            // displaynameDataGridViewTextBoxColumn
            // 
            this.displaynameDataGridViewTextBoxColumn.DataPropertyName = "display_name";
            this.displaynameDataGridViewTextBoxColumn.HeaderText = "Display Name";
            this.displaynameDataGridViewTextBoxColumn.Name = "displaynameDataGridViewTextBoxColumn";
            // 
            // authoridDataGridViewTextBoxColumn
            // 
            this.authoridDataGridViewTextBoxColumn.DataPropertyName = "author_id";
            this.authoridDataGridViewTextBoxColumn.DataSource = this.authorsBindingSource;
            this.authoridDataGridViewTextBoxColumn.DisplayMember = "first_name";
            this.authoridDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authoridDataGridViewTextBoxColumn.Name = "authoridDataGridViewTextBoxColumn";
            this.authoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.authoridDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource;
            this.categoryidDataGridViewTextBoxColumn.DisplayMember = "display_name";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // genreidDataGridViewTextBoxColumn
            // 
            this.genreidDataGridViewTextBoxColumn.DataPropertyName = "genre_id";
            this.genreidDataGridViewTextBoxColumn.DataSource = this.genresBindingSource;
            this.genreidDataGridViewTextBoxColumn.DisplayMember = "display_name";
            this.genreidDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreidDataGridViewTextBoxColumn.Name = "genreidDataGridViewTextBoxColumn";
            this.genreidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genreidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genreidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.DataSource = this.usersBindingSource;
            this.user_id.DisplayMember = "first_name";
            this.user_id.HeaderText = "Lended to";
            this.user_id.Name = "user_id";
            this.user_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.user_id.ValueMember = "id";
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 589);
            this.Controls.Add(this.tabControl1);
            this.Name = "LibrarianForm";
            this.ShowIcon = false;
            this.Text = "Librarian Dashboard";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private librarydbDataSet librarydbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private librarydbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource lendablesBindingSource;
        private librarydbDataSetTableAdapters.lendablesTableAdapter lendablesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private librarydbDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private librarydbDataSetTableAdapters.genresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private librarydbDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn slugDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn slugDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn slugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn authoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genreidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn user_id;
    }
}