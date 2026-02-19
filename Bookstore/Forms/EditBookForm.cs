using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class EditBookForm : Form
    {
        public Book EditedBook { get; set; }

        public delegate void DelegateUpdateBook(Book updatedBook);

        public event DelegateUpdateBook UpdateBookEvent;

        public EditBookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            TextBoxTitle.Text = EditedBook.Title;
            TextBoxAuthor.Text = EditedBook.Author;
            TextBoxGenre.Text = EditedBook.Genre;
            DateTimePickerDatePublished.Value = EditedBook.DatePublished;
            RadioButtonIsDiscount.Checked = EditedBook.IsDiscount;
        }

        private void RadioButtonIsDiscount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            EditedBook.Title = TextBoxTitle.Text;
            EditedBook.Author = TextBoxAuthor.Text;
            EditedBook.Genre = TextBoxGenre.Text;
            EditedBook.DatePublished = DateTimePickerDatePublished.Value;
            EditedBook.IsDiscount = RadioButtonIsDiscount.Checked;

            UpdateBookEvent?.Invoke(EditedBook);

            Close();
        }
    }
}
