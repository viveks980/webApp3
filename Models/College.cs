using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class College
    {
            public int clg_id { get; set; }
            public string CollegeName { get; set; }
            public int StudentName { get; set; }
            public int branchName { get; set; }
            public int RoleDesignation { get; set; }
            public decimal fees { get; set; }
            public DateTime AddmissionDate { get; set; }
            public Boolean Is_Payment { get; set; }
            public Boolean Is_active { get; set; }

        }
            public class getCollege
        {
        public int OrderId { get; set; }
        public decimal fees { get; set; }
        public DateTime OrderDate { get; set; }
        public Boolean OrderStatus { get; set; }
        
        public string name { get; set; }
        public string address { get; set; }
       

    }
    }

