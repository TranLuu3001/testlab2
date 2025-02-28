using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    public class DiemTrungBinh
    {
        public double TinhTrungBinh(double diemToan, double diemLy, double diemHoa)
        {
            if (diemToan < 0 || diemToan > 10 || diemLy < 0 || diemLy > 10 || diemHoa < 0 || diemHoa > 10)
            {
                throw new ArgumentException("Điểm phải nằm trong khoảng từ 0 đến 10.");
            }
            return (diemToan + diemLy + diemHoa) / 3;
        }
    }
}
