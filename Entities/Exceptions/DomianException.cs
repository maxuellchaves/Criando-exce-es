using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_exceções.Entities.Exceptions
{
    class DomianException:ApplicationException
    {
        public DomianException(string message) : base(message)
        {

        }
    }
}
