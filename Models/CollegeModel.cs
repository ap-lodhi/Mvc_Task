using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class CollegeModel
    {
        public int clg_id { get; set; }
        public string  CollegeName{ get; set;   }
        public int StudentName { get; set; }
        public int branchName { get; set; }
        public int RoleDesignation { get; set; }
        public decimal fees { get; set; }
        public DateTime AddmissionDate { get; set; }
        public Boolean Is_Payment { get; set; }
        public Boolean Is_active { get; set; }
    }
}
