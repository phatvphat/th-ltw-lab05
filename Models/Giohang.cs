using Lab05.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab05.Models
{
    public class Giohang
    {
        DBContext dbContext = new DBContext();

        public int id { get; set; }
        [Display(Name = "Tên")]
        public string ten { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name = "Giá bán")]
        public double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int iSoluong { get; set; }
        [Display(Name = "Thành tiền")]
        public double dThanhtien {
            get { return iSoluong * gia; }
        }
        public Giohang(int id)
        {
            this.id = id;
            Rubik rubik = dbContext.Rubik.Single(s => s.id == id);
            ten = rubik.ten;
            hinh = rubik.hinh;
            gia = double.Parse(rubik.gia.ToString());
            iSoluong = 1;
        }
    }
}