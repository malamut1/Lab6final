﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;


namespace MvcMovie.Models
{
    public class MovieReview
    {
        public MovieGenreViewModel MGenre { get; set; }
        public ReviewList MReview { get; set; }

    }
}
