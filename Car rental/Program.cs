using Car_rental.SALE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_rental
{
    public class Program
    {
        static List<Customers> customers = new List<Customers>()
        {
            new Customers("22110081", "Tran Minh Phong", "Vung Tau",  "0987654315"),
            new Customers("22110045", "Nguyen Van A", "Can Tho",  "09876546541"),
            new Customers("22110969", "Le Thi B", "TP Hai Phong",  "0987659721"),
            new Customers("22110654", "Tran Thi Tam", "Nam Dinh",  "0987651221"),
            new Customers("22110111", "Luu Huynh Duc", "Nghe An",  "0987658721")
        };
        static List<Landlord> landlords = new List<Landlord>()
        {
            new Landlord("Tran Van Linh", "Vung Tau", "22110081",   "0987654312"),
            new Landlord("Nguyen Vinh Duc", "Can Tho", "22110045",  "0987654334"),
            new Landlord("Tran Thi Binh", "TP Ho Chi Minh", "22110063",  "0987654345"),
            new Landlord("Nguyen Thuy Linh", "Ha Noi", "22110063",  "0987654369"),
            new Landlord("Pham Duc Vinh", "Nghe An", "22110063",  "0987654311")
        };

        static SevenSeatCar sevenSeatCar1 = new SevenSeatCar("000112", "BMW", 7, 2019, 30000, false, landlords[0]);
        static FourSeatCar fourSeatCar1 = new FourSeatCar("000123", "Kia Morning", 4, 2022, 9000, true, landlords[1]);
        static Motorbike motorbike1 = new Motorbike("000969", "Honda", 2, 2018, 50000, false, landlords[2]);
        static TouristCar touristCar1 = new TouristCar("000091", "Innova", 12, 2021, 13000, true, landlords[3]);
        static Motorbike sevenSeatCar2 = new Motorbike("000187", "Yamaha", 2, 2023, 3000, true, landlords[4]);

        static List<Vehicle> vehicles = new List<Vehicle>()
        {
            sevenSeatCar1,
            fourSeatCar1,
            motorbike1,
            touristCar1,
            sevenSeatCar2,
        };
        static List<Contract> contracts = new List<Contract>();
        static List<Review> reviews = new List<Review>();

        static void showListHD()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("-------------DANH SACH HOP DONG-----------------");
            Console.WriteLine();
            Console.WriteLine("Ma hop dong | Ten khach hang | Ma phuong tien | So ngay thue | Muc dich thue | Tien coc | Ngay thue | Trang thai | Tong so tien |");
            Console.WriteLine();
            foreach (var contract in contracts)
            {
                if (contract.IsDone == true)
                {
                    Console.WriteLine(contract.ID + " | " + contract.Customers.Name + " | " + contract.Vehicle.ID + " | " + contract.NumberOfDays + " | " + contract.Purpose + " | " + contract.Deposit + " | " + "Xong" + " | " + contract.Total + " |");
                }
                else
                {
                    Console.WriteLine(contract.ID + " | " + contract.Customers.Name + " | " + contract.Vehicle.ID + " | " + contract.NumberOfDays + " | " + contract.Purpose + " | " + contract.Deposit + " | " + "Chua xong" + " | " + contract.Total + " |");
                }
                Console.WriteLine();
            }
        }

        static void showListHDCuaUser(string id)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("-------------DANH SACH HOP DONG-----------------");
            Console.WriteLine();
            Console.WriteLine("Ma hop dong | Ten khach hang | Ma phuong tien | So ngay thue | Muc dich thue | Tien coc | Ngay thue | Trang thai | Tong so tien |");
            Console.WriteLine();
            foreach (var contract in contracts)
            {
                if (contract.Customers.ID.Equals(id))
                {
                    if (contract.IsDone == true)
                    {
                        Console.WriteLine(contract.ID + " | " + contract.Customers.Name + " | " + contract.Vehicle.ID + " | " + contract.NumberOfDays + " | " + contract.Purpose + " | " + contract.Deposit + " | " + contract.RentalDate + " | " + "Xong" + " | " + contract.Total + " |");
                    }
                    else
                    {
                        Console.WriteLine(contract.ID + " | " + contract.Customers.Name + " | " + contract.Vehicle.ID + " | " + contract.NumberOfDays + " | " + contract.Purpose + " | " + contract.Deposit + " | " + contract.RentalDate + " | " + "Chưa xong" + " | " + contract.Total + " |");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void showListDG()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("-------------DANH SACH DANH GIA-----------------");
            Console.WriteLine();
            Console.WriteLine("Ten nguoi danh gia | Danh gia | Danh cho |");
            Console.WriteLine();
            foreach (var review in reviews)
            {
                if (review is CarReview)
                {
                    Console.WriteLine(review.Name + " | " + review.Recommend + " | " + "Xe" + " |");
                }
                else if (review is HostReview)
                {
                    Console.WriteLine(review.Name + " | " + review.Recommend + " | " + "Chu xe" + " |");
                }
                else if (review is RenterReview)
                {
                    Console.WriteLine(review.Name + " | " + review.Recommend + " | " + "Nguoi thue" + " |");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Menu menu = new Menu();          
            string luaChon;
            while (true)
            {
            giaoDienDau:
                menu.HeThongThueXe();
                luaChon = Console.ReadLine();
                if (luaChon == "0")
                {
                dangNhapAdmin:
                    menu.GiaoDienAdmin();
                    string username, password;
                    Console.Write("Nhap username: ");
                    username = Console.ReadLine();
                    if (username == "0")
                    {
                        goto giaoDienDau;
                    }
                    Console.Write("Nhap password: ");
                    password = Console.ReadLine();

                    if (username == "admin" && password == "admin")
                    {
                        Console.WriteLine("Dang nhap thanh cong!");
                        Thread.Sleep(2000);
                    landingAdminForm:
                        string luaChon0;
                        menu.LandingAdminForm();
                        luaChon0 = Console.ReadLine();
                        if (luaChon0 == "0")
                        {
                        khachHang:
                            Console.Clear();
                            menu.ShowListKH();
                            foreach (var customer in customers)
                            {
                                Console.WriteLine(customer.ID + " | " + customer.Name + " | " + customer.Address + " | " + customer.PhoneNum + " | ");
                                Console.WriteLine();
                            }
                            string luaChonKH;
                            menu.LuaChonKH();
                            luaChonKH = Console.ReadLine();
                            if (luaChonKH == "0")
                            {
                            insertKH:
                                string id, sdt, ten, diaChi;
                                Console.WriteLine("Exit: Bam phim 0");
                                Console.Write("Nhap id khach hang can them: ");
                                id = Console.ReadLine();
                                if (id == "0")
                                {
                                    goto khachHang;
                                }

                                foreach (var customer in customers)
                                {
                                    if (customer.ID.Equals(id))
                                    {
                                        Console.WriteLine("Trung id!");
                                        goto insertKH;
                                    }
                                }

                                Console.Write("Hay nhap sdt: ");
                                sdt = Console.ReadLine();

                                Console.Write("Hay nhap ten: ");
                                ten = Console.ReadLine();
                                Console.Write("Hay nhap dia chi: ");
                                diaChi = Console.ReadLine();

                                Customers customerAdd = new Customers(id, ten, diaChi, sdt);
                                customers.Add(customerAdd);
                                Console.WriteLine("Them thanh cong!");
                                Thread.Sleep(2000);
                                goto khachHang;
                            }
                            else if (luaChonKH == "1")
                            {
                            updateKh:
                                string id, sdt, ten, diaChi;
                                Console.WriteLine("Exit: Bam phim 0");
                                Console.Write("Nhap id khach hang can sua: ");
                                id = Console.ReadLine();
                                if (id == "0")
                                {
                                    goto khachHang;
                                }
                                bool flagUp = false;
                                foreach (var customer in customers)
                                {
                                    if (customer.ID.Equals(id))
                                    {
                                        flagUp = true;
                                        Console.Write("Hay nhap sdt moi: ");
                                        sdt = Console.ReadLine();

                                        Console.Write("Hay nhap ten: ");
                                        ten = Console.ReadLine();
                                        Console.Write("Hay nhap dia chi: ");
                                        diaChi = Console.ReadLine();

                                        customer.Address = diaChi;
                                        customer.Name = ten;
                                        customer.PhoneNum = sdt;
                                        Console.WriteLine("Cap nhat thanh cong!");
                                        break;
                                    }
                                }
                                if (!flagUp)
                                {
                                    Console.WriteLine("Khong tim thay id!");
                                    Thread.Sleep(2000);
                                }
                                Thread.Sleep(2000);
                                goto khachHang;
                            }
                            else if (luaChonKH == "2")
                            {
                            deleteKh:
                                string id;
                                Console.WriteLine("Exit: Bam phim 0");
                                Console.Write("Nhap id khach hang can xoa: ");
                                id = Console.ReadLine();
                                if (id == "0")
                                {
                                    goto khachHang;
                                }
                                bool flagUp = false;
                                Customers customerDelete = new Customers();
                                foreach (var customer in customers)
                                {
                                    if (customer.ID.Equals(id))
                                    {
                                        flagUp = true;
                                        customerDelete = customer;
                                        customers.Remove(customer);
                                        break;
                                    }
                                }
                                if (!flagUp)
                                {
                                    Console.WriteLine("Khong tim thay id!");
                                    Thread.Sleep(2000);
                                    goto deleteKh;
                                }
                                foreach (var contract in contracts)
                                {
                                    if (contract.Customers.ID.Equals(customerDelete.ID))
                                    {
                                        contracts.Remove(contract);
                                    }
                                }
                                Console.WriteLine("Xoa thanh cong!");
                                Thread.Sleep(2000);
                                goto khachHang;
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                goto landingAdminForm;
                            }

                        }
                        else if (luaChon0 == "1")
                        {
                        phuongTien:
                            Console.Clear();
                            string luaChonPT;
                            menu.LuaChonPT();
                            luaChonPT = Console.ReadLine();
                            if (luaChonPT == "0")
                            {
                            insertPT:
                                Console.Clear();
                                menu.ShowListXe();
                                foreach (var vehicle in vehicles)
                                {
                                    string name = " ";
                                    if (vehicle.Landlord != null)
                                    {
                                        name = vehicle.Landlord.Name;

                                    }
                                    else name = "Unknown";

                                    Console.WriteLine(vehicle.VehicalInfo() + vehicle.PriceOfOneDay + " | " + name + " |");
                                    Console.WriteLine();
                                }
                                string id, company;
                                int soGhe, namMua, soKm;
                                bool baoHanh;
                                Console.WriteLine("Exit: Bam phim 0");
                                Console.Write("Nhap id phuong tien can them: ");
                                id = Console.ReadLine();
                                if (id == "0")
                                {
                                    goto phuongTien;
                                }

                                foreach (var vehicle in vehicles)
                                {
                                    if (vehicle.ID.Equals(id))
                                    {
                                        Console.WriteLine("Trung id!");
                                        goto insertPT;
                                    }
                                }

                                Console.Write("Hay nhap ten hang: ");
                                company = Console.ReadLine();

                                Console.Write("Hay nhap so cho ngoi: ");
                                soGhe = int.Parse(Console.ReadLine());

                                Console.Write("Hay nhap nam mua: ");
                                namMua = int.Parse(Console.ReadLine());

                                Console.Write("Hay nhap so km da di: ");
                                soKm = int.Parse(Console.ReadLine());

                                Console.Write("Co bao hanh(Y/N):");
                                string check = Console.ReadLine();
                                if (check == "Y")
                                {
                                    baoHanh = true;
                                }
                                else
                                {
                                    baoHanh = false;
                                }

                                Console.WriteLine("-------Them chu(Y/N)----------");
                                string themChu = Console.ReadLine();
                                if (themChu == "Y")
                                {
                                nhapChu:
                                    string ma, ten, diachi, sdt;
                                    Console.WriteLine("Nhap ma: ");
                                    ma = Console.ReadLine();
                                    foreach (var landlordIter in landlords)
                                    {
                                        if (landlordIter.ID.Equals(ma))
                                        {
                                            Console.WriteLine("Trung ma!");
                                            Thread.Sleep(1000);
                                            goto nhapChu;
                                        }
                                    }
                                    Console.WriteLine("Nhap ten: ");
                                    ten = Console.ReadLine();
                                    Console.WriteLine("Nhap dia chi: ");
                                    diachi = Console.ReadLine();

                                    Console.WriteLine("Nhap sdt: ");
                                    sdt = Console.ReadLine();

                                    Landlord landlord = new Landlord(ten, diachi, id, sdt);
                                    landlords.Add(landlord);

                                    menu.NhapLuaChonXe();
                                    string lcXe;
                                    Console.Write("Chon loai xe: ");
                                    lcXe = Console.ReadLine();

                                    if (lcXe == "0")
                                    {
                                        FourSeatCar car = new FourSeatCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "1")
                                    {
                                        SevenSeatCar car = new SevenSeatCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "2")
                                    {
                                        Motorbike car = new Motorbike(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "3")
                                    {
                                        TouristCar car = new TouristCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "4")
                                    {
                                        WeddingCar car = new WeddingCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                        vehicles.Add(car);
                                    }
                                    else
                                    {
                                        goto insertPT;
                                    }
                                }
                                else
                                {
                                    menu.NhapLuaChonXe();
                                    string lcXe;
                                    Console.Write("Chon loai xe: ");
                                    lcXe = Console.ReadLine();

                                    if (lcXe == "0")
                                    {
                                        FourSeatCar car = new FourSeatCar(id, company, soGhe, namMua, soKm, baoHanh);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "1")
                                    {
                                        SevenSeatCar car = new SevenSeatCar(id, company, soGhe, namMua, soKm, baoHanh);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "2")
                                    {
                                        Motorbike car = new Motorbike(id, company, soGhe, namMua, soKm, baoHanh);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "3")
                                    {
                                        TouristCar car = new TouristCar(id, company, soGhe, namMua, soKm, baoHanh);
                                        vehicles.Add(car);
                                    }
                                    else if (lcXe == "4")
                                    {
                                        WeddingCar car = new WeddingCar(id, company, soGhe, namMua, soKm, baoHanh);
                                        vehicles.Add(car);
                                    }
                                    else
                                    {
                                        goto insertPT;
                                    }
                                }
                                Console.WriteLine("Them thanh cong!");
                                Thread.Sleep(2000);
                                goto phuongTien;
                            }
                            else if (luaChonPT == "1")
                            {
                            updatePT:
                                Console.Clear();
                                menu.ShowListXe();
                                foreach (var vehicle in vehicles)
                                {
                                    string name = " ";
                                    if (vehicle.Landlord != null)
                                    {
                                        name = vehicle.Landlord.Name;

                                    }
                                    else name = "Unknown";

                                    Console.WriteLine(vehicle.VehicalInfo() + vehicle.PriceOfOneDay + " | " + name + " |");
                                    Console.WriteLine();
                                }
                                string id, company;
                                int soGhe, namMua, soKm;
                                bool baoHanh;
                                Console.WriteLine("Exit: Bam phim 0");
                                Console.Write("Nhap id phuong tien can sua: ");
                                id = Console.ReadLine();
                                if (id == "0")
                                {
                                    goto phuongTien;
                                }
                                bool flagUp = false;
                                foreach (var vehicle in vehicles)
                                {
                                    if (vehicle.ID.Equals(id))
                                    {
                                        flagUp = true;
                                        Console.Write("Hay nhap ten hang: ");
                                        company = Console.ReadLine();

                                        Console.Write("Hay nhap so cho ngoi: ");
                                        soGhe = int.Parse(Console.ReadLine());

                                        Console.Write("Hay nhap nam mua: ");
                                        namMua = int.Parse(Console.ReadLine());

                                        Console.Write("Hay nhap so km da di: ");
                                        soKm = int.Parse(Console.ReadLine());

                                        Console.Write("Co bao hanh(Y/N):");
                                        string check = Console.ReadLine();
                                        if (check == "Y")
                                        {
                                            baoHanh = true;
                                        }
                                        else
                                        {
                                            baoHanh = false;
                                        }
                                    nhapChu:
                                        string ma, ten, diachi, sdt;
                                        Console.WriteLine("Them chu: ");
                                        Console.WriteLine();
                                        Console.WriteLine("Nhap ma: ");
                                        ma = Console.ReadLine();
                                        foreach (var landlordIter in landlords)
                                        {
                                            if (landlordIter.ID.Equals(ma))
                                            {
                                                Console.WriteLine("Trung ma!");
                                                Thread.Sleep(1000);
                                                goto nhapChu;
                                            }
                                        }
                                        Console.WriteLine("Nhap ten: ");
                                        ten = Console.ReadLine();
                                        Console.WriteLine("Nhap dia chi: ");
                                        diachi = Console.ReadLine();

                                        Console.WriteLine("Nhap sdt: ");
                                        sdt = Console.ReadLine();

                                        Landlord landlord = new Landlord(ten, diachi, id, sdt);
                                        landlords.Add(landlord);

                                        menu.NhapLuaChonXe();
                                        string lcXe;
                                        Console.Write("Chon loai xe: ");
                                        lcXe = Console.ReadLine();
                                        bool flag = false;
                                        if (lcXe == "0")
                                        {
                                            flag = true;
                                            vehicles.Remove(vehicle);
                                            FourSeatCar car = new FourSeatCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                            vehicles.Add(car);

                                        }
                                        else if (lcXe == "1")
                                        {
                                            flag = true;
                                            vehicles.Remove(vehicle);

                                            SevenSeatCar car = new SevenSeatCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                            vehicles.Add(car);
                                        }
                                        else if (lcXe == "2")
                                        {
                                            flag = true;
                                            vehicles.Remove(vehicle);

                                            Motorbike car = new Motorbike(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                            vehicles.Add(car);
                                        }
                                        else if (lcXe == "3")
                                        {
                                            flag = true;
                                            vehicles.Remove(vehicle);

                                            TouristCar car = new TouristCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                            vehicles.Add(car);
                                        }
                                        else if (lcXe == "4")
                                        {
                                            flag = true;
                                            vehicles.Remove(vehicle);

                                            WeddingCar car = new WeddingCar(id, company, soGhe, namMua, soKm, baoHanh, landlord);
                                            vehicles.Add(car);
                                        }
                                        else
                                        {
                                            goto updatePT;
                                        }
                                        if (flag)
                                        {
                                            Vehicle vehicleChange = new Vehicle();
                                            foreach (var vehicleFind in vehicles)
                                            {
                                                if (vehicleFind.ID.Equals(vehicle.ID))
                                                {
                                                    vehicleChange = vehicleFind;
                                                    break;
                                                }
                                            }
                                            foreach (var contract in contracts)
                                            {
                                                if (contract.Vehicle.ID.Equals(vehicle.ID))
                                                {
                                                    contract.Vehicle = vehicleChange;
                                                    break;
                                                }
                                            }
                                        }
                                        Console.WriteLine("Cap nhat thanh cong!");
                                        break;
                                    }
                                }
                                if (!flagUp)
                                {
                                    Console.WriteLine("Khong tim thay id!");
                                    Thread.Sleep(2000);
                                    goto updatePT;
                                }
                                Thread.Sleep(2000);
                                goto phuongTien;
                            }
                            else if (luaChonPT == "2")
                            {
                            deletePT:
                                Console.Clear();
                                menu.ShowListXe();
                                foreach (var vehicle in vehicles)
                                {
                                    string name = " ";
                                    if (vehicle.Landlord != null)
                                    {
                                        name = vehicle.Landlord.Name;

                                    }
                                    else name = "Unknown";

                                    Console.WriteLine(vehicle.VehicalInfo() + vehicle.PriceOfOneDay + " | " + name + " |");
                                    Console.WriteLine();
                                }
                                string id;
                                Console.WriteLine("Exit: Bam phim 0");
                                Console.Write("Nhap id phuong tien can xoa: ");
                                id = Console.ReadLine();
                                if (id == "0")
                                {
                                    goto phuongTien;
                                }
                                bool flagUp = false;
                                Vehicle vehicleDelete = new Vehicle();
                                foreach (var vehicle in vehicles)
                                {
                                    if (vehicle.ID.Equals(id))
                                    {
                                        flagUp = true;
                                        vehicleDelete = vehicle;
                                        vehicles.Remove(vehicle);
                                        break;
                                    }
                                }
                                if (!flagUp)
                                {
                                    Console.WriteLine("Khong tim thay id!");
                                    Thread.Sleep(2000);
                                    goto deletePT;
                                }
                                foreach (var contract in contracts)
                                {
                                    if (contract.Vehicle.ID.Equals(vehicleDelete.ID))
                                    {
                                        contracts.Remove(contract);
                                    }
                                }
                                Console.WriteLine("Xoa thanh cong!");
                                Thread.Sleep(2000);
                                goto phuongTien;
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                goto landingAdminForm;
                            }

                        }
                        else if (luaChon0 == "2")
                        {
                        danhGia:
                            Console.Clear();
                            showListDG();
                            string luaChonDG;
                            Console.WriteLine("-------Exit(Nhan phim 0)----------");
                            Console.WriteLine();
                            Console.Write("Nhap lua chon cua ban: ");
                            luaChonDG = Console.ReadLine();
                            if (luaChonDG == "0")
                            {
                                Thread.Sleep(2000);
                                goto landingAdminForm;
                            }
                            else goto danhGia;
                        }
                        else if (luaChon0 == "3")
                        {
                        hopDong:
                            Console.Clear();
                            showListHD();
                            string luaChonDG;
                            Console.WriteLine("-------Exit(Nhan phim 0)----------");
                            Console.WriteLine();
                            Console.Write("Nhap lua chon cua ban: ");
                            luaChonDG = Console.ReadLine();
                            if (luaChonDG == "0")
                            {
                                Thread.Sleep(2000);
                                goto landingAdminForm;
                            }
                            else goto hopDong;
                        }
                        else if (luaChon0 == "4")
                        {
                            string luaChon5;
                            menu.DocGhiFileCSV();
                            luaChon5 = Console.ReadLine();

                            string filePath;
                            if (luaChon5 == "0")
                            {
                                Console.Write("Nhap duong dan: ");
                                filePath = Console.ReadLine();
                                Csv.WriteCustomer(filePath, customers, true);
                                Console.WriteLine("Ghi thanh cong!");
                            }
                            else if (luaChon5 == "1")
                            {
                                Console.Write("Nhap duong dan: ");
                                filePath = Console.ReadLine();
                                Csv.WriteVehicle(filePath, vehicles, true);
                                Console.WriteLine("Ghi thanh cong!");
                            }
                            else if (luaChon5 == "2")
                            {
                                Console.Write("Nhap duong dan: ");
                                filePath = Console.ReadLine();
                                Csv.ReadCustomer(filePath);
                            }
                            else if (luaChon5 == "3")
                            {
                                Console.Write("Nhap duong dan: ");
                                filePath = Console.ReadLine();
                                Csv.ReadVehicle(filePath);
                            }
                            Thread.Sleep(5000);
                            goto landingAdminForm;
                        }
                        else
                        {
                            Thread.Sleep(2000);
                            goto giaoDienDau;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dang nhap sai!");
                        Thread.Sleep(2000);
                        goto dangNhapAdmin;
                    }
                }
                else if (luaChon == "1")
                {
                dangNhapUser:
                    menu.GiaoDienDNUser();
                    string id;
                    Console.Write("Nhap id: ");
                    id = Console.ReadLine();
                    if (id == "0")
                    {
                        goto giaoDienDau;
                    }

                    bool flag = false;
                    Customers customerFind = new Customers();
                    foreach (var customer in customers)
                    {
                        if (customer.ID.Equals(id))
                        {
                            customerFind = customer;
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {

                        Console.WriteLine("Dang nhap thanh cong!");
                        Thread.Sleep(2000);
                    landingUserForm:
                        string luaChon0;
                        menu.User();
                        luaChon0 = Console.ReadLine();
                        if (luaChon0 == "0")
                        {
                            Console.Clear();
                            Console.WriteLine("-----Thong tin hien tai------");
                            Console.WriteLine();
                            Console.WriteLine("Ho ten: " + customerFind.Name);
                            Console.WriteLine();
                            Console.WriteLine("Dia chi: " + customerFind.Address);
                            Console.WriteLine();
                            Console.WriteLine("So dien thoai: " + customerFind.PhoneNum);
                            Console.WriteLine();

                            string lc;
                            Console.WriteLine("Sua doi: 1");
                            Console.WriteLine("Exit: Nhan phim bat ky");
                            Console.Write("Nhap lua chon cua ban: ");
                            lc = Console.ReadLine();
                            if (lc == "1")
                            {
                                string tenMoi, diaChiMoi, sdtMoi;
                                Console.Write("Ten moi: ");
                                tenMoi = Console.ReadLine();
                                Console.Write("Dia chi moi: ");
                                diaChiMoi = Console.ReadLine();
                                Console.Write("So dien thoai moi: ");
                                sdtMoi = Console.ReadLine();

                                foreach (var customer in customers)
                                {
                                    if (customer.ID == customerFind.ID)
                                    {
                                        customer.Name = tenMoi;
                                        customer.Address = diaChiMoi;
                                        customer.PhoneNum = sdtMoi;
                                        break;
                                    }
                                }
                                Console.WriteLine("Cap nhat thanh cong!");
                                Thread.Sleep(2000);
                            }
                            goto landingUserForm;
                        }
                        else if (luaChon0 == "1")
                        {
                            Console.Clear();
                            menu.ShowListXe();
                            foreach (var vehicle in vehicles)
                            {
                                string name = " ";
                                if (vehicle.Landlord != null)
                                {
                                    name = vehicle.Landlord.Name;

                                }
                                else name = "Unknown";

                                Console.WriteLine(vehicle.VehicalInfo() + vehicle.PriceOfOneDay + " | " + name + " | ");
                                Console.WriteLine();
                            }
                            string lc;
                            menu.HopDong1();
                            lc = Console.ReadLine();
                            if (lc == "1")
                            {
                            nhapLieu:
                                string ma;
                                Console.Write("Hay nhap ma hop dong: ");
                                ma = Console.ReadLine();
                                foreach (var contract in contracts)
                                {
                                    if (contract.ID.Equals(ma))
                                    {
                                        Console.WriteLine("Ma bi trung!");
                                        Thread.Sleep(2000);
                                        goto nhapLieu;
                                    }
                                }
                                Vehicle vehicleAdd = new Vehicle();
                                string maXe;
                                Console.Write("Hay chon ma xe thue: ");
                                maXe = Console.ReadLine();
                                bool fl = false;
                                foreach (var vehicle in vehicles)
                                {
                                    if (vehicle.ID.Equals(maXe))
                                    {
                                        fl = true;
                                        vehicleAdd = vehicle;
                                        break;
                                    }
                                }
                                if (!flag)
                                {
                                    Console.WriteLine("Khong tim thay ma xe!");
                                    Thread.Sleep(2000);
                                    goto nhapLieu;
                                }
                                else
                                {
                                    int soNgay;
                                    string mucDich;
                                    double tienCoc;
                                    DateTime ngayThue;

                                    Console.Write("Hay nhap so ngay thue: ");
                                    soNgay = int.Parse(Console.ReadLine());
                                    Console.Write("Hay nhap muc dich: ");
                                    mucDich = Console.ReadLine();
                                    Console.Write("Hay nhap so tien coc truoc: ");
                                    tienCoc = double.Parse(Console.ReadLine());
                                    Console.Write("Hay nhap ngay thue: ");
                                    ngayThue = DateTime.Parse(Console.ReadLine());
                                    int count = 0;
                                    foreach (var contractIte in contracts)
                                    {
                                        if (contractIte.Customers.ID.Equals(customerFind.ID))
                                        {
                                            count++;
                                        }
                                    }
                                    CustomerLoyaltyDiscount customerLoyaltyDiscount = new CustomerLoyaltyDiscount();
                                    customerLoyaltyDiscount.Numbers = count;
                                    Promotion promotion = new Promotion();
                                    double origin = vehicleAdd.PriceOfOneDay * soNgay;
                                    double percent = 1 + customerLoyaltyDiscount.DiscountOrIncrease() + promotion.DiscountOrIncrease();
                                    Console.WriteLine(percent);
                                    double total = origin * percent;
                                    Contract contract = new Contract(ma, customerFind, vehicleAdd, soNgay, mucDich, tienCoc, ngayThue, false, total);
                                    contracts.Add(contract);
                                    Console.WriteLine("So tien phai tra la: " + total);
                                    Console.WriteLine("HOP DONG DUOC TAO THANH CONG!");
                                    Thread.Sleep(5000);
                                }
                            }
                            goto landingUserForm; 
                        }
                        else if (luaChon0 == "2")
                        {
                            Console.Clear();
                            showListHDCuaUser(customerFind.ID);
                            menu.TraHopDong();
                            string lcTra;
                            lcTra = Console.ReadLine();
                            if (lcTra == "1")
                            {
                            traHD:
                                string idHD;
                                Console.WriteLine("Nhap id hop dong muon tra: ");
                                idHD = Console.ReadLine();
                                bool flagHD = false;
                                Contract contractTra = new Contract();
                                foreach (var contract in contracts)
                                {
                                    if (contract.ID.Equals(idHD))
                                    {
                                        flagHD = true;
                                        contractTra = contract;
                                        break;
                                    }
                                }
                                if (!flagHD)
                                {
                                    Console.WriteLine("Khong tim thay!");
                                    Thread.Sleep(2000);
                                    goto traHD;
                                }
                                string huHong;
                                Console.WriteLine("Xe co hu hong(Y/N):");
                                huHong = Console.ReadLine();
                                if (huHong == "Y")
                                {
                                    menu.ChiPhiHuHong();
                                    string lcHong;
                                    Console.Write("Chon loai hu hong: ");
                                    lcHong = Console.ReadLine();
                                    if (lcHong == "0")
                                    {
                                        BrokenLight bl = new BrokenLight();
                                        double price = contractTra.Total + bl.CostAmount();
                                        Console.WriteLine("Tong gia tri phai tra la: " + price);
                                        Console.WriteLine("Xac nhan(Y/N):");
                                        string xacNhan = Console.ReadLine();
                                        if (xacNhan == "Y")
                                        {
                                            foreach (var contract in contracts)
                                            {
                                                if (contract.ID.Equals(contractTra.ID))
                                                {
                                                    contract.Total = price;
                                                    contract.IsDone = true;
                                                    Console.WriteLine("Tra thanh cong!");
                                                    Thread.Sleep(2000);
                                                    goto landingUserForm;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Thread.Sleep(2000);
                                            goto landingUserForm;
                                        }
                                    }
                                    else if (lcHong == "1")
                                    {
                                        FlatTire ft = new FlatTire();
                                        double price = contractTra.Total + ft.CostAmount();
                                        Console.WriteLine("Tong gia tri phai tra la: " + price);
                                        Console.WriteLine("Xac nhan(Y/N):");
                                        string xacNhan = Console.ReadLine();
                                        if (xacNhan == "Y")
                                        {
                                            foreach (var contract in contracts)
                                            {
                                                if (contract.ID.Equals(contractTra.ID))
                                                {
                                                    contract.Total = price;
                                                    contract.IsDone = true;
                                                    Console.WriteLine("Tra thanh cong!");
                                                    Thread.Sleep(2000);
                                                    goto landingUserForm;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Thread.Sleep(2000);
                                            goto landingUserForm;
                                        }
                                    }
                                    else if (lcHong == "2")
                                    {
                                        Scratch s = new Scratch();
                                        double price = contractTra.Total + s.CostAmount();
                                        Console.WriteLine("Tong gia tri phai tra la: " + price);
                                        Console.WriteLine("Xac nhan(Y/N):");
                                        string xacNhan = Console.ReadLine();
                                        if (xacNhan == "Y")
                                        {
                                            foreach (var contract in contracts)
                                            {
                                                if (contract.ID.Equals(contractTra.ID))
                                                {
                                                    contract.Total = price;
                                                    contract.IsDone = true;
                                                    Console.WriteLine("Tra thanh cong!");
                                                    Thread.Sleep(2000);
                                                    goto landingUserForm;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Thread.Sleep(2000);
                                            goto landingUserForm;
                                        }
                                    }
                                }
                                else
                                {
                                    double price = contractTra.Total;
                                    Console.WriteLine("Tong gia tri phai tra la: " + price);
                                    Console.WriteLine("Xac nhan(Y/N):");
                                    string xacNhan = Console.ReadLine();
                                    if (xacNhan == "Y")
                                    {
                                        foreach (var contract in contracts)
                                        {
                                            if (contract.ID.Equals(contractTra.ID))
                                            {
                                                contract.Total = price;
                                                contract.IsDone = true;
                                                Console.WriteLine("Tra thanh cong!");
                                                Thread.Sleep(2000);
                                                goto landingUserForm;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Thread.Sleep(2000);
                                        goto landingUserForm;
                                    }
                                }

                            }
                            else
                            {
                                Thread.Sleep(2000);
                                goto landingUserForm;
                            }

                        }
                        else if (luaChon0 == "3")
                        {
                            string recommend, type;
                            Console.WriteLine("Exit: Bam phim 0");
                            Console.Write("Hay nhap danh gia: ");
                            recommend = Console.ReadLine();
                            if (recommend == "0")
                            {
                                goto landingUserForm;
                            }
                            menu.DanhGia();
                            type = Console.ReadLine();
                            if (type == "0")
                            {
                                CarReview review = new CarReview(customerFind.Name, recommend);
                                reviews.Add(review);
                                Console.WriteLine("Them thanh cong!");
                            }
                            else if (type == "1")
                            {
                                RenterReview review = new RenterReview(customerFind.Name, recommend);
                                reviews.Add(review);
                                Console.WriteLine("Them thanh cong!");
                            }
                            else if (type == "2")
                            {
                                HostReview review = new HostReview(customerFind.Name, recommend);
                                reviews.Add(review);
                                Console.WriteLine("Them thanh cong!");
                            }
                            Thread.Sleep(2000);
                            goto landingUserForm;
                        }

                        else
                        {
                            Thread.Sleep(2000);
                            goto giaoDienDau;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dang nhap sai!");
                        Thread.Sleep(2000);
                        goto dangNhapUser;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("HEN GAP LAI!");
                    return;
                }
            }
        }
    }
}
