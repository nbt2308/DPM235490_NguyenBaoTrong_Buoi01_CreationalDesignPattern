using System;

namespace DPM235490_NguyenBaoTrong_RealBuilderPattern_HoaDon
{
    // Director: Quản lý luồng tạo hóa đơn
    public class NhanVienThuNgan
    {
        private IHoaDonBuilder? _builder;
        public IHoaDonBuilder Builder { set { _builder = value; } }

        public void LapHoaDonCoBan()
        {
            this._builder?.TaoChiTietSanPham();
        }

        public void LapHoaDonDichVuTamDiem()
        {
            this._builder?.TaoChiTietSanPham();
            this._builder?.ThemDichVuPhu();
            this._builder?.ThemChiPhiVanChuyen();
            this._builder?.ThemGiamGiaKhuyenMai();
        }
    }
}
