using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTWeb_Cinema_0307.Models.CinemaEntities
{
    public class ShowTime
    {
        public int Id { get; set; }
        [Display(Name="Giờ")]
        [Required(ErrorMessage ="Vui lòng nhập thời gian")]
        public string Time { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}