using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class JobAdvertisement : IEntity
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public int JobPositionId { get; set; }
        public int CityId { get; set; }
        public string JobDescription { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int NumberOfPosition { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
