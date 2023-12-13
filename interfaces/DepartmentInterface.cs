using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.interfaces
{
  public  interface DepartmentInterface
    {
        ResponseModel Depuser(DeparmentModel M);
        List<DeparmentModel> getDepDetails();
        ResponseModel deleteDepListItem(int id);
        DeparmentModel editDepMaster(int Id);
        ResponseModel updateDepart(DeparmentModel dep);
    }
}
