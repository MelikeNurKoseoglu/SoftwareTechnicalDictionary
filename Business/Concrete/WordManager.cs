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
    public class WordManager : IWordService
    {
        IWordDal _wordDal;
        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }
        public IResult Add(Word word)
        {
            if (word.WordTitle.Length<2)
            {
                return new ErrorResult(Messages.WordTitleInvalid);
            }
            _wordDal.Add(word);
            return new SuccessResult(Messages.WordAdded);
        }

        public IDataResult<List<Word>> GetAll()
        {
            return new SuccessDataResult<List<Word>>(_wordDal.GetAll(),Messages.WordsListed);
        }

        public IDataResult<List<Word>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Word>>(_wordDal.GetAll(w => w.CategoryId == id));
        }

        public IDataResult<Word> GetById(int wordId)
        {
            return new SuccessDataResult<Word>(_wordDal.Get(w=>w.WordId==wordId));
        }

        public IResult Remove(Word word)
        {
            _wordDal.Delete(word);
            return new SuccessResult(Messages.WordDeleted);
        }

        public IResult Update(Word word)
        {
            _wordDal.Update(word);
            return new SuccessResult(Messages.WordUpdated);
        }
    }
}
