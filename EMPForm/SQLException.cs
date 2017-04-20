using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPForm
{
    class SQLException : Exception
    {
        public SQLException()
        {

        }

        public SQLException(string message): base(message)
        {

        }

        public SQLException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
