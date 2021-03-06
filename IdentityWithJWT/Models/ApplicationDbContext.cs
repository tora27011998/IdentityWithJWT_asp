﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityWithJWT.Api.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}


/* 
 * 
 * IdentityDbContext khong thay xai` trong pcc?
   aspnetroleclaim: contain all the claims that are related to the role in 
   aspnetuserclaim: contain the claims of the user login  
     
     */