using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
    class Statistical
    {
        public string MaMon { get; set; }
        public DateTime Thoigian { get; set; } = DateTime.Now;
        public double TienMon { get; set; }
        public double GiamGia { get; set; }
        public double ThanhTien { get; set; }
        public string DiemBan { get; set; }
        public string CacMon { get; set; }

        public Statistical(string mamon, DateTime thoigian,double tienmon, double giamgia,double thanhtien,string diemban,string cacmon)
        {
            MaMon = mamon;
            Thoigian = thoigian;
            TienMon = tienmon;
            GiamGia = giamgia;
            ThanhTien = thanhtien;
            DiemBan = diemban;
            CacMon = CacMon;


        }
        public Statistical()
        {

        }
      
    }
}
