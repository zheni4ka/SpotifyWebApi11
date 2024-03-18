﻿using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class CreateTrackModel
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public double Rating { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public int CountOfListening { get; set; }
        public string ImgUrl { get; set; }
    }
}
