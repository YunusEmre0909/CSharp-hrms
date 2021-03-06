using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IJobAdvertisementDal : IEntityRepository<JobAdvertisement>
    {
        List<JobAdvertisementDetailDto> GetAllDetail(Expression<Func<JobAdvertisementDetailDto, bool>> filter = null);

        
    }
}
