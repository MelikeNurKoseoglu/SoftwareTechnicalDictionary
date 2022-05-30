using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Word: IEntity
    {
        public int WordId { get; set; }
        public string Photo { get; set; }
        public string WordTitle { get; set; }
        public string WordKeyword { get; set; }
        public string KısaAçıklama { get; set; }
        public string UzunAçıklama { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; } 

    }
}
