using System;
using System.IO;
using System.Xml.Serialization;

namespace Task
{
    [Serializable()]
    public class Book  // Наш класс для того, чтобы считывать книги из файла
    {
        //пустой коструктор.
        public Book() 
        {

        }

        //Поля класса
        public Book(string title, string author, string category, string price, string year)
        {

            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.Price = price;
            this.Year = year;

        }
        //Геттеры, сеттеры класса
        //Title
        [System.Xml.Serialization.XmlElement("title")]
        public string Title { get; set; }
        //Author
        [System.Xml.Serialization.XmlElement("author")]
        public string Author { get; set; }
        //Category
        [System.Xml.Serialization.XmlElement("category")]
        public string Category { get; set; }
        //Price
        [System.Xml.Serialization.XmlElement("price")]
        public string Price { get; set; }
        //
        [System.Xml.Serialization.XmlElement("year")]
        public string Year { get; set; }

    }

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("bookstore")]
    public class BookCollection
    {
        [XmlArray("Books")]
        [XmlArrayItem("Book", typeof(Book))]
        public Book[] Book { get; set; }
    }

}
