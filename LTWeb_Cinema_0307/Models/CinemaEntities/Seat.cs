using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTWeb_Cinema_0307.Models.CinemaEntities
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Số ghế")]
        public int SeatNo { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
        [Display(Name = "Giá")]
        public double Price { get; set; }

        //một seat có thể được đặt bởi nhiều reservation
        public ICollection<Reservation> Reservations { get; set; }
    }
}