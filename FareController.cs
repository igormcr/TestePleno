using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;
using TestePleno.Services;

namespace TestePleno.Controllers
{
    public class FareController
    {
        private readonly OperatorService _operatorService;
        private readonly FareService FareService;

        public FareController()
        {
            _operatorService = new OperatorService();
            FareService = new FareService();
        }

        public void CreateFare(Fare fare, Operator op)
        {
            var selectedOperator = _operatorService.GetOperatorByCode(op);
            fare.OperatorId = selectedOperator.Id;


            FareService.Create(fare);
        }
    }
}
