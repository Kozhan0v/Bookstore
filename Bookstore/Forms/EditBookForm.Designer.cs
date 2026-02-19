namespace Bookstore
{
    partial class EditBookForm
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
            components = new System.ComponentModel.Container();
            LabelTitle = new Label();
            TextBoxTitle = new TextBox();
            bookBindingSource = new BindingSource(components);
            TextBoxAuthor = new TextBox();
            LabelAuthor = new Label();
            LabelDatePublished = new Label();
            DateTimePickerDatePublished = new DateTimePicker();
            ButtonOK = new Button();
            ButtonCancel = new Button();
            TextBoxGenre = new TextBox();
            LabelGenre = new Label();
            LabelIsDiscount = new Label();
            RadioButtonIsDiscount = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(12, 26);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(124, 20);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Название книги:";
            LabelTitle.Click += label1_Click;
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.DataBindings.Add(new Binding("Text", bookBindingSource, "Title", true));
            TextBoxTitle.Location = new Point(12, 49);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(602, 27);
            TextBoxTitle.TabIndex = 1;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // TextBoxAuthor
            // 
            TextBoxAuthor.DataBindings.Add(new Binding("Text", bookBindingSource, "Author", true));
            TextBoxAuthor.Location = new Point(12, 114);
            TextBoxAuthor.Name = "TextBoxAuthor";
            TextBoxAuthor.Size = new Size(602, 27);
            TextBoxAuthor.TabIndex = 3;
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(12, 91);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(98, 20);
            LabelAuthor.TabIndex = 2;
            LabelAuthor.Text = "Автор книги:";
            // 
            // LabelDatePublished
            // 
            LabelDatePublished.AutoSize = true;
            LabelDatePublished.Location = new Point(12, 218);
            LabelDatePublished.Name = "LabelDatePublished";
            LabelDatePublished.Size = new Size(142, 20);
            LabelDatePublished.TabIndex = 4;
            LabelDatePublished.Text = "Год издания книги:";
            // 
            // DateTimePickerDatePublished
            // 
            DateTimePickerDatePublished.CustomFormat = "yyyy";
            DateTimePickerDatePublished.DataBindings.Add(new Binding("Value", bookBindingSource, "DatePublished", true));
            DateTimePickerDatePublished.Format = DateTimePickerFormat.Custom;
            DateTimePickerDatePublished.Location = new Point(15, 243);
            DateTimePickerDatePublished.Name = "DateTimePickerDatePublished";
            DateTimePickerDatePublished.Size = new Size(68, 27);
            DateTimePickerDatePublished.TabIndex = 5;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new Point(420, 337);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(94, 29);
            ButtonOK.TabIndex = 6;
            ButtonOK.Text = "&OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(520, 337);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 7;
            ButtonCancel.Text = "&Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // TextBoxGenre
            // 
            TextBoxGenre.DataBindings.Add(new Binding("Text", bookBindingSource, "Genre", true));
            TextBoxGenre.Location = new Point(12, 179);
            TextBoxGenre.Name = "TextBoxGenre";
            TextBoxGenre.Size = new Size(602, 27);
            TextBoxGenre.TabIndex = 9;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(12, 156);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(95, 20);
            LabelGenre.TabIndex = 8;
            LabelGenre.Text = "Жанр книги:";
            // 
            // LabelIsDiscount
            // 
            LabelIsDiscount.AutoSize = true;
            LabelIsDiscount.Location = new Point(12, 283);
            LabelIsDiscount.Name = "LabelIsDiscount";
            LabelIsDiscount.Size = new Size(124, 20);
            LabelIsDiscount.TabIndex = 10;
            LabelIsDiscount.Text = "Наличие скидки:";
            // 
            // RadioButtonIsDiscount
            // 
            RadioButtonIsDiscount.AutoSize = true;
            RadioButtonIsDiscount.DataBindings.Add(new Binding("Checked", bookBindingSource, "IsDiscount", true));
            RadioButtonIsDiscount.Location = new Point(18, 308);
            RadioButtonIsDiscount.Name = "RadioButtonIsDiscount";
            RadioButtonIsDiscount.Size = new Size(17, 16);
            RadioButtonIsDiscount.TabIndex = 11;
            RadioButtonIsDiscount.TabStop = true;
            RadioButtonIsDiscount.UseVisualStyleBackColor = true;
            RadioButtonIsDiscount.CheckedChanged += RadioButtonIsDiscount_CheckedChanged;
            // 
            // EditBookForm
            // 
            AcceptButton = ButtonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonCancel;
            ClientSize = new Size(626, 378);
            Controls.Add(RadioButtonIsDiscount);
            Controls.Add(LabelIsDiscount);
            Controls.Add(TextBoxGenre);
            Controls.Add(LabelGenre);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOK);
            Controls.Add(DateTimePickerDatePublished);
            Controls.Add(LabelDatePublished);
            Controls.Add(TextBoxAuthor);
            Controls.Add(LabelAuthor);
            Controls.Add(TextBoxTitle);
            Controls.Add(LabelTitle);
            Name = "EditBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBookForm";
            Load += EditBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private TextBox TextBoxTitle;
        private TextBox TextBoxAuthor;
        private Label LabelAuthor;
        private Label LabelDatePublished;
        private DateTimePicker DateTimePickerDatePublished;
        private Button ButtonOK;
        private Button ButtonCancel;
        private BindingSource bookBindingSource;
        private TextBox TextBoxGenre;
        private Label LabelGenre;
        private Label LabelIsDiscount;
        private RadioButton RadioButtonIsDiscount;
    }
}