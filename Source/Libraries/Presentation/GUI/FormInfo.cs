﻿using Entities;
using System;
using System.Windows.Forms;

namespace Libraries.GUI
{
    public partial class FormInfo : Form
    {
        public int Id = 0;
        public delegate void Insert(BookEntiy book);
        public event Insert OnInsert = null;
        public delegate void Update(BookEntiy book);
        public event Update OnUpdate = null;
        public FormInfo()
        {
            InitializeComponent();
        }
        public FormInfo(BookEntiy book)
        {
            InitializeComponent();
            Id = book.Id;
            textAuthor.Text = book.Author;
            textName.Text = book.Name;
            richTextNote.Text = book.Note;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookEntiy book = GetBookInfo();

            if (OnInsert != null)
            {
                OnInsert(book);
            }
            if (OnUpdate != null)
            {
                OnUpdate(book);
            }
            this.Close();
        }

        private BookEntiy GetBookInfo()
        {
            BookEntiy book = new BookEntiy();
            book.Id = Id;
            book.Name = textName.Text;
            book.Author = textAuthor.Text;
            book.Note = richTextNote.Text;

            return book;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
