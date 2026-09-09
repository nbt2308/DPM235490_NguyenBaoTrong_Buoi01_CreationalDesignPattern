using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    // Concrete Factory
    public class FactoryBaoCaoQuanLy : IBaoCaoFactory
    {
        public IBaoCaoTonKho TaoBaoCaoTonKho() => new BaoCaoTonKhoQuanLy();
        public IBaoCaoBanHang TaoBaoCaoBanHang() => new BaoCaoBanHangQuanLy();
    }
}