using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Car_rental.SALE
{
    public class Csv
    {
        public static void WriteVehicle(string path, List<Vehicle> records, bool continueW)
        {
            string filePath = path;

            using (StreamWriter writer = new StreamWriter(filePath, continueW))
            {
                if (!continueW || writer.BaseStream.Position == 0)
                {
                    writer.WriteLine("ID,CarCompany,SeatNum,YearOfPurchase,KilometersNum,Insurance,PriceOfOneDay,LandlordName,VehicleType");
                }

                foreach (var vehicle in records)
                {
                    string vehicleType = GetVehicleTypeString(vehicle);

                    if (vehicle.Landlord == null)
                    {
                        writer.WriteLine($"{vehicle.ID},{vehicle.CarCompany},{vehicle.SeatNum},{vehicle.YearOfPurchase},{vehicle.KilometersNum},{vehicle.Insurance},{vehicle.PriceOfOneDay},Khong co,{vehicleType}");
                    }
                    else
                    {
                        writer.WriteLine($"{vehicle.ID},{vehicle.CarCompany},{vehicle.SeatNum},{vehicle.YearOfPurchase},{vehicle.KilometersNum},{vehicle.Insurance},{vehicle.PriceOfOneDay},{vehicle.Landlord.Name},{vehicleType}");
                    }
                }
            }

        }
        private static string GetVehicleTypeString(Vehicle vehicle)
        {
            if (vehicle is FourSeatCar)
            {
                return "Xe 4 cho";
            }
            else if (vehicle is SevenSeatCar)
            {
                return "Xe 7 cho";
            }
            else if (vehicle is Motorbike)
            {
                return "Xe may";
            }
            else if (vehicle is TouristCar)
            {
                return "Xe du lich";
            }
            else if (vehicle is WeddingCar)
            {
                return "Xe dam cuoi";
            }
            else
            {
                return "Khong biet";
            }
        }
        public static void WriteCustomer(string path, List<Customers> records, bool continueW)
        {
            string filePath = path;

            using (StreamWriter writer = new StreamWriter(filePath, continueW))
            {
                if (writer.BaseStream.Position == 0)
                {
                    writer.WriteLine("ID,NAME,PHONENUMBER,ADDRESS");
                }
                foreach (var a in records)
                {
                    writer.WriteLine($"{a.ID},{a.Name},{a.PhoneNum},{a.Address}");
                }
            }

        }

        public static void ReadCustomer(string filepath)
        {
            string filePath = filepath;

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Ma khach hang | Ten khach hang | Dia chi | So dien thoai | ");
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    string id = values[0].Trim();
                    string customerName = values[1].Trim();
                    string address = values[2].Trim();
                    string phoneNumber = values[3].Trim();
                    Console.WriteLine(id + " | " + customerName + " | " + address + " | " + phoneNumber + " | ");
                    
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy file: " + filePath);
            }


        }
        public static void ReadVehicle(string filepath)
        {
            string filePath = filepath;

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("-------------DANH SACH CAC XE HIEN CO-----------------");
                Console.WriteLine();
                Console.WriteLine("Loai xe | Ma xe | Hang xe | So cho ngoi | Nam mua | So km da di | Co bao hanh | Gia thue 1 ngay | Chu cho thue | ");
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    string id = values[0].Trim();
                    string company = values[1].Trim();
                    string seatNum = values[2].Trim();
                    string year = values[3].Trim();
                    string km = values[4].Trim();
                    string insurance = values[5].Trim();
                    string price = values[6].Trim();
                    string landlord = values[7].Trim();
                    string type = values[8].Trim();
                    if(id != "ID")
                    {
                        Console.WriteLine(type + " | " + id + " | " + company + " | " + seatNum + " | " + year + " | " + km + " | " + insurance + " | " + price + " | " + landlord + " |");
                    }
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy file: " + filePath);
            }
        }
    }
}
