using Business.Concrete;
using DataAccess.Concrete.EntitityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployerTest();

            JobPositionManager jobPositionManager = new JobPositionManager(new EfJobPositinDal());

            foreach (var jobs in jobPositionManager.GetAll())
            {
                Console.WriteLine(jobs.JobName);
            }
        }

        //private static void EmployerTest()
        //{
        //    EmployerManager employerManager = new EmployerManager(new EfEmployerDal());
        //    employerManager.Add(new Employer { UserId = 2, CompanyName = "software team", Password = "54656", PhoneNumber = "654556454654", WebSite = "kjdskljflksjdlf" });
        //    foreach (var employer in employerManager.GetAll())
        //    {
        //        Console.WriteLine(employer.CompanyName);
        //    }
        //}
    }
}
