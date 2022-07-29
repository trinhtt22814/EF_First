using BAI_4_EFCore_CodeFirst.A_DAL.Models;
using BAI_4_EFCore_CodeFirst.A_DAL.Responstories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_EFCore_CodeFirst.B_BUS.Services
{
    internal class HumanServices
    {
        HumanRes humanRespo = new HumanRes();
        public List<Human> ShowAllHuman()
        {
            return humanRespo.GetAllHuman();
        }
        public string CreateNewHuman(string cmt, string ten, DateTime ngaysinh, bool gioitinh, string diachi, string sdt)
        {
            Human hm = new Human();
            hm.CMT = cmt;
            hm.Ten = ten;
            hm.NgaySinh = ngaysinh;
            hm.GioiTinh = gioitinh;
            hm.DiaChi = diachi;
            hm.SoDT = sdt;
            if (humanRespo.AddHuman(hm))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string DeleteHuman(string cmt)
        {
            if (humanRespo.DeleteHuman(cmt))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

    }
}
