using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.interfaces
{
    interface StudentInterface
    {
        ResponseModel addStudent(StudentModel M);
        List<StudentModel> getStuDetails();
        ResponseModel deleteStuListItem(int id);
        StudentModel editStudentMater(int Id);

        ResponseModel updateStudent(StudentModel M);
    }
}
