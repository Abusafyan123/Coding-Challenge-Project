using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.ViewModel
{
    public class QuoteAuthorViewModel
    {
        public QuoteAuthorViewModel()
        {
            results = new List<Result>();
        }
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public string _id { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public List<string> tags { get; set; }
        public string authorSlug { get; set; }
        public int length { get; set; }
        public string dateAdded { get; set; }
        public string dateModified { get; set; }
        public string type { get; set; }
    }
}
