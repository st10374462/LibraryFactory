using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    internal class ReferenceBook : IBook
    {
        public string GetGenre() => "Reference";
        public string GetAuthor() => "Oxford Dictionary";
        public string GetDescription() => "A book providing factual information and definitions.";
    }
}
