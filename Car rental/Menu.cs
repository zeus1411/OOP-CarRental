using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    public class Menu
    {
        public Menu() { }
        public void ShowListXe()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("-------------DANH SACH CAC XE HIEN CO-----------------");
            Console.WriteLine();
            Console.WriteLine("Loai xe | Ma xe | Hang xe | So cho ngoi | Nam mua | So km da di | Co bao hanh | Gia thue 1 ngay | Chu cho thue | ");
            Console.WriteLine();
        }
        public void ShowListKH()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("-------------DANH SACH KHACH HANG-----------------");
            Console.WriteLine();
            Console.WriteLine("Ma khach hang | Ten khach hang | Dia chi | So dien thoai | ");
            Console.WriteLine();
        }        
        public void HeThongThueXe()
        {
            Console.Clear();
            Console.WriteLine("------------------------------HE THONG THUE XE------------------------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Moi ban nhap lua chon(0/1): ");
            Console.WriteLine("--------ADMIN:(0)-----------");
            Console.WriteLine("--------USER(1)-------------");
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void GiaoDienAdmin()
        {
            Console.Clear();
            Console.WriteLine("------------GIAO DIEN DANG NHAP ADMIN---------------");
            Console.WriteLine("------------EXIT: BAM PHIM 0---------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void LandingAdminForm()
        {
            Console.Clear();
            Console.WriteLine("------------GIAO DIEN CUA ADMIN DA DANG NHAP------------");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Moi ban nhap lua chon (0-5): ");
            Console.WriteLine();
            Console.WriteLine("-------Quan ly khach hang(0)----------");
            Console.WriteLine();
            Console.WriteLine("-------Quan ly phuong tien(1)----------");
            Console.WriteLine();
            Console.WriteLine("-------Xem danh sach danh gia(2)----------");
            Console.WriteLine();
            Console.WriteLine("-------Xem danh sach hop dong(3)----------");
            Console.WriteLine();
            Console.WriteLine("-------Doc, ghi file csv(4)----------");
            Console.WriteLine();
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void LuaChonKH()
        {
            Console.WriteLine("Moi ban nhap lua chon (0-5): ");
            Console.WriteLine();
            Console.WriteLine("-------Them khach hang(0)----------");
            Console.WriteLine();
            Console.WriteLine("-------Sua khach hang(1)----------");
            Console.WriteLine();
            Console.WriteLine("-------Xoa khach hang(2)----------");
            Console.WriteLine();
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void LuaChonPT()
        {
            Console.WriteLine("Moi ban nhap lua chon (0-5): ");
            Console.WriteLine();
            Console.WriteLine("-------Them phuong tien(0)----------");
            Console.WriteLine();
            Console.WriteLine("-------Sua phuong tien(1)----------");
            Console.WriteLine();
            Console.WriteLine("-------Xoa phuong tien(2)----------");
            Console.WriteLine();
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void NhapLuaChonXe()
        {
            Console.WriteLine("-------Xe 4 cho(0)----------");
            Console.WriteLine("-------Xe 7 cho(1)----------");
            Console.WriteLine("-------Xe gan may(2)----------");
            Console.WriteLine("-------Xe du lich(3)----------");
            Console.WriteLine("-------Xe dam cuoi(4)----------");
        }
        public void DocGhiFileCSV()
        {
            Console.Clear();
            Console.WriteLine("------------DOC GHI FILE CSV------------");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Moi ban nhap lua chon (0-5): ");
            Console.WriteLine();
            Console.WriteLine("-------Ghi vao file khach hang(0)----------");
            Console.WriteLine();
            Console.WriteLine("-------Ghi vao file phuong tien(1)----------");
            Console.WriteLine();
            Console.WriteLine("-------Doc file khach hang(2)----------");
            Console.WriteLine();
            Console.WriteLine("-------Doc file phuong tien(3)----------");
            Console.WriteLine();
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void GiaoDienDNUser()
        {
            Console.Clear();
            Console.WriteLine("------------GIAO DIEN ĐANG NHAP USER---------------");
            Console.WriteLine("------------EXIT: BAM PHIM 0---------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void User()
        {
            Console.Clear();
            Console.WriteLine("------------GIAO DIEN CUA USER DA DANG NHAP------------");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nhap lua chon (0-2): ");
            Console.WriteLine();
            Console.WriteLine("-------Sua thong tin ca nhan(0)----------");
            Console.WriteLine();
            Console.WriteLine("-------Tao hop dong(1)----------");
            Console.WriteLine();
            Console.WriteLine("-------Tra hop dong(2)----------");
            Console.WriteLine();
            Console.WriteLine("-------Them danh gia(3)----------");
            Console.WriteLine();
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void HopDong1()
        {
            Console.WriteLine("Tao hop dong: 1");
            Console.WriteLine();
            Console.WriteLine("Exit: Nhan phim bat ky");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void TraHopDong()
        {
            Console.WriteLine("-------Tra hop dong(1)----------");
            Console.WriteLine();
            Console.WriteLine("-------Exit(Nhan phim bat ky)----------");
            Console.WriteLine();
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void ChiPhiHuHong()
        {
            Console.WriteLine("-------Hong den(0)----------");
            Console.WriteLine("-------Xit lop(1)----------");
            Console.WriteLine("-------Xuoc xe(2)----------");
        }
        public void DanhGia()
        {
            Console.WriteLine("-------Danh gia xe(0)----------");
            Console.WriteLine("-------Danh gia nguoi thue(1)----------");
            Console.WriteLine("-------Danh gia nguoi cho thue xe(2)----------");
            Console.Write("Chon loai danh gia: ");
        }

    }
}
