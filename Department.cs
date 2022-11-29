using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Demo
{
   [Serializable]
   public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string location { get; set; }
    }
}
