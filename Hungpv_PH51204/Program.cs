using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungpv_PH51204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            int chon;
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.Nhap 1 hoac nhieu nhan vien");
                Console.WriteLine("2.Xuat danh sach nhan vien");
                Console.WriteLine("3.Xuat danh sach cac nhan vien co tien luong lon hon so tien ma nguoi dung nhap");
                Console.WriteLine("4.Tim nhan vien theo ma ID");
                Console.WriteLine("5.Ke thua");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("------------------------------------");
                Console.Write("Moi ban chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        {
                            qLNhanVien.NhapDS();
                            break;
                        }
                    case 2:
                        {
                            qLNhanVien.XuatDS();
                            break;
                        }
                    case 3:
                        {
                            qLNhanVien.XuatDSTheoLuong();
                            break;
                        }
                    case 4:
                        {
                            qLNhanVien.TimNVTheoID();
                            break;
                        }
                    case 5:
                        {
                            qLNhanVien.KeThua();
                            break;
                        }
                    
                }
            } while (chon != 0);
        }
        
    }
}
