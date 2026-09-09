using System;

namespace DPM235490_NguyenBaoTrong_RealFactoryPattern_NhanVienBanHang
{
    // Concrete Creator 2: Xử lý tuyển dụng/tạo tài khoản cho nhân viên quản lý
    public class PhongNhanSuQuanLy : PhongNhanSu
    {
        public override INhanVien TaoNhanVien()
        {
            return new NhanVienQuanLy();
        }
    }
}
