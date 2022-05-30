using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWordService
    {
        IDataResult<List<Word>> GetAll();
        IDataResult<List<Word>> GetAllByCategoryId(int id);
        IResult Add(Word word);
        IDataResult<Word> GetById(int wordId);

        IResult Remove(Word word);
        IResult Update(Word word);

    }
}
