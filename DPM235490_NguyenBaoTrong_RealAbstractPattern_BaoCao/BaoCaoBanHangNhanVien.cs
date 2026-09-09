using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    // Concrete Product (Dành cho Nhân viên)
    class BaoCaoBanHangNhanVien : IBaoCaoBanHang
    {
        public string XuatBaoCaoGiamGia() => "Báo cáo bán hàng (View Nhân viên): Thống kê hóa đơn giảm giá DO CHÍNH NHÂN VIÊN ĐÓ lập.";
    }
}