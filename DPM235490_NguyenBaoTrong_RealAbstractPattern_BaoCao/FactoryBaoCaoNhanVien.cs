using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    // Concrete Factory
    public class FactoryBaoCaoNhanVien : IBaoCaoFactory
    {
        public IBaoCaoTonKho TaoBaoCaoTonKho() => new BaoCaoTonKhoNhanVien();
        public IBaoCaoBanHang TaoBaoCaoBanHang() => new BaoCaoBanHangNhanVien();
    }
}
