using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_NET.Pyramid
{
    public class NotValidPyramidExeption: Exception
    {
        public NotValidPyramidExeption(string message) : base(message) { }
    }
}
