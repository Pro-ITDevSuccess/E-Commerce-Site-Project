using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Entity.Services
{
    public class UsersReq
    {
        public virtual string FirstNameUser { get; set; }
        public virtual string LastNameUser { get; set; }
        public virtual DateTime BirthDayUser { get; set; }
        public virtual bool GenreUser { get; set; }
    }
}
