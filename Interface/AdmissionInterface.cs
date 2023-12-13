using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Interface
{
    public interface AdmissionInterface
    {
        List<RoleModel> getRoleDesignation();
        List<DepartmentModel> getDepBranchName();
        List<StudentModel> getStudentName();
        ResponseModel addadmission(College objmodel);
        List<getCollege> getAdmissionDetails();
        getCollege editCollege(int clg_id);
        ResponseModel deleteCollege(int clg_id);
        ResponseModel updateCollege(College objmodel);
    }
}
