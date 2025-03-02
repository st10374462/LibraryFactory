using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    internal class BookFactory
    {
        public IBook returnInstance;

        public IBook GetBook(string bookType)
        {
            switch (bookType.ToLower())
            {
                case "fiction":
                    return returnInstance = new FictionBook();
                case "nonfiction":
                    return returnInstance = new NonFictionBook();
                case "reference":
                    return returnInstance = new ReferenceBook();
                default:
                    return returnInstance = new UnknownBook();
            }
        }
    }
}
