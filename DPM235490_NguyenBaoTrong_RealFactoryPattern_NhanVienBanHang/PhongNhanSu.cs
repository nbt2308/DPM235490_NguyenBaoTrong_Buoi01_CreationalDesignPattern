using System;

namespace DPM235490_NguyenBaoTrong_RealFactoryPattern_NhanVienBanHang
{
    // Lớp Creator trừu tượng (Nhà máy/Phòng nhân sự chung)
    public abstract class PhongNhanSu
    {
        // Factory Method
        public abstract INhanVien TaoNhanVien();

        // Core business logic (SomeOperation)
        public string PhanCongCongViec()
        {
            // Gọi factory method để tạo đối tượng nhân viên
            var nhanVien = TaoNhanVien();
            // Sử dụng đối tượng vừa tạo vào quy trình nghiệp vụ chung
            var ketQua = "Hệ thống phân công thành công: " + nhanVien.HienThiQuyenHan();
            return ketQua;
        }
    }
}
