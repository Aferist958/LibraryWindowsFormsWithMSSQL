using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class InfoForm : Form
    {

        private BooksRepository _booksRepository;

        public delegate void BookChange(BooksRepository bookAdded);

        public event BookChange? bookChange;

        private Guid _bookId;

        private Book? _book;

        public InfoForm(Guid bookId, BooksRepository booksRepository)
        {
            InitializeComponent();

            _booksRepository = booksRepository;
            _bookId = bookId;
            _book = _booksRepository.GetBook(_bookId);

            titleMaskedTextBox.Text = _book.Title;
            authorMaskedTextBox.Text = _book.Author;
            yearMaskedTextBox.Text = _book.YearOfPublucation.ToString();
            quantityMaskedTextBox.Text = _book.Quantity.ToString();
            issueButton.Click += issueBookButtonClick;
            returnButton.Click += reurnBookButtonClick;
            updateButton.Click += updateBookButtonClick;
            deleteButton.Click += deleteBookButtonClick;
        }

        private void updateBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _book.Title = titleMaskedTextBox.Text.Trim();
                _book.Author = authorMaskedTextBox.Text.Trim();
                _book.YearOfPublucation = int.Parse(yearMaskedTextBox.Text);
                _book.Quantity = int.Parse(quantityMaskedTextBox.Text);
                _booksRepository.UpdateBook(_book);
                MessageBox.Show("Книга успешно обновлена");
                bookChange?.Invoke(_booksRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При обновлении книги возникла ошибка");
            }
        }

        private void deleteBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _booksRepository.DeleteBook(_bookId);
                MessageBox.Show("Книга успешно удалена");
                bookChange?.Invoke(_booksRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При удалении книги возникла ошибка");
            }
        }

        private void issueBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                if (_book.Quantity > 0)
                {
                    _book.Quantity--;
                    _booksRepository.UpdateBook( _book);
                    MessageBox.Show("Книга успешно выдана");
                    bookChange?.Invoke(_booksRepository);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы не можете выдать книгу, из-за их отсутвия");
                }
            }
            catch
            {
                MessageBox.Show("При выдаче книги возникла ошибка");
            }
        }

        private void reurnBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _book.Quantity++;
                _booksRepository.UpdateBook( _book);
                MessageBox.Show("Книга успешна вернута");
                bookChange?.Invoke(_booksRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При возращение книги возникла ошибка");
            }
        }
    }
}
