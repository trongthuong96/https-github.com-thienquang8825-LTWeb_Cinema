using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTWeb_Cinema_0307.Models.CinemaEntities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        //quan hệ one-to-many - 1 customer có thể đặt vé nhiều lần
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        //tạo khóa ngoại với table Seat - mỗi lần đặt chỉ được đặt 1 seat
        [ForeignKey("Seat")]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        //tạo khóa ngoại với table Show - mỗi lần đặt chỉ được đặt 1 show
        [ForeignKey("Show")]
        public int ShowId { get; set; }
        public Show Show { get; set; }
    }
}