﻿namespace MangaRipper.Core.Models
{
    public class Chapter
    {
        public string Name { get; set; }

        public string Url { get; set; }
        public Chapter(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
