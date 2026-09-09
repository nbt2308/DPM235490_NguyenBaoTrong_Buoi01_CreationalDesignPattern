using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    // Concrete Product (Dành cho Quản lý)
    class BaoCaoBanHangQuanLy : IBaoCaoBanHang
    {
        public string XuatBaoCaoGiamGia() => "Báo cáo bán hàng (View Quản lý): Thống kê tổng chi phí khuyến mãi của TẤT CẢ nhân viên.";
    }
}
