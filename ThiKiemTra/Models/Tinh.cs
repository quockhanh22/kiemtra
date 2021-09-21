using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThiKiemTra.Models
{
    public class Tinh
    {
        [Key]
        public int id { get; set; }
        [Required, DisplayName("Tên tỉnh ")]
        public string TenTinh { get; set; }

    }
}
