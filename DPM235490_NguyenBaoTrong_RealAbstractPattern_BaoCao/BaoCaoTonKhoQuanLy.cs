using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    // Concrete Product (Dành cho Quản lý)
    class BaoCaoTonKhoQuanLy : IBaoCaoTonKho
    {
        public string XuatBaoCaoTonKho() => "Báo cáo tồn kho (View Quản lý): Hiển thị chi tiết giá vốn bình quân gia quyền và toàn bộ kho.";
    }
}