using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDbContext
{
   public class NguoiDung
    {
        [Key]
        public int NguoiDungId { get; set; }
        public string TenNguoiDung { get; set; }
        public string DiaChiNhanHang { get; set; }
        public int GioHangId { get; set; }
        public string SoDienThoai { get; set;}

    }
}
