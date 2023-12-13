using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class registerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string  emailId{ get; set; }
        public string encryptedPassword { get; set; }
        public string decryptedPassword { get; set; }

    }
}
 