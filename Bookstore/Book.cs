using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime DatePublished { get; set; }
        public string YearPublished { get { return DatePublished.ToString("yyyy"); } }
        public bool IsDiscount { get; set; }

        public Book(int id, string title, string author, string genre, DateTime datePublished, bool isDiscount)
        {
            ID = id;
            Title = title;
            Author = author;
            Genre = genre;
            DatePublished = datePublished;
            IsDiscount = isDiscount;
        }

        public override string ToString()
        {
            if (IsDiscount == true)
            {
                return $"Название: \"{Title}\". \nАвтор: \"{Author}\". Жанр: \"{Genre}\". Год публикации: \"{YearPublished}\". \nЕсть скидка";
            }
            return $"Название: \"{Title}\". \nАвтор: \"{Author}\". Жанр: \"{Genre}\". Год публикации: \"{YearPublished}\". \nСкидок нет";
        }
    }
}
