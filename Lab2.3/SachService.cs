using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    public class SachService
    {
        private List<Sach> danhSachSach = new List<Sach>();

        public bool ThemSach(Sach sach)
        {
            if (sach == null)
                return false;
            danhSachSach.Add(sach);
            return true;
        }

        public List<Sach> GetDanhSachSach()
        {
            return danhSachSach;
        }
    }
}
