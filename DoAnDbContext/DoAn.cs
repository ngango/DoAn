using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDbContext
{
   public class DoAn
    {
        [Key]
        public int DoAnId { get; set; }
        public string TenDoAn { get; set; }
        public string Mota { get; set; }
        public decimal GiaTien { get; set; }
        public int SoLuong { get; set; }
        public int TinhTrangId { get; set; }
        public int LoaiDoAnId { get; set; }
        public bool Deleted { get; set; }
    }
}
