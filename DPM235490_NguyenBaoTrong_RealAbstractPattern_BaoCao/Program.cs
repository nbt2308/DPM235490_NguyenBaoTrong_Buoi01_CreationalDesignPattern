using System;
using System.Text;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== MẪU ABSTRACT FACTORY: HỆ THỐNG THỐNG KÊ BÁO CÁO ===\n");

            Console.WriteLine(">> Kịch bản 1: Giám đốc truy cập hệ thống thống kê:");
            HeThongThongKe heThongAdmin = new HeThongThongKe(new FactoryBaoCaoQuanLy());
            heThongAdmin.InBaoCao();

            Console.WriteLine("\n>> Kịch bản 2: Nhân viên bán hàng truy cập hệ thống thống kê:");
            HeThongThongKe heThongStaff = new HeThongThongKe(new FactoryBaoCaoNhanVien());
            heThongStaff.InBaoCao();

            Console.ReadLine();
        }
    }
}