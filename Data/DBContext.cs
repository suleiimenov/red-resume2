using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using red_resume.Models.Tasks;
using red_resume.Models.User;
using red_resume.Models.Role;
using red_resume.Models.UserRoleMap;
using red_resume.Models.Organization;
using red_resume.Models.Department;
using red_resume.Models.Comment;
using red_resume.Models.UserDepMap;

namespace red_resume.Data
{
public class DBContext : DbContext
{
    public DBContext(DbContextOptions options) : base(options)
    {
    }

        public DbSet<Tasks> Task { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }


        public DbSet<Organization> Organization { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<UserDepMap> UserDepMap { get; set; }
        
        public DbSet<UserRoleMap> UserRoleMap { get; set; }


    }
}
