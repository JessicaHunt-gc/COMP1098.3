using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_L5
{
    public class Library : ISerializable
    {
        public List<Book> Books;
        public List<Movie> Movies;
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Books", Books, typeof(List<Book>));
            info.AddValue("Movies", Movies, typeof(List<Movie>));
        }

        public Library(SerializationInfo info, StreamingContext context)
        {
            Books = (List<Book>)info.GetValue("Books", typeof(List<Book>));
            Movies = (List<Movie>)info.GetValue("Movies", typeof(List<Movie>));
        }
        public Library() { }
    }
}