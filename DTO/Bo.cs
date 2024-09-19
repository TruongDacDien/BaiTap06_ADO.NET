using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bo: GiaSuc
    {
        public Bo()
        {
            LoaiGiaSuc = "Bo";
            SoLuongBD = 0;
            SoConSinhRa = 0;
            SoLuongSua = 0;
            TongSoLuong = 0;
            TiengKeu = "Moo Moo Moo!";
        }

        public override int SinhCon()
        {
            if (SoLuongBD > 0)
            {
                SoConSinhRa = 0;
                Random random = new Random();

                for (int i = 1; i <= SoLuongBD; i++)
                {
                    int min = 1;
                    int max = 2;
                    int x = random.Next(min, max + 1);
                    SoConSinhRa += x;
                }
            }
            else
            {
                SoConSinhRa = 0;
            }

            return SoConSinhRa;
        }

        public override float ChoSua()
        {
            if (SoLuongBD > 0)
            {
                Random random = new Random();
                float min = 0.0f;
                float max = 20.0f;
                float x = (float)(random.NextDouble() * (max - min) + min);
                SoLuongSua += x;
            }
            else
            {
                SoLuongSua = 0;
            }
            return SoLuongSua;
        }

        public override int Tong()
        {
            return TongSoLuong = SoLuongBD + SoConSinhRa;
        }

        public override void Reset()
        {
            SoLuongBD = 0;
            SoConSinhRa = 0;
            SoLuongSua = 0;
            TongSoLuong = 0;
        }
    }
}
