using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hungpv_PH51204
{
    internal class NhanVien
    {
        private int ID;
        private string Ten;
        private double Luong;
        
        public NhanVien()
        {
            
        }
        public NhanVien(int iD, string ten, double luong)
        {
            ID = iD;
            Ten = ten;
            Luong = luong;
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"ID:{ID}\tTen:{Ten}\tLuong:{Luong}");
        }
        public double GetLuong()
        {
            return Luong;
        }
        public int GetID()
        {
            return ID;
        }



    }

}
