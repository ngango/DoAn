using DoAnDbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnModel
{
   public class DoAnDbContext:DbContext
    {
        public DoAnDbContext() : base("name=DoAnContext")
        {

        }
        public DbSet<DoAn> DoAns { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; } 
        public DbSet<TinhTrangHang> TinhTrangHangs { get; set; }
        public DbSet<LoaiDoAn> LoaiDoAns { get; set; }
        public DbSet<PhanQuyen> PhanQuyens { get; set; }
        public DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
       
    }
}
