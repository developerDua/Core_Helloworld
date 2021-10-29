using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_helloWorld.Models
{
    public interface IPersonDetail
    {
        PersonDetail AddDetail(PersonDetail personDetail);
    }
}
