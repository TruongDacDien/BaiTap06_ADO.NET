using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class GiaSuc
    {
        public string LoaiGiaSuc { get; set; }
        public int SoLuongBD {  get; set; }
        public int SoConSinhRa {  get; set; }
        public float SoLuongSua { get; set; }
        public int TongSoLuong {  get; set; }
        public string TiengKeu {  get; set; }

        public abstract int SinhCon();
        public abstract float ChoSua();
        public abstract int Tong();

        public abstract void Reset();
    }
}
