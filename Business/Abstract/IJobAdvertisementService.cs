using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobAdvertisementService
    {
        List<JobAdvertisement> GetAll();
        List<JobAdvertisementDetailDto> GetAllDetail();
        JobAdvertisement GetById(int id);
        void Add(JobAdvertisement jobAdvertisement);
        void Delete(JobAdvertisement jobAdvertisement);
        void Update(JobAdvertisement jobAdvertisement);
    }
}
