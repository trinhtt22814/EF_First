using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_EFCore_CodeFirst.A_DAL.Models
{
    internal class Dog
    {
        [Key]
        public int ID { get; set; }
        public string TenCho { get; set; }
        public string GiongCho { get; set; }
        public int Tuoi { get; set; }
        public bool GioiTinh { get; set; }
        


    }
}
