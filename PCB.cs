using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EVE_Managment_System
{
    public class PCB
    {
        public string Name { get; set; }
        public string Customer { get; set; }
        public string StartDate { get; set; }
        public string SubDate { get; set; }
        public string PType { get; set; }
        public int PNum { get; set; }
        public int PPNum { get; set; }
        public string Priority { get; set; }

        public PCB(string name, string customer, string startDate, string subDate, string pType, NumericUpDown pNum, NumericUpDown ppNum, string priority)
        {
          
            Name = name.ToUpper();
            Customer = customer.ToUpper();
            StartDate = startDate;
            SubDate = subDate;
            PType = pType;
            PNum = Convert.ToInt32(pNum.Value);
            PPNum = Convert.ToInt32(ppNum.Value);
            Priority = priority;

        }

      
    }


    
}
