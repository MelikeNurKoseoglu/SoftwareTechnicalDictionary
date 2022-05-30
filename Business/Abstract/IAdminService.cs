using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        IDataResult<List<Admin>> GetAll();
        IResult Add(Admin admin);
        IResult Remove(Admin admin);
        IResult Update(Admin admin);

    }
}
