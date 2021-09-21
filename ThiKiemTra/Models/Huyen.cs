using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThiKiemTra.Models
{
    public class Huyen
    {
        public int id { get; set; }
        [Required, DisplayName("Tên Huyện")]
        public string TenHuyen { get; set; }
        public int idTinh { get; set; }
    }
}
