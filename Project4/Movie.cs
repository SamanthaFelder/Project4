﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Movie
    {
       
        public List<Genre> Genres { get; set; }
        public List<Member> Members { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Length { get; set; }
        public double Rating { get; set; }
        public string Image { get; set; }
        
        public Movie()
        {
            Genres = new List<Genre>();
            Members = new List<Member>();
        }
    }
}
