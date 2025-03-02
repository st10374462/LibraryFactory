using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    internal class NonFictionBook : IBook
    {
        public string GetGenre() => "Non-Fiction";
        public string GetAuthor() => "Malcolm Gladwell";
        public string GetDescription() => "A book based on real events and research.";
    }
}
