using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    internal class FictionBook : IBook
    {
        public string GetGenre() => "Fiction";
        public string GetAuthor() => "J.K. Rowling";
        public string GetDescription() => "A book filled with imaginative storytelling.";
    }
}
