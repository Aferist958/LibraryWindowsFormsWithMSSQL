namespace Library
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            helpProvider1 = new HelpProvider();
            createButton = new Button();
            bookDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            titleColumn = new DataGridViewTextBoxColumn();
            authorColumn = new DataGridViewTextBoxColumn();
            yearColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            searchTextBox = new TextBox();
            searchButton = new Button();
            clearSearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 377);
            createButton.Name = "createButton";
            createButton.Size = new Size(158, 23);
            createButton.TabIndex = 0;
            createButton.Text = "Создать книгу";
            createButton.UseVisualStyleBackColor = true;
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, titleColumn, authorColumn, yearColumn, quantityColumn });
            bookDataGridView.Location = new Point(12, 41);
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.Size = new Size(445, 330);
            bookDataGridView.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // titleColumn
            // 
            titleColumn.HeaderText = "Название";
            titleColumn.Name = "titleColumn";
            titleColumn.ReadOnly = true;
            // 
            // authorColumn
            // 
            authorColumn.HeaderText = "Автор";
            authorColumn.Name = "authorColumn";
            authorColumn.ReadOnly = true;
            // 
            // yearColumn
            // 
            yearColumn.HeaderText = "Год публикации";
            yearColumn.Name = "yearColumn";
            yearColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            quantityColumn.HeaderText = "Количество";
            quantityColumn.Name = "quantityColumn";
            quantityColumn.ReadOnly = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(204, 23);
            searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(222, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Location = new Point(303, 12);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(113, 23);
            clearSearchButton.TabIndex = 4;
            clearSearchButton.Text = "Очистить поиск";
            clearSearchButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(clearSearchButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(bookDataGridView);
            Controls.Add(createButton);
            Name = "MainForm";
            Text = "Книги";
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private Button createButton;
        private DataGridView bookDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn titleColumn;
        private DataGridViewTextBoxColumn authorColumn;
        private DataGridViewTextBoxColumn yearColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button clearSearchButton;
    }
}
