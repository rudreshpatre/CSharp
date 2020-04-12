using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
