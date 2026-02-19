namespace Bookstore
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ContextMenuStripForGrid = new ContextMenuStrip(components);
            MenuItemDeleteBook = new ToolStripMenuItem();
            MenuItemEditBook = new ToolStripMenuItem();
            DataGridViewBooks = new DataGridView();
            GroupBoxAddNewBook = new GroupBox();
            TextBoxGenre = new TextBox();
            LabelGenre = new Label();
            ButtonAddBook = new Button();
            DateTimePickerDatePublished = new DateTimePicker();
            LabelDatePublished = new Label();
            TextBoxAuthor = new TextBox();
            LabelAuthor = new Label();
            TextBoxTitle = new TextBox();
            LabelTitle = new Label();
            RadioButtonIsDiscount = new RadioButton();
            LabelIsDiscountInfo = new Label();
            TextBoxBookGenreInfo = new TextBox();
            LabelBookGenreInfo = new Label();
            DateTimePickerDatePublishedInfo = new DateTimePicker();
            LabelBookDatePublishedInfo = new Label();
            TextBoxBookAuthorInfo = new TextBox();
            LabelBookAuthorInfo = new Label();
            TextBoxBookTitleInfo = new TextBox();
            LabelBookTitleInfo = new Label();
            ContextMenuStripForGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooks).BeginInit();
            GroupBoxAddNewBook.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // ContextMenuStripForGrid
            // 
            ContextMenuStripForGrid.ImageScalingSize = new Size(20, 20);
            ContextMenuStripForGrid.Items.AddRange(new ToolStripItem[] { MenuItemDeleteBook, MenuItemEditBook });
            ContextMenuStripForGrid.Name = "ContextMenuStripForGrid";
            ContextMenuStripForGrid.Size = new Size(223, 52);
            // 
            // MenuItemDeleteBook
            // 
            MenuItemDeleteBook.Name = "MenuItemDeleteBook";
            MenuItemDeleteBook.Size = new Size(222, 24);
            MenuItemDeleteBook.Text = "Удалить книгу";
            MenuItemDeleteBook.Click += MenuItemDeleteBook_Click;
            // 
            // MenuItemEditBook
            // 
            MenuItemEditBook.Name = "MenuItemEditBook";
            MenuItemEditBook.Size = new Size(222, 24);
            MenuItemEditBook.Text = "Редактировать книгу";
            MenuItemEditBook.Click += MenuItemEditBook_Click;
            // 
            // DataGridViewBooks
            // 
            DataGridViewBooks.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBooks.ContextMenuStrip = ContextMenuStripForGrid;
            DataGridViewBooks.Location = new Point(12, 12);
            DataGridViewBooks.Name = "DataGridViewBooks";
            DataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.PapayaWhip;
            dataGridViewCellStyle2.ForeColor = Color.SaddleBrown;
            DataGridViewBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewBooks.Size = new Size(845, 408);
            DataGridViewBooks.TabIndex = 1;
            // 
            // GroupBoxAddNewBook
            // 
            GroupBoxAddNewBook.Controls.Add(TextBoxGenre);
            GroupBoxAddNewBook.Controls.Add(LabelGenre);
            GroupBoxAddNewBook.Controls.Add(ButtonAddBook);
            GroupBoxAddNewBook.Controls.Add(DateTimePickerDatePublished);
            GroupBoxAddNewBook.Controls.Add(LabelDatePublished);
            GroupBoxAddNewBook.Controls.Add(TextBoxAuthor);
            GroupBoxAddNewBook.Controls.Add(LabelAuthor);
            GroupBoxAddNewBook.Controls.Add(TextBoxTitle);
            GroupBoxAddNewBook.Controls.Add(LabelTitle);
            GroupBoxAddNewBook.Location = new Point(12, 426);
            GroupBoxAddNewBook.Name = "GroupBoxAddNewBook";
            GroupBoxAddNewBook.Size = new Size(1242, 59);
            GroupBoxAddNewBook.TabIndex = 6;
            GroupBoxAddNewBook.TabStop = false;
            GroupBoxAddNewBook.Text = "Добавить новую книгу в коллекцию:";
            // 
            // TextBoxGenre
            // 
            TextBoxGenre.Location = new Point(682, 22);
            TextBoxGenre.Name = "TextBoxGenre";
            TextBoxGenre.Size = new Size(175, 27);
            TextBoxGenre.TabIndex = 8;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(630, 26);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(51, 20);
            LabelGenre.TabIndex = 7;
            LabelGenre.Text = "Жанр:";
            // 
            // ButtonAddBook
            // 
            ButtonAddBook.Location = new Point(1065, 22);
            ButtonAddBook.Name = "ButtonAddBook";
            ButtonAddBook.Size = new Size(147, 27);
            ButtonAddBook.TabIndex = 6;
            ButtonAddBook.Text = "&Добавить книгу";
            ButtonAddBook.UseVisualStyleBackColor = true;
            ButtonAddBook.Click += ButtonAddBook_Click;
            // 
            // DateTimePickerDatePublished
            // 
            DateTimePickerDatePublished.CustomFormat = "yyyy";
            DateTimePickerDatePublished.Format = DateTimePickerFormat.Custom;
            DateTimePickerDatePublished.Location = new Point(970, 22);
            DateTimePickerDatePublished.Name = "DateTimePickerDatePublished";
            DateTimePickerDatePublished.Size = new Size(66, 27);
            DateTimePickerDatePublished.TabIndex = 5;
            DateTimePickerDatePublished.ValueChanged += DateTimePickerDatePublished_ValueChanged;
            // 
            // LabelDatePublished
            // 
            LabelDatePublished.AutoSize = true;
            LabelDatePublished.Location = new Point(872, 26);
            LabelDatePublished.Name = "LabelDatePublished";
            LabelDatePublished.Size = new Size(98, 20);
            LabelDatePublished.TabIndex = 4;
            LabelDatePublished.Text = "Год издания:";
            // 
            // TextBoxAuthor
            // 
            TextBoxAuthor.Location = new Point(445, 22);
            TextBoxAuthor.Name = "TextBoxAuthor";
            TextBoxAuthor.Size = new Size(175, 27);
            TextBoxAuthor.TabIndex = 3;
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(393, 25);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(54, 20);
            LabelAuthor.TabIndex = 2;
            LabelAuthor.Text = "Автор:";
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.Location = new Point(93, 22);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(294, 27);
            TextBoxTitle.TabIndex = 1;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(16, 25);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(80, 20);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Название:";
            // 
            // RadioButtonIsDiscount
            // 
            RadioButtonIsDiscount.AutoSize = true;
            RadioButtonIsDiscount.Location = new Point(890, 350);
            RadioButtonIsDiscount.Name = "RadioButtonIsDiscount";
            RadioButtonIsDiscount.Size = new Size(17, 16);
            RadioButtonIsDiscount.TabIndex = 21;
            RadioButtonIsDiscount.TabStop = true;
            RadioButtonIsDiscount.UseVisualStyleBackColor = true;
            // 
            // LabelIsDiscountInfo
            // 
            LabelIsDiscountInfo.AutoSize = true;
            LabelIsDiscountInfo.Location = new Point(884, 325);
            LabelIsDiscountInfo.Name = "LabelIsDiscountInfo";
            LabelIsDiscountInfo.Size = new Size(124, 20);
            LabelIsDiscountInfo.TabIndex = 20;
            LabelIsDiscountInfo.Text = "Наличие скидки:";
            // 
            // TextBoxBookGenreInfo
            // 
            TextBoxBookGenreInfo.Location = new Point(884, 221);
            TextBoxBookGenreInfo.Name = "TextBoxBookGenreInfo";
            TextBoxBookGenreInfo.Size = new Size(370, 27);
            TextBoxBookGenreInfo.TabIndex = 19;
            TextBoxBookGenreInfo.TextChanged += textBox1_TextChanged;
            // 
            // LabelBookGenreInfo
            // 
            LabelBookGenreInfo.AutoSize = true;
            LabelBookGenreInfo.Location = new Point(884, 198);
            LabelBookGenreInfo.Name = "LabelBookGenreInfo";
            LabelBookGenreInfo.Size = new Size(95, 20);
            LabelBookGenreInfo.TabIndex = 18;
            LabelBookGenreInfo.Text = "Жанр книги:";
            // 
            // DateTimePickerDatePublishedInfo
            // 
            DateTimePickerDatePublishedInfo.CustomFormat = "yyyy";
            DateTimePickerDatePublishedInfo.Format = DateTimePickerFormat.Custom;
            DateTimePickerDatePublishedInfo.Location = new Point(887, 285);
            DateTimePickerDatePublishedInfo.Name = "DateTimePickerDatePublishedInfo";
            DateTimePickerDatePublishedInfo.Size = new Size(68, 27);
            DateTimePickerDatePublishedInfo.TabIndex = 17;
            // 
            // LabelBookDatePublishedInfo
            // 
            LabelBookDatePublishedInfo.AutoSize = true;
            LabelBookDatePublishedInfo.Location = new Point(884, 260);
            LabelBookDatePublishedInfo.Name = "LabelBookDatePublishedInfo";
            LabelBookDatePublishedInfo.Size = new Size(142, 20);
            LabelBookDatePublishedInfo.TabIndex = 16;
            LabelBookDatePublishedInfo.Text = "Год издания книги:";
            // 
            // TextBoxBookAuthorInfo
            // 
            TextBoxBookAuthorInfo.Location = new Point(884, 156);
            TextBoxBookAuthorInfo.Name = "TextBoxBookAuthorInfo";
            TextBoxBookAuthorInfo.Size = new Size(370, 27);
            TextBoxBookAuthorInfo.TabIndex = 15;
            // 
            // LabelBookAuthorInfo
            // 
            LabelBookAuthorInfo.AutoSize = true;
            LabelBookAuthorInfo.Location = new Point(884, 133);
            LabelBookAuthorInfo.Name = "LabelBookAuthorInfo";
            LabelBookAuthorInfo.Size = new Size(98, 20);
            LabelBookAuthorInfo.TabIndex = 14;
            LabelBookAuthorInfo.Text = "Автор книги:";
            // 
            // TextBoxBookTitleInfo
            // 
            TextBoxBookTitleInfo.Location = new Point(884, 91);
            TextBoxBookTitleInfo.Name = "TextBoxBookTitleInfo";
            TextBoxBookTitleInfo.Size = new Size(370, 27);
            TextBoxBookTitleInfo.TabIndex = 13;
            // 
            // LabelBookTitleInfo
            // 
            LabelBookTitleInfo.AutoSize = true;
            LabelBookTitleInfo.Location = new Point(884, 68);
            LabelBookTitleInfo.Name = "LabelBookTitleInfo";
            LabelBookTitleInfo.Size = new Size(124, 20);
            LabelBookTitleInfo.TabIndex = 12;
            LabelBookTitleInfo.Text = "Название книги:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 492);
            Controls.Add(RadioButtonIsDiscount);
            Controls.Add(LabelIsDiscountInfo);
            Controls.Add(GroupBoxAddNewBook);
            Controls.Add(TextBoxBookGenreInfo);
            Controls.Add(LabelBookGenreInfo);
            Controls.Add(DataGridViewBooks);
            Controls.Add(DateTimePickerDatePublishedInfo);
            Controls.Add(TextBoxBookTitleInfo);
            Controls.Add(LabelBookDatePublishedInfo);
            Controls.Add(LabelBookTitleInfo);
            Controls.Add(TextBoxBookAuthorInfo);
            Controls.Add(LabelBookAuthorInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ContextMenuStripForGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooks).EndInit();
            GroupBoxAddNewBook.ResumeLayout(false);
            GroupBoxAddNewBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip ContextMenuStripForGrid;
        private ToolStripMenuItem MenuItemDeleteBook;
        private ToolStripMenuItem MenuItemEditBook;
        private DataGridView DataGridViewBooks;
        private GroupBox GroupBoxAddNewBook;
        private Label LabelTitle;
        private Label LabelAuthor;
        private TextBox TextBoxTitle;
        private TextBox TextBoxAuthor;
        private DateTimePicker DateTimePickerDatePublished;
        private Label LabelDatePublished;
        private Button ButtonAddBook;
        private TextBox TextBoxGenre;
        private Label LabelGenre;
        private RadioButton RadioButtonIsDiscount;
        private Label LabelIsDiscountInfo;
        private TextBox TextBoxBookGenreInfo;
        private Label LabelBookGenreInfo;
        private DateTimePicker DateTimePickerDatePublishedInfo;
        private Label LabelBookDatePublishedInfo;
        private TextBox TextBoxBookAuthorInfo;
        private Label LabelBookAuthorInfo;
        private TextBox TextBoxBookTitleInfo;
        private Label LabelBookTitleInfo;
    }
}
