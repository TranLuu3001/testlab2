using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    public class Sach
    {
        public string Id { get; set; }
        public string Ten { get; set; }
        public int SoTrang { get; set; }
        public string TenTacGia { get; set; }
        public int LanTaiBan { get; set; }

        public Sach(string id, string ten, int soTrang, string tenTacGia, int lanTaiBan)
        {
            Id = id;
            Ten = ten;
            SoTrang = soTrang;
            TenTacGia = tenTacGia;
            LanTaiBan = lanTaiBan;
        }
    }
}
