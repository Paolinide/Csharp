using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using SimpleWebScraper.Data;

namespace SimpleWebScraper.Builders
{
    class ScrapeCriteriaPartBuilder
    {
        private string _regex;
        public RegexOptions _regexOption;
        public ScrapeCriteriaPartBuilder()
        {
            SetDefaults();
        }
        private void SetDefaults()
        {
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
        }
        public ScrapeCriteriaPartBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaPartBuilder WithRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }
        public ScrapeCriteriaPart Build()
        {
            ScrapeCriteriaPart scrapeCriteriaPart = new ScrapeCriteriaPart();
            scrapeCriteriaPart.Regex = _regex;
            scrapeCriteriaPart.RegexOption = _regexOption;
            return scrapeCriteriaPart;
        }
    }
}