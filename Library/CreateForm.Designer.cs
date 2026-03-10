using System.Threading.Tasks;

namespace Library
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            titleMaskedTextBox = new MaskedTextBox();
            authorMaskedTextBox = new MaskedTextBox();
            yearMaskedTextBox = new MaskedTextBox();
            createBookButton = new Button();
            quantityMaskedTextBox = new MaskedTextBox();
            titleLabel = new Label();
            authorLabel = new Label();
            yearLabel = new Label();
            quantityLabel = new Label();
            SuspendLayout();
            // 
            // titleMaskedTextBox
            // 
            titleMaskedTextBox.Location = new Point(3, 35);
            titleMaskedTextBox.Mask = new string('A', 255);
            titleMaskedTextBox.Name = "titleMaskedTextBox";
            titleMaskedTextBox.Size = new Size(100, 23);
            titleMaskedTextBox.TabIndex = 0;
            // 
            // authorMaskedTextBox
            // 
            authorMaskedTextBox.Location = new Point(109, 35);
            authorMaskedTextBox.Mask = new string('A', 255);
            authorMaskedTextBox.Name = "authorMaskedTextBox";
            authorMaskedTextBox.Size = new Size(100, 23);
            authorMaskedTextBox.TabIndex = 1;
            // 
            // yearMaskedTextBox
            // 
            yearMaskedTextBox.Location = new Point(215, 35);
            yearMaskedTextBox.Mask = "0000";
            yearMaskedTextBox.Name = "yearMaskedTextBox";
            yearMaskedTextBox.Size = new Size(100, 23);
            yearMaskedTextBox.TabIndex = 2;
            yearMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // createBookButton
            // 
            createBookButton.Location = new Point(148, 106);
            createBookButton.Name = "createBookButton";
            createBookButton.Size = new Size(102, 23);
            createBookButton.TabIndex = 4;
            createBookButton.Text = "Создать книгу";
            createBookButton.UseVisualStyleBackColor = true;
            // 
            // quantityMaskedTextBox
            // 
            quantityMaskedTextBox.Location = new Point(321, 35);
            quantityMaskedTextBox.Mask = "9999999999";
            quantityMaskedTextBox.Name = "quantityMaskedTextBox";
            quantityMaskedTextBox.Size = new Size(68, 23);
            quantityMaskedTextBox.TabIndex = 5;
            quantityMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(22, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(59, 15);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Название";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(137, 9);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(40, 15);
            authorLabel.TabIndex = 7;
            authorLabel.Text = "Автор";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(231, 9);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(73, 15);
            yearLabel.TabIndex = 8;
            yearLabel.Text = "Год издания";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(321, 9);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(72, 15);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Количество";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 206);
            Controls.Add(quantityLabel);
            Controls.Add(yearLabel);
            Controls.Add(authorLabel);
            Controls.Add(titleLabel);
            Controls.Add(quantityMaskedTextBox);
            Controls.Add(createBookButton);
            Controls.Add(yearMaskedTextBox);
            Controls.Add(authorMaskedTextBox);
            Controls.Add(titleMaskedTextBox);
            Name = "CreateForm";
            Text = "Создание книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox titleMaskedTextBox;
        private MaskedTextBox authorMaskedTextBox;
        private MaskedTextBox yearMaskedTextBox;
        private Button createBookButton;
        private MaskedTextBox quantityMaskedTextBox;
        private Label titleLabel;
        private Label authorLabel;
        private Label yearLabel;
        private Label quantityLabel;
    }
}