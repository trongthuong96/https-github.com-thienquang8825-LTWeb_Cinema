using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTWeb_Cinema_0307.Models.CinemaEntities
{
    public class Cinema
    {
        public int Id { get; set; }
        [Display(Name = "Tên rạp")]
        public string Name { get; set; }
        [Display(Name = "Miêu tả")]
        public string Description { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}