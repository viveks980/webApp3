﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Interface
{
   public  interface UserInterface
    {
        ResponseModel adduser(RoleModel objmodel);
       
    }
}
