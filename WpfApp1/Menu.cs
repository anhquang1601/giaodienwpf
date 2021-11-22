using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
    class Menu
    {
        public string MaMon { get; set; }
        public String TenMon { get; set; }
        public string MaLoai { get; set; }
        public double DonGia { get; set; }
        public string DVT { get; set; }

        public Menu(string mamon, string tenmon, string maloai,double dongia,string dvt)
        {
            MaMon = mamon;
            TenMon = tenmon;
            MaLoai = maloai;
            DonGia = dongia;
            DVT = dvt;
           
         
        }

        public Menu()
        {
        }
    }
}
