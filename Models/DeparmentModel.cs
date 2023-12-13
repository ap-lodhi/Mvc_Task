using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class DeparmentModel
    {
        public int Branch_id { get; set; }
        public string Branch_name { get; set; }
        public string Hod_name { get; set; }
        public DateTime created_date { get; set; }
        public Boolean Is_active { get; set; }
    }
}
