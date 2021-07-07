using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTWeb_Cinema_0307.Models.CinemaEntities
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name="Tên phim")]
        public string Name { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}