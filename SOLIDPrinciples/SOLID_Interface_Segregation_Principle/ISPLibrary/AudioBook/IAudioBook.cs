using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    interface IAudioBook : ILibraryItem
    {
        public string Author { get; set; }
        public int RuntimeInMinutes { get; set; }
    }
}
