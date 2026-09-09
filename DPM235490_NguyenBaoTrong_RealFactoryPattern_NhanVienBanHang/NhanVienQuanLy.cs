using System;

namespace DPM235490_NguyenBaoTrong_RealFactoryPattern_NhanVienBanHang
{
    // Concrete Product 2: Cung cấp chi tiết quyền hạn của nhân viên quản lý
    public class NhanVienQuanLy : INhanVien
    {
        public string HienThiQuyenHan()
        {
            return "{Nhân viên Quản lý} - Được phép cấu hình nhập/xuất kho (FIFO), phân lô hàng và xem toàn bộ thống kê công ty.";
        }
    }
}
