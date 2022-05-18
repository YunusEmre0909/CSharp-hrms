using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfJobAdvertisementDal : EfEntityRepositoryBase<JobAdvertisement, HrmsContext>, IJobAdvertisementDal
    {
        public List<JobAdvertisementDetailDto> GetAllDetail(Expression<Func<JobAdvertisementDetailDto,bool>>filter=null)
        {
            using (HrmsContext context = new HrmsContext())
            {
                var result = from j in context.JobAdvertisements
                             join e in context.Employers on j.EmployerId equals e.Id
                             join jp in context.JobPositions on j.JobPositionId equals jp.Id
                             select new JobAdvertisementDetailDto
                             {
                                 JobAdvertisemetId = j.Id,
                                 CompanyName = e.CompanyName,
                                 JobPosition = jp.JobName,
                                 NumberOfPosition = j.NumberOfPosition,
                                 ReleaseDate = j.ReleaseDate,
                                 ApplicationDeadline = j.ApplicationDeadline
                             };
                return filter is null? result.ToList() : result.Where(filter).ToList();
            }

        }

        
    }
}

