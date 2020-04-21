using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._15
{
    class GiaoVien:Person
    {
        int _SoGioGiang;

        public int SoGioGiang { get => _SoGioGiang; set => _SoGioGiang = value; }

        public GiaoVien(string hoTen, string gioiTinh, int namSinh, string diaChi, int soGioGiang):base( hoTen,  gioiTinh,  namSinh,  diaChi)
        {

            SoGioGiang = soGioGiang;
        }

        public override string ToString()
        {

            return  String.Format("{0}\t{1}\t{2}\t{3}\t{4}", this.HoTen, this.GioiTinh, this.NamSinh, this.DiaChi, this.SoGioGiang); 
        }
    }
}
