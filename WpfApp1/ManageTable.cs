using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
    class ManageTable
    {
        public string Id { get; set; }
        public string TênBan { get; set; }
        public string TrangThai { get; set; }

        public ManageTable(string id, string tenban, string trangthai)
        {
            Id = id;
            TênBan = tenban;
            TrangThai = trangthai;
        }

        public ManageTable()
        {
        }
    }
}
