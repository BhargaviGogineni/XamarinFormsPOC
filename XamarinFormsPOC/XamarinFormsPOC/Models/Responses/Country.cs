using System;
using System.Collections.Generic;
using PropertyChanged;

namespace XamarinFormsPOC.Models.Response
{
    [AddINotifyPropertyChangedInterface]
    public class Country
    {
        public string title { get; set; }
        public List<Species> rows { get; set; }
    }

    [AddINotifyPropertyChangedInterface]
    public class Species
    {
        public string title { get; set; }
        public string description { get; set; }
        public string imageHref { get; set; }
    }
}
