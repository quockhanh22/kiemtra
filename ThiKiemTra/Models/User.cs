using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThiKiemTra.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required, DisplayName("Tên ")]
        public string UserName { get; set; }
        [Required, DisplayName("Mật khẩu ")]
        public string PassWord { get; set; }
    }
}
