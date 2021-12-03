using System;
using System.Collections.Generic;
using System.Text;

namespace ListaTelefonica.Execeptions
{
    class DomainExeception : ApplicationException
    {
        public DomainExeception(string message) : base(message)
        {
        }
    }
}
