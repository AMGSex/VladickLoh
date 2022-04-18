using System;
using System.Collections.Generic;
using System.Text;

namespace VladickLoh.Model
{
    public class EntryModel
    {
        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; }
        public bool HTTPS { get; set; }
        public string CORS { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
    }
}
