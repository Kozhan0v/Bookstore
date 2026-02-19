using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Bookstore
{
    public partial class MainForm : Form
    {
        List<Book> _books = new List<Book>();
        private bool _cancelContextMenu = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitBooksData()
        {
            StreamReader authorsFile = new StreamReader("../../../Sources/Authors.txt");
            StreamReader genresFile = new StreamReader("../../../Sources/Genres.txt");
            StreamReader booksFile = new StreamReader("../../../Sources/Books.txt");

            var authorLine = authorsFile.ReadLine();
            var genreLine = genresFile.ReadLine();
            var bookLine = booksFile.ReadLine();

            List<string> authors = new List<string>();
            List<string> genres = new List<string>();

            while (authorLine is not null)
            {
                var authorArray = authorLine.Split(". ");
                var author = authorArray[1];
                authors.Add(author);

                authorLine = authorsFile.ReadLine();
            }
            while (genreLine is not null)
            {
                var genreArray = genreLine.Split(". ");
                var genre = genreArray[1];
                genres.Add(genre);

                genreLine = genresFile.ReadLine();
            }

            while (bookLine is not null)
            {
                bookLine = bookLine.Replace(',', '.');
                var bookItems = bookLine.Split(". ");

                int ID = int.Parse(bookItems[0]);
                string title = bookItems[1];
                int numberOfAuthor = int.Parse(bookItems[2]) - 1;
                int numberOfGenre = int.Parse(bookItems[3]) - 1;
                int yearPublished = int.Parse(bookItems[4]);
                string isDiscountString = bookItems[5];
                bool isDiscount = false;

                if (isDiscountString == "true")
                {
                    isDiscount = true;
                }

                _books.Add(new Book(ID, title, authors[numberOfAuthor], genres[numberOfGenre], new DateTime(yearPublished, 1, 1), isDiscount));

                bookLine = booksFile.ReadLine();
            }
        }

        private void DataGridViewLoad()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("Название", typeof(string));
            table.Columns.Add("Автор", typeof(string));
            table.Columns.Add("Жанр", typeof(string));
            table.Columns.Add("Год выпуска", typeof(string));
            table.Columns.Add("Наличие скидки", typeof(bool));

            foreach (var book in _books)
            {
                table.Rows.Add(book.ID, book.Title, book.Author, book.Genre, book.YearPublished, book.IsDiscount);
            }

            DataGridViewBooks.DataSource = table;
        }

        private void UpdateBooksListDetails()
        {
            DataGridViewSelectedRowCollection selectedRow = DataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow row in selectedRow)
            {
                int rowIndex = row.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                TextBoxBookTitleInfo.Text = _books[rowIndex].Title;
                TextBoxBookAuthorInfo.Text = _books[rowIndex].Author;
                TextBoxBookGenreInfo.Text = _books[rowIndex].Genre;
                DateTimePickerDatePublished.Value = _books[rowIndex].DatePublished;
                RadioButtonIsDiscount.Checked = _books[rowIndex].IsDiscount;
            }
        }

        private void RefreshGridAndBookDetails()
        {
            DataGridViewLoad();
            UpdateBooksListDetails();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerDatePublished_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitBooksData();
            RefreshGridAndBookDetails();
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            var id = _books[_books.Count - 1].ID + 1;
            var title = TextBoxTitle.Text;
            var author = TextBoxAuthor.Text;
            var genre = TextBoxGenre.Text;
            var datePublished = DateTimePickerDatePublished.Value;

            _books.Add(new Book(id, title, author, genre, datePublished, false));
            RefreshGridAndBookDetails();

            TextBoxTitle.Text = "";
            TextBoxAuthor.Text = "";
            DateTimePickerDatePublished.Value = DateTime.Now;

            TextBoxTitle.Focus();
        }

        private void MenuItemDeleteBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                int rowIndex = row.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                _books.RemoveAt(rowIndex);
            }

            RefreshGridAndBookDetails();
        }

        private void MenuItemEditBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                int rowIndex = row.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                EditBookForm editBookForm = new EditBookForm();
                editBookForm.EditedBook = _books[rowIndex];
                editBookForm.UpdateBookEvent += editBookForm_UpdateBookEvent;
                editBookForm.Show();
            }
        }

        private void editBookForm_UpdateBookEvent(Book updatedBook)
        {
            RefreshGridAndBookDetails();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
