using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class RegisterModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string userId { get; set; }
        public string encryptedPassword { get; set; }
        public string decryptedPassword { get; set; }
       
    }
    public class RoleModel
    {
        public int Role_id { get; set; }
        public string Role_name { get; set; }
        public string Role_designation { get; set; }
        public DateTime created_date { get; set; }
        public Boolean Is_active { get; set; }

    }
    public class DepartmentModel
    {
        public int branchId { get; set; }
        public string branchName { get; set; }
        public string hodName { get; set; }
        public Boolean isActive { get; set; }

    }
    public class StudentModel
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string session { get; set; }
        public string email{ get; set; }
        public int phoneNo { get; set; }
        public Boolean isDeleted { get; set; }
        public Boolean isActive { get; set; }

    }
}
