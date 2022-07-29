using BAI_4_EFCore_CodeFirst.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_EFCore_CodeFirst.A_DAL.Responstories
{
    internal class HumanRes
    {
        DogManagerContext context = new DogManagerContext();
        public HumanRes()
        {

        }
        public  List<Human> GetAllHuman()
        {
            return context.Humans.ToList(); 
        }
        public bool AddHuman(Human c)
        {
            try
            {
                context.Humans.Add(c);
                context.SaveChanges();
                return true;               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool DeleteHuman(string cmt)
        {
            try
            {
                Human hm = context.Humans.SingleOrDefault(c => c.CMT == cmt);
                context.Humans.Remove(hm);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }




    }
}
