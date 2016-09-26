using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Movie
    {
        public string Title = "";
        public string Category = "";
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        
     

        public static implicit operator string(Movie v)
        {
            throw new NotImplementedException();
        }
    }
}
