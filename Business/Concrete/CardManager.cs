using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
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
    public class CardManager : ICardService
    {
        ICardDal _cardDal;
        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public IResult Add(Card creditCard)
        {
            _cardDal.Add(creditCard);
            return new SuccessResult(Messages.CardAdded);
        }

        public IResult Delete(Card creditCard)
        {
            _cardDal.Delete(creditCard);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll());
        }

        public IDataResult<List<Card>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(c => c.CustomerId == customerId));
        }

        public IDataResult<Card> GetById(int id)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(c => c.Id == id));
        }
    }
}
