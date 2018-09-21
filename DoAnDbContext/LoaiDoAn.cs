using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDbContext
{
   public class LoaiDoAn
    {
        [Key]
        public int LoaiDoAnId { get; set; }
        public string TenLoaiDoAn { get; set; }
        public string SoLuong { get; set; }

    }
}
