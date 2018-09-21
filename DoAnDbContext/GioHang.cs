using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDbContext
{
   public class GioHang
    {
        [Key]
        public int GioHangId { get; set; }
        public int DoAnId { get; set; }
        public int SoLuongDat { get; set; }
        public bool TrangThai { get; set; }
    }
}
