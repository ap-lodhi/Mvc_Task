using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class StudentModel
    {
        public int Student_id { get; set; }
        public string Student_fisrt_Name { get; set; }
        public string Student_Last_Name { get; set; }
        public string Student_Email { get; set; }
        public string Student_Phone { get; set; }
        public string Student_Session { get; set; }
        public DateTime created_date { get; set; }
        public Boolean Is_active { get; set; }
        public Boolean Is_Deleted { get; set; }
    }
}
