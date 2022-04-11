using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;

namespace TestePleno.Models

{
    public interface IModel
    {
        Guid Id { get; set; }
    }
}
