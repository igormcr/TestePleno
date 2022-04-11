using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;
using TestePleno.Services;

namespace TestePleno.Controllers
{
    public class OperatorController
    {
        private OperatorService _operatorService;
        private FareService FareService;

        public OperatorController()
        {
            _operatorService = new OperatorService();
        }

        public void CreateOperator(Operator op)
        {
            _operatorService.Create(op);

        }
    }
}
