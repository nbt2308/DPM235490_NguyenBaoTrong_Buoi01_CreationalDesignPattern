using System;

namespace DPM235490_NguyenBaoTrong_RealPrototypePattern_LoHang
{
    // Concrete Prototype
    public class LoHangNongDuoc : ILoHangPrototype
    {
        public string MaLo { get; set; }
        public string TenSanPham { get; set; }
        public string NhaCungCap { get; set; }
        public DateTime NgayHetHan { get; set; }

        public LoHangNongDuoc(string maLo, string tenSanPham, string nhaCungCap, DateTime ngayHetHan)
        {
            MaLo = maLo;
            TenSanPham = tenSanPham;
            NhaCungCap = nhaCungCap;
            NgayHetHan = ngayHetHan;
        }

        // Tạo bản sao nông (Shallow copy)
        public ILoHangPrototype Clone()
        {
            Console.WriteLine($"[Hệ thống] Đang nhân bản Lô hàng {MaLo}...");
            return (ILoHangPrototype)this.MemberwiseClone();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"- Lô: {MaLo} | SP: {TenSanPham} | NCC: {NhaCungCap} | HSD: {NgayHetHan.ToShortDateString()}");
        }
    }
}
