using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_helloWorld.Models
{
    public class PersonDetailRepo : IPersonDetail
    {
        private readonly AppDbContext _appDbContext;

        public PersonDetailRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public PersonDetail AddDetail(PersonDetail personDetail)
        {
            var dbEntry = _appDbContext.PersonDetail.Add(personDetail).Entity;
            _appDbContext.SaveChanges();
            return dbEntry;
        }
    }
}
