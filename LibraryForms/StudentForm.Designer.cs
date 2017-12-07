namespace LibraryForms
{
    partial class StudentForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.messageLabel = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.allItemsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarydbDataSet = new LibraryForms.librarydbDataSet();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lendablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendablesTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.lendablesTableAdapter();
            this.authorsTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.authorsTableAdapter();
            this.categoriesTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.categoriesTableAdapter();
            this.borrowedItemListView = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.borrowedItemListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Borrowed Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.messageLabel);
            this.tabPage2.Controls.Add(this.borrowButton);
            this.tabPage2.Controls.Add(this.allItemsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(6, 512);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 2;
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(703, 512);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(75, 23);
            this.borrowButton.TabIndex = 1;
            this.borrowButton.Text = "BORROW";
            this.borrowButton.UseVisualStyleBackColor = true;
            // 
            // allItemsGridView
            // 
            this.allItemsGridView.AllowUserToAddRows = false;
            this.allItemsGridView.AllowUserToDeleteRows = false;
            this.allItemsGridView.AutoGenerateColumns = false;
            this.allItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.slugDataGridViewTextBoxColumn,
            this.displaynameDataGridViewTextBoxColumn,
            this.authoridDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.genreidDataGridViewTextBoxColumn});
            this.allItemsGridView.DataSource = this.lendablesBindingSource;
            this.allItemsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.allItemsGridView.Location = new System.Drawing.Point(3, 3);
            this.allItemsGridView.Name = "allItemsGridView";
            this.allItemsGridView.ReadOnly = true;
            this.allItemsGridView.Size = new System.Drawing.Size(778, 503);
            this.allItemsGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slugDataGridViewTextBoxColumn
            // 
            this.slugDataGridViewTextBoxColumn.DataPropertyName = "slug";
            this.slugDataGridViewTextBoxColumn.Frozen = true;
            this.slugDataGridViewTextBoxColumn.HeaderText = "Slug";
            this.slugDataGridViewTextBoxColumn.Name = "slugDataGridViewTextBoxColumn";
            this.slugDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displaynameDataGridViewTextBoxColumn
            // 
            this.displaynameDataGridViewTextBoxColumn.DataPropertyName = "display_name";
            this.displaynameDataGridViewTextBoxColumn.Frozen = true;
            this.displaynameDataGridViewTextBoxColumn.HeaderText = "Display Name";
            this.displaynameDataGridViewTextBoxColumn.Name = "displaynameDataGridViewTextBoxColumn";
            this.displaynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authoridDataGridViewTextBoxColumn
            // 
            this.authoridDataGridViewTextBoxColumn.DataPropertyName = "author_id";
            this.authoridDataGridViewTextBoxColumn.DataSource = this.authorsBindingSource;
            this.authoridDataGridViewTextBoxColumn.DisplayMember = "first_name";
            this.authoridDataGridViewTextBoxColumn.Frozen = true;
            this.authoridDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authoridDataGridViewTextBoxColumn.Name = "authoridDataGridViewTextBoxColumn";
            this.authoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.authoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.authoridDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.librarydbDataSet;
            // 
            // librarydbDataSet
            // 
            this.librarydbDataSet.DataSetName = "librarydbDataSet";
            this.librarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource;
            this.categoryidDataGridViewTextBoxColumn.DisplayMember = "display_name";
            this.categoryidDataGridViewTextBoxColumn.Frozen = true;
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.librarydbDataSet;
            // 
            // genreidDataGridViewTextBoxColumn
            // 
            this.genreidDataGridViewTextBoxColumn.DataPropertyName = "genre_id";
            this.genreidDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource1;
            this.genreidDataGridViewTextBoxColumn.DisplayMember = "display_name";
            this.genreidDataGridViewTextBoxColumn.Frozen = true;
            this.genreidDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreidDataGridViewTextBoxColumn.Name = "genreidDataGridViewTextBoxColumn";
            this.genreidDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genreidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genreidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "categories";
            this.categoriesBindingSource1.DataSource = this.librarydbDataSet;
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
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // borrowedItemListView
            // 
            this.borrowedItemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowedItemListView.Location = new System.Drawing.Point(3, 3);
            this.borrowedItemListView.Name = "borrowedItemListView";
            this.borrowedItemListView.Size = new System.Drawing.Size(778, 550);
            this.borrowedItemListView.TabIndex = 0;
            this.borrowedItemListView.UseCompatibleStateImageBehavior = false;
            this.borrowedItemListView.View = System.Windows.Forms.View.Details;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendablesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.DataGridView allItemsGridView;
        private librarydbDataSet librarydbDataSet;
        private System.Windows.Forms.BindingSource lendablesBindingSource;
        private librarydbDataSetTableAdapters.lendablesTableAdapter lendablesTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private librarydbDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private librarydbDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn authoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genreidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView borrowedItemListView;
    }
}