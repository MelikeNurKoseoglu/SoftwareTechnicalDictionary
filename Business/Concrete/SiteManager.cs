using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SiteManager : ISiteService
    {
        ISiteDal _siteDal;
        public SiteManager(ISiteDal siteDal)
        {
            _siteDal = siteDal;
        }

        public IResult Add(Site site)
        {
          
            _siteDal.Add(site);
            return new SuccessResult(Messages.SiteAdded);
        }

        public IResult Delete(Site site)
        {
            _siteDal.Delete(site);
            return new SuccessResult(Messages.SiteDeleted);
        }

        public IResult Update(Site site)
        {
            _siteDal.Update(site);
            return new SuccessResult(Messages.SiteUpdated);
        }
    }
}
