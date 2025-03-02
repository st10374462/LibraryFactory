using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    internal class UnknownBook : IBook
    {
        public string GetGenre() => "Unknown";
        public string GetAuthor() => "N/A";
        public string GetDescription() => "This book type is not recognized.";
    }
}
