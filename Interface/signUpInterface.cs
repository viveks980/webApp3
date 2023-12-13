using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Interface
{
    public interface signUpInterface
    {
        ResponseModel adduser(RegisterModel objmodel);
        ResponseModel loginUser(RegisterModel objmodel);
        ResponseModel adddepartment(DepartmentModel objmodel);
        ResponseModel addstudent(StudentModel objmodel);
        List<DepartmentModel> getDepDetails();
        List<StudentModel> getStudentDetails();
        List<RoleModel> getRoleDetails();
        ResponseModel deleteDepartment(int branchId);
        ResponseModel deleteRole(int Role_id);
        ResponseModel deleteStudent(int studentId);
        StudentModel editStudent(int studentId);
        RoleModel editRole(int Role_id);
        DepartmentModel editDepartment(int branchId);
        ResponseModel updateDepartment(DepartmentModel objmodel);
        ResponseModel updateRole(RoleModel objmodel);
        ResponseModel updateStudent(StudentModel objmodel);
    }
}
