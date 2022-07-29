using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Thêm
using System.ComponentModel.DataAnnotations.Schema; //Thêm
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_EFCore_CodeFirst.A_DAL.Models
{
    internal class Human
    {
        [Key] //Khóa
        public string CMT { get; set; }
        [Required] // not null
        [MaxLength(100)] // Độ dài tối đa là 100
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        [Column("Address", TypeName = "nvarchar(200)")] // Tên cột là Address, kiểu nvarchar(200)
        public string DiaChi { get; set; }
        public string? SoDT { get; set; } // ? nullable: cho phép rỗng
        public List<Dog> Dogs { get; set; } // Thể hiện quan hệ 1 người - nhiều chó


    }
}
