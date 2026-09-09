using System;

namespace DPM235490_NguyenBaoTrong_RealFactoryPattern_NhanVienBanHang
{
    // Concrete Creator 1: Xử lý tuyển dụng/tạo tài khoản cho nhân viên bán hàng
    public class PhongNhanSuBanHang : PhongNhanSu
    {
        public override INhanVien TaoNhanVien()
        {
            return new NhanVienBanHang();
        }
    }
}
