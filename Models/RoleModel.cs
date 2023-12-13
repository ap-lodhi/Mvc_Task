using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class RoleModel
    {
        public int Role_id { get; set; }
        public string Role_name { get; set; }
        public string Role_designation { get; set; }
        public DateTime created_date { get; set; }
        public Boolean Is_active { get; set; }
        
    }
}
