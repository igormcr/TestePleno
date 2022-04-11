using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;
using TestePleno.Controllers;
using TestePleno.Services;

namespace TestePleno.Services
{
    public class FareService
    {
        private Repository _repository = new Repository();

        public void Create(Fare Insertingfare)
        {
 
            _repository.Insert(Insertingfare);
        }

        public void Update(Fare Updatingfare)
        {

            _repository.Update(Updatingfare);
        }

        public Fare GetFareById(Guid fareId)
        {
            var fare = _repository.GetById<Fare>(fareId);
            return fare;
        }

        public List<Fare> GetFares()
        {
            var fares = _repository.GetAll<Fare>();
            return fares;
        }
    }
}
