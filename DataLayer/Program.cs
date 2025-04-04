﻿using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser("user", "password", "email", UserRolesEnum.STUDENT));
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.ReadKey();
            }
        }
    }
}