using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.interfaces
{
 public   interface DropDownInterface
    {
        List<RoleModel> getRoleDesignation();
        List<DeparmentModel> getDepBranchName();
        List<StudentModel> getStudentName();
        ResponseModel addadmission(CollegeModel objmodel);
        List<getCollegeModel> getCollege();
        ResponseModel deleteClgListItem(int id);
        getCollegeModel editCollegeMater(int Id);
        ResponseModel updateCollege(CollegeModel M);
        List<getCollegeModel> getCollegeList(DateTime? fromDate, DateTime ? toDate);
    }
}
