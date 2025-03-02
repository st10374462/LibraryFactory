using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    internal interface IBook
    {
        string GetGenre();
        string GetAuthor();
        string GetDescription();
    }
}
