using System;
namespace essential_l1_task3
{
    public class Book
    {
        Author author;
        Content content;
        Tittle tittle;

        void InitializeBook()
        {
            this.author = new Author();
            this.tittle = new Tittle();
            this.content = new Content();
        }
        public Book()
        {
            InitializeBook();
        }
        public void Show()
        {
            this.author.Show();
            this.tittle.Show();
            this.content.Show();
        }
        public string Author
        {
            set { this.author.Text = value; }
        }
        public string Tittle
        {
            set { this.tittle.Text = value; }
        }
        public string Content
        {
            set { this.content.Text = value; }
        }

    }
}
