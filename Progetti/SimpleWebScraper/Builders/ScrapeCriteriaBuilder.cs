using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using SimpleWebScraper.Data;

namespace SimpleWebScraper.Builders
{
    class ScrapeCriteriaBuilder
    {
        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefault();
        }

        private void SetDefault()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        public ScrapeCriteriaBuilder WithData(string data)
        {
            _data = data;
            return this;
        }
        public ScrapeCriteriaBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaBuilder WithRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }
        public ScrapeCriteriaBuilder WithPart(ScrapeCriteriaPart scripCriteriaPart)
        {
            _parts.Add(scripCriteriaPart);
            return this;
        }
        public ScrapeCriteria Build(){
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = _data;
            scrapeCriteria.Regex = _regex;
            scrapeCriteria.RegexOption = _regexOption;
            scrapeCriteria.Parts = _parts;
            return scrapeCriteria;
        }
    }
}