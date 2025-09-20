using System;

namespace MyMonkeyApp.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public int Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string AsciiArt { get; set; } // 시각적 효과용 (선택)
    }
}
