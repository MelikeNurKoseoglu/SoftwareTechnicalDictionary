using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Site: IEntity
    {
        public int SiteId { get; set; }
        public string SiteBaşlık { get; set; }
        public string SiteTitle { get; set; }
        public int SiteDesc { get; set; }
        public string SiteMail { get; set; }


    }
}
