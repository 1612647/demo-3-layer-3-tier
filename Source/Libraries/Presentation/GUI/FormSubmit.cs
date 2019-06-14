using Entities;
using System;

using System.Windows.Forms;

namespace Libraries.GUI
{
    public partial class FormSubmit : Form
    {
        public FormSubmit()
        {
            InitializeComponent();
        }
        public int Id = 0;
        public delegate void Delete(BookEntiy book);
        public event Delete OnDelete = null;
        public FormSubmit(BookEntiy book)
        {
            InitializeComponent();
            Id = book.Id;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BookEntiy book = GetBookInfo();

            if (OnDelete != null)
            {
                OnDelete(book);
            }
            this.Close();
        }

        private BookEntiy GetBookInfo()
        {
            BookEntiy book = new BookEntiy();
            book.Id = Id;

            return book;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
