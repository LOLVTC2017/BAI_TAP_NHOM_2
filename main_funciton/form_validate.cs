using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_funciton
{
    public class form_validate
    {
        public Boolean CheckEmpty(string[] arr)
        {
            bool empty = false;
            foreach (string s in arr)
            {
                if (s.Length != 0)
                {
                    empty = true;
                }
                else
                {
                    empty = false;
                }
            }

            return empty;
        }
    }
}
