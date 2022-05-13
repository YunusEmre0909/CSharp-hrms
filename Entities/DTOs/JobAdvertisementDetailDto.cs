using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class JobAdvertisementDetailDto
    {
        public int JobAdvertisemetId { get; set; }
        public string  CompanyName { get; set; }
        public string  JobPosition { get; set; }
        public int NumberOfPosition { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
    }
}
