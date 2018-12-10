using System;
using Microsoft.EntityFrameworkCore;
using Reach.Entity;

namespace Reach.Repository
{
    internal static class TuteeData
    {
       
        public static void Seed(this ModelBuilder builder)
        {

            builder.Entity<Address>().HasData(
            new Address
            {
                Id = 1,
                City = "Mumbai",
                PinCode = "400009",
                LandMark = "Ajwaa Sweets",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
                new Address
                {
                    Id = 2,
                    City = "Mumbai",
                    PinCode = "400003",
                    LandMark = "Saifee Hospital",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );

            builder.Entity<Tutee>().HasData(
                new Tutee
                {
                    Id=1,
                    FirstName = "basit",
                    LastName = "khan",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Contact = "9769718164",
                    IsDeleted = false,
                    Email = "basitkhan91@outlook.com",
                    AddressId = 1
                },
                new Tutee
                {
                    Id = 2,
                    FirstName = "Ahmer",
                    LastName = "Sidique",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Contact = "1234567890",
                    IsDeleted = false,
                    Email = "ahmer@domain.com",
                    AddressId = 2 
                }
            );
        }

    }
}


//public static void Seed1(ReachContext context)
//{
//    //context.Addresses.AddRange(


//    //);
//    context.Tutees.AddRange(
//        new Tutee
//        {
//            //Id = 1,
//            FirstName = "basit",
//            LastName = "khan",
//            CreatedBy = "Admin",
//            CreatedDate = DateTime.Now,
//            Contact = "9769718164",
//            IsDeleted = false,
//            Email = "basitkhan91@outlook.com",
//            Address = new Address
//            {
//                //Id = 1,
//                City = "Mumbai",
//                PinCode = "400009",
//                LandMark = "Ajwaa Sweets",
//                CreatedBy = "Admin",
//                CreatedDate = DateTime.Now,
//                IsDeleted = false,

//            }
//        },
//        new Tutee
//        {
//            //Id = 2,
//            FirstName = "Ahmer",
//            LastName = "Sidique",
//            CreatedBy = "Admin",
//            CreatedDate = DateTime.Now,
//            Contact = "1234567890",
//            IsDeleted = false,
//            Email = "ahmer@domain.com",
//            Address = new Address
//            {
//                //Id = 2,
//                City = "Mumbai",
//                PinCode = "400003",
//                LandMark = "Saifee Hospital",
//                CreatedBy = "Admin",
//                CreatedDate = DateTime.Now,
//                IsDeleted = false
//            }
//        }
//    );

//    context.SaveChanges();
//}
