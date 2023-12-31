﻿using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class Neighbor
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; } = "";
        public string URL { get; set; } = "";
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string ImgURL { get; set; } = "";
    }
}
