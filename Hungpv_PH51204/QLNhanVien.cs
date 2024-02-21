using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungpv_PH51204
{
    internal class QLNhanVien
    {
        public List<NhanVien> danhsachNV { get; set; }
        public QLNhanVien()
        {
            danhsachNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            int tiep = -1;
            do
            {
                Console.Write("Nhap ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nhap Ten: ");
                string ten = Console.ReadLine();
                Console.Write("Nhap Luong: ");
                double Luong = double.Parse(Console.ReadLine());
                NhanVien nhanVien = new NhanVien(id, ten, Luong);
                danhsachNV.Add(nhanVien);
                Console.Write("Ban co muon tiep tuc khong (1-co/2-khong):");
                tiep = int.Parse(Console.ReadLine());
            } while (tiep == 1);

        }
        public void XuatDS()
        {
            foreach(NhanVien nv in danhsachNV)
            {
                nv.InThongTin();
            }
        }
        public void XuatDSTheoLuong()
        {
            
            Console.Write("Vui long nhap so luong: ");
            double luong = double.Parse(Console.ReadLine());
            foreach(NhanVien item in danhsachNV)
            {
                if(luong<= item.GetLuong())
                {
                    item.InThongTin();
                }
            }
        }
        public void TimNVTheoID()
        {
            Console.Write("Vui long nhap ID muon tim: ");
            int id = int.Parse(Console.ReadLine());
            foreach(NhanVien nv in danhsachNV)
            {
                if (id == nv.GetID())
                {
                    nv.InThongTin();
                }
            }
        }
        public void KeThua()
        {

        }
    }
}
