using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDbContext
{
   public class TinhTrangHang
    {
        [Key]
        public int TinhTrangId { get; set; }
        public string TenTinhTrang { get; set; }
    }
}
