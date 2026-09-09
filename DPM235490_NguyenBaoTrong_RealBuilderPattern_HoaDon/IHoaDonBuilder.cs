using System;

namespace DPM235490_NguyenBaoTrong_RealBuilderPattern_HoaDon
{
    // Builder Interface
    public interface IHoaDonBuilder
    {
        void TaoChiTietSanPham();
        void ThemDichVuPhu();
        void ThemChiPhiVanChuyen();
        void ThemGiamGiaKhuyenMai();
        HoaDonBanHang GetHoaDon();
    }
}
