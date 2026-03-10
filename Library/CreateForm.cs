using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library; 
using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;

namespace Library
{
    public partial class CreateForm : Form
    {
        private BooksRepository _booksRepository;

        public delegate void BookAdd(BooksRepository bookAdded);

        public event BookAdd? bookAdded;
        public CreateForm(BooksRepository booksRepository)
        {
            InitializeComponent();

            _booksRepository = booksRepository;

            createBookButton.Click += createBookButtonClick;
        }

        private void createBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                var book = new Book
                {
                    Title = titleMaskedTextBox.Text.Trim(),
                    Author = authorMaskedTextBox.Text.Trim(),
                    YearOfPublucation = int.Parse(yearMaskedTextBox.Text),
                    Quantity = int.Parse(quantityMaskedTextBox.Text),
                };
                _booksRepository.AddBook(book);
                titleMaskedTextBox.Text = authorMaskedTextBox.Text = yearMaskedTextBox.Text = quantityMaskedTextBox.Text = "";
                MessageBox.Show("Книга успешно создана");
                bookAdded?.Invoke(_booksRepository);
            }
            catch 
            {
                MessageBox.Show("При создании книги возникла ошибка");
            }
        }
    }
}
