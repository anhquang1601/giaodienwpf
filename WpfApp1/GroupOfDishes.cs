using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
    class GroupOfDishes
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MauSac { get; set; }

        public GroupOfDishes(string maloai, string tenloai, string mausac)
        {
            MaLoai = maloai;
            TenLoai = tenloai;
            MauSac = mausac;
        }

        public GroupOfDishes()
        {
        }
    }
}
