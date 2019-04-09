using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SimpleWebScraper.Data
{
    class ScrapeCriteriaPart
    {
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
    }
}