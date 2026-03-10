using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;

namespace Library
{
    public partial class MainForm : Form
    {
        private BooksRepository _booksRepository;
        public MainForm()
        {
            InitializeComponent();

            var context = new AppDbContext();
            _booksRepository = new BooksRepository(context);
            LoadData(_booksRepository);

            searchButton.Click += searchBookButtonClick;
            clearSearchButton.Click += clearSearchButtonClick;
            createButton.Click += createButtonClick;
            bookDataGridView.CellClick += bookDataGridViewCellClick;
        }

        private void LoadData(BooksRepository booksRepository)
        {
            bookDataGridView.Rows.Clear();
            foreach (var book in booksRepository.GetAllBooks())
            {
                bookDataGridView.Rows.Add(book.Id, book.Title, book.Author, book.YearOfPublucation, book.Quantity);
            }
        }

        private void createButtonClick(object? sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm(_booksRepository);
            createForm.bookAdded += LoadData;
            createForm.ShowDialog();
        }

        private void bookDataGridViewCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedBookRow = bookDataGridView.Rows[e.RowIndex];
                InfoForm infoForm = new InfoForm((Guid)clickedBookRow.Cells["Id"].Value, _booksRepository);
                infoForm.bookChange += LoadData;
                infoForm.ShowDialog();
            }
        }

        private void searchBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                List<Book> searchResult = new List<Book>(_booksRepository.GetAllBooks().Count);
                List<Book> books = _booksRepository.GetAllBooks();
                if (!string.IsNullOrEmpty(searchTextBox.Text)) 
                {
                    searchResult.AddRange(books
                        .Where(b => b.Title.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase)));
                    searchResult.AddRange(books
                        .Where(b => b.Author.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase) && !searchResult.Any(a => a.Author.Contains(b.Author))));
                    if (int.TryParse(searchTextBox.Text, out int year))
                    {
                        searchResult.AddRange(books
                            .Where(b => b.YearOfPublucation == year));
                    }
                    searchResult = searchResult
                        .DistinctBy(b => b.Id)
                        .ToList();
                    bookDataGridView.Rows.Clear();
                    foreach (Book book in searchResult)
                    {
                        bookDataGridView.Rows.Add(book.Id, book.Title, book.Author, book.YearOfPublucation, book.Quantity);
                    }
                }
            }
            catch
            {
                MessageBox.Show("При поиске была обнаружена ошибка");
            }
        }

        private void clearSearchButtonClick(object? sender, EventArgs e)
        {
            searchTextBox.Text = "";
            LoadData(_booksRepository);
        }
    }
}
