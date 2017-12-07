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
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarydbDataSet = new LibraryForms.librarydbDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lendablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendablesTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.lendablesTableAdapter();
            this.authorsTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.authorsTableAdapter();
            this.categoriesTableAdapter = new LibraryForms.librarydbDataSetTableAdapters.categoriesTableAdapter();
            this.borrowedItemListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultsListView = new System.Windows.Forms.ListView();
            this.searchLendableButton = new System.Windows.Forms.Button();
            this.searchValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendablesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.searchLendableButton);
            this.tabPage2.Controls.Add(this.searchValueTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.messageLabel);
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
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.librarydbDataSet;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultsListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 468);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTS";
            // 
            // resultsListView
            // 
            this.resultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsListView.Location = new System.Drawing.Point(3, 16);
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(772, 449);
            this.resultsListView.TabIndex = 0;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.View = System.Windows.Forms.View.Details;
            // 
            // searchLendableButton
            // 
            this.searchLendableButton.Location = new System.Drawing.Point(679, 61);
            this.searchLendableButton.Name = "searchLendableButton";
            this.searchLendableButton.Size = new System.Drawing.Size(75, 23);
            this.searchLendableButton.TabIndex = 12;
            this.searchLendableButton.Text = "SEARCH";
            this.searchLendableButton.UseVisualStyleBackColor = true;
            this.searchLendableButton.Click += new System.EventHandler(this.searchLendableButton_Click);
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Location = new System.Drawing.Point(6, 63);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(667, 20);
            this.searchValueTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SEARCH FOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "very";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADVANCED SEARCH";
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
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendablesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label messageLabel;
        private librarydbDataSet librarydbDataSet;
        private System.Windows.Forms.BindingSource lendablesBindingSource;
        private librarydbDataSetTableAdapters.lendablesTableAdapter lendablesTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private librarydbDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private librarydbDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.ListView borrowedItemListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView resultsListView;
        private System.Windows.Forms.Button searchLendableButton;
        private System.Windows.Forms.TextBox searchValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}