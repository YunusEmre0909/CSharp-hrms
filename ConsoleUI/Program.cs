using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployerTest();

            //JobPositionTest();

            //CityTest();
            JobAdvertisementManager jobAdvertisementManager = new JobAdvertisementManager(new EfJobAdvertisementDal());
            foreach (var advert in jobAdvertisementManager.GetAllDetail())
            {
                Console.WriteLine(advert.JobAdvertisemetId+"/"+advert.JobPosition+"/"+advert.CompanyName+"/"+
                    advert.NumberOfPosition+"/"+advert.ReleaseDate+"/"+advert.ApplicationDeadline);
            }
        }

        private static void CityTest()
        {
            CityManager cityManager = new CityManager(new EfCityDal());

            cityManager.Add(new City { CityName = "Adana" });
            foreach (var city in cityManager.GetAll())
            {
                Console.WriteLine(city.CityName);
            }
        }

        private static void JobPositionTest()
        {
            JobPositionManager jobPositionManager = new JobPositionManager(new EfJobPositinDal());

            foreach (var jobs in jobPositionManager.GetAll())
            {
                Console.WriteLine(jobs.JobName);
            }
        }

        private static void EmployerTest()
        {
           EmployerManager employerManager = new EmployerManager(new EfEmployerDal());
            employerManager.Add(new Employer { UserId = 2, CompanyName = "software team", Password = "54656", PhoneNumber = "654556454654", WebSite = "kjdskljflksjdlf" });
           foreach (var employer in employerManager.GetAll())
           {
                Console.WriteLine(employer.CompanyName);
            }
        }
    }
}
