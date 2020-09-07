using System;
using System.Runtime.CompilerServices;

namespace PersonalLibrary.Data.models
{
    public class BookReview
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }
        public Book Book { get; set; }
    }
}