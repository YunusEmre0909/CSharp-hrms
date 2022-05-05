using Business.Concrete;
using DataAccsess.Concrete.EntitityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployerManager employerManager = new EmployerManager(new EfEmployerDal());
            foreach (var employer in employerManager.GetAllByUserId(1))
            {
                Console.WriteLine(employer.CompanyName);
            }
        }
    }
}
