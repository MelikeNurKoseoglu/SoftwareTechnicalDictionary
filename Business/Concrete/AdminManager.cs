using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public IResult Add(Admin admin)
        {
            if (admin.FirstName.Length < 4)
            {
                return new ErrorResult(Messages.AdmimNameInvalid);
            }
            _adminDal.Add(admin);
            return new SuccessResult(Messages.AdminAded);
        }

        public IDataResult<List<Admin>> GetAll()
        {
            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll(), Messages.AdminsListed);
        }

        public IResult Remove(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(Messages.AdminDeleted);
        }

        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(Messages.AdminUpdated);
        }
    }
}
