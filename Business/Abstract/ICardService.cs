using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICardService
    {
        IDataResult<Card> GetById(int id);
        IDataResult<List<Card>> GetAll();
        IDataResult<List<Card>> GetAllByCustomerId(int customerId);
        IResult Add(Card card);

        IResult Delete(Card card);
    }
}
