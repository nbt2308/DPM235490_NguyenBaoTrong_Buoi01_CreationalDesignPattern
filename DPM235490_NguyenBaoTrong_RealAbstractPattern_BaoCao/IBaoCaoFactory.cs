using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235490_NguyenBaoTrong_RealAbstractPattern_BaoCao
{
    // Abstract Factory
    public interface IBaoCaoFactory
    {
        IBaoCaoTonKho TaoBaoCaoTonKho();
        IBaoCaoBanHang TaoBaoCaoBanHang();
    }
}
