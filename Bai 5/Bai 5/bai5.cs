using System;
using System.Collections.Generic;
using System.Linq;

class SinhVien
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public  int HocKy { get; set; }
    public string MonHoc { get; set; }
    public SinhVien(string maSV, string hoTen, int hocKy, string monHoc)
    {
        MaSV = maSV;
        HoTen = hoTen;
        HocKy  = hocKy;
        MonHoc = monHoc;
    }

}
class Program
{ 
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<SinhVien> sinhViens = new List<SinhVien>();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Chương trình quản lý thông tin sinh viên");
            Console.WriteLine("1. Nhập danh sách sinh viên");
            Console.WriteLine("2. Tìm kiếm sinh viên theo ID hoặc tên");
            Console.WriteLine("3. Sửa hoặc xóa thông tin sinh viên");
            Console.WriteLine("4. Thống kê số lần đăng ký khóa học");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    NhapDanhSachSinhVien(sinhViens);
                    break;
                case 2:
                    TimKiemSinhVien(sinhViens);
                    break;
                case 3:
                    SuaXoaSinhVien(sinhViens);
                    break;
                case 4:
                    ThongKeSoLanDangKy(sinhViens);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
            Console.ReadKey();
        }
    }
    static void NhapDanhSachSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Nhập thông tin sinh viên:");
        Console.Write("Nhập số lượng sinh viên: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");

            Console.Write("Mã sinh viên: ");
            string maSV = Console.ReadLine();

            Console.Write("Họ tên sinh viên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Học kỳ: ");
            int hocKy = int.Parse(Console.ReadLine());

            string monHoc;
            while (true)
            {
                Console.Write("Môn học (Java, .Net, C/C++): ");
                monHoc = Console.ReadLine();
                if (monHoc == "Java" || monHoc == ".Net" || monHoc == "C/C++")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Môn học không hợp lệ, vui lòng chọn lại.");
                }
            }

            SinhVien sinhVien = new SinhVien(maSV, hoTen, hocKy, monHoc);
            danhSachSinhVien.Add(sinhVien);
        }

        Console.WriteLine("Đã nhập xong danh sách sinh viên.");
    }

    static void TimKiemSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.Write("Nhập ID hoặc tên sinh viên: ");
        string tuKhoa = Console.ReadLine();

        var ketQua = danhSachSinhVien.Where(s => s.MaSV.Contains(tuKhoa) || s.HoTen.Contains(tuKhoa)).ToList();

        if (ketQua.Count > 0)
        {
            Console.WriteLine("Kết quả tìm kiếm:");
            foreach (var sinhVien in ketQua)
            {
                Console.WriteLine($"ID: {sinhVien.MaSV}, Tên: {sinhVien.HoTen}, Học kỳ: {sinhVien.HocKy}, Môn học: {sinhVien.MonHoc}");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên nào.");
        }
    }
    static void SuaXoaSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Sửa hoặc xóa thông tin sinh viên:");
        Console.Write("Nhập mã sinh viên cần sửa hoặc xóa: ");
        string maSV = Console.ReadLine();

        var sinhVien = danhSachSinhVien.FirstOrDefault(s => s.MaSV == maSV);

        if (sinhVien != null)
        {
            Console.WriteLine($"Thông tin sinh viên: ID: {sinhVien.MaSV}, Tên: {sinhVien.HoTen}, Học kỳ: {sinhVien.HocKy}, Môn học: {sinhVien.MonHoc}");
            Console.WriteLine("1. Sửa thông tin");
            Console.WriteLine("2. Xóa sinh viên");
            Console.Write("Chọn chức năng: ");
            int luaChon = int.Parse(Console.ReadLine());

            if (luaChon == 1)
            {
                Console.Write("Nhập lại tên sinh viên: ");
                sinhVien.HoTen = Console.ReadLine();

                Console.Write("Nhập lại học kỳ: ");
                sinhVien.HocKy = int.Parse(Console.ReadLine());

                string monHoc;
                while (true)
                {
                    Console.Write("Nhập lại môn học (Java, .Net, C/C++): ");
                    monHoc = Console.ReadLine();
                    if (monHoc == "Java" || monHoc == ".Net" || monHoc == "C/C++")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Môn học không hợp lệ, vui lòng chọn lại.");
                    }
                }
                sinhVien.MonHoc = monHoc;
                Console.WriteLine("Thông tin sinh viên đã được sửa.");
            }
            else if (luaChon == 2)
            {
                danhSachSinhVien.Remove(sinhVien);
                Console.WriteLine("Sinh viên đã được xóa.");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã này.");
        }
    }

    static void ThongKeSoLanDangKy(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Thống kê số lần đăng ký khóa học:");

        var thongKe = danhSachSinhVien.GroupBy(s => new { s.HoTen, s.MonHoc })
                                      .Select(g => new { g.Key.HoTen, g.Key.MonHoc, Total = g.Count() })
                                      .ToList();

        Console.WriteLine("Tên sinh viên | Môn học | Số lần đăng ký");
        foreach (var item in thongKe)
        {
            Console.WriteLine($"{item.HoTen} | {item.MonHoc} | {item.Total}");
        }
    }
}