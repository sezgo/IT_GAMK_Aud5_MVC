﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_GAMK_Aud5_MVC.Models
{
    public class Client
    {
        public Client()
        {
            movies = new List<Movie>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MovieCard { get; set; }
        [Range(1,99)]
        public int Age { get; set; }
        public virtual ICollection<Movie> movies { get; set; }
    }
}