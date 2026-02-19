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
            TextBoxAuthor = new TextBox();
            LabelAuthor = new Label();
            LabelDatePublished = new Label();
            DateTimePickerDatePublished = new DateTimePicker();
            ButtonOK = new Button();
            ButtonCancel = new Button();
            bookBindingSource = new BindingSource(components);
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
            LabelDatePublished.Location = new Point(12, 153);
            LabelDatePublished.Name = "LabelDatePublished";
            LabelDatePublished.Size = new Size(124, 20);
            LabelDatePublished.TabIndex = 4;
            LabelDatePublished.Text = "Название книги:";
            // 
            // DateTimePickerDatePublished
            // 
            DateTimePickerDatePublished.CustomFormat = "yyyy";
            DateTimePickerDatePublished.DataBindings.Add(new Binding("Value", bookBindingSource, "DatePublished", true));
            DateTimePickerDatePublished.Format = DateTimePickerFormat.Custom;
            DateTimePickerDatePublished.Location = new Point(12, 178);
            DateTimePickerDatePublished.Name = "DateTimePickerDatePublished";
            DateTimePickerDatePublished.Size = new Size(68, 27);
            DateTimePickerDatePublished.TabIndex = 5;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new Point(420, 298);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(94, 29);
            ButtonOK.TabIndex = 6;
            ButtonOK.Text = "&OK";
            ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(520, 298);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 7;
            ButtonCancel.Text = "&Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // EditBookForm
            // 
            AcceptButton = ButtonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonCancel;
            ClientSize = new Size(626, 339);
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
    }
}