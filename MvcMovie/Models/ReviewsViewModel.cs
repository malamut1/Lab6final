﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ReviewsViewModel
    {
        public int ID { get; set; }

        public List<Movie> Movies;
        public SelectList Reviews;
        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
    }
}
