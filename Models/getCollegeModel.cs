using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class getCollegeModel
    {

        public int clg_id { get; set; }
        public string collegeName { get; set; }
        public string Student_fisrt_Name { get; set; }
        public string Role_designation { get; set; }
        public  string  Branch_name { get; set; }
        public decimal fees { get; set; }
        public DateTime AddmissionDate { get; set; }
        public Boolean Is_Payment { get; set; }
        public Boolean Is_active { get; set; }
    }
}
