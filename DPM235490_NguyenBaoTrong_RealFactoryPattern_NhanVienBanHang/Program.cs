using System;
using System.Text;

namespace DPM235490_NguyenBaoTrong_RealFactoryPattern_NhanVienBanHang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ hiển thị tiếng Việt có dấu trên Console
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("==================================================");
            Console.WriteLine("Đồ án: Quản lý bán hàng Công ty Nông dược An Giang");
            Console.WriteLine("Mẫu thiết kế: Factory Method (Phân quyền nhân viên)");
            Console.WriteLine("Thực hiện: Nguyễn Bảo Trọng - DPM235490");
            Console.WriteLine("==================================================\n");

            new Client().Main();

            Console.ReadLine();
        }
    }
}