using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.interfaces
{
   public interface RegisterInterface
    {
        ResponseModel adduser(registerModel objmodel);
        ResponseModel loginUser(registerModel objmodel);
    }
}
