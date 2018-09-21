using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDbContext
{
   public class PhuongThucThanhToan
    {
        [Key]
        public int PhuongThucThanhToanId { get; set; }
        public string TenPhuongThucThanhToan { get; set; }
    }
}
