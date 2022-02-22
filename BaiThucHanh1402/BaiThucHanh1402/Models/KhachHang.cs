using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiThucHanh1402.Models
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Tên Người Dùng")]
        public int TenNguoiDung { get; set; }
        [StringLength(50)]
        [DisplayName("Tuổi Người Dùng")]
        public string TuoiNguoiDung { get; set; }
    }
}