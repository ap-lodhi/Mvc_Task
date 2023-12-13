using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.interfaces
{
  public interface RoleInterface
    {
        ResponseModel roleuser(RoleModel M);
        List<RoleModel> getRoleDetails();
        ResponseModel deleteRoleListItem(int id);
        RoleModel editRoleMater(int Id);
        ResponseModel updateRole(RoleModel objmodel);
    }
}
