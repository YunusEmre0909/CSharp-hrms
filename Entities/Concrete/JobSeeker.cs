using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class JobSeeker : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}
