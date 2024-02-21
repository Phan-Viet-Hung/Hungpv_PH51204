using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungpv_PH51204
{
    internal class NhanVienPartTime : NhanVien
    {
        private double SoGioLamViec { get; set; }
        public NhanVienPartTime()
        {
            
        }
        public NhanVienPartTime(double soGioLamViec)
        {
            SoGioLamViec = soGioLamViec;
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.Write("Vui long nhap so gio lam viec cua nhan vien: ");
            SoGioLamViec = double.Parse(Console.ReadLine());
            
            
        }
    }
}
