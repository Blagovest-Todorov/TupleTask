using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TFirst, TSecond>
    {
        public Tuple(TFirst firstElem, TSecond secElem)
        {
            FirstElem = firstElem;
            SecElement = secElem;
        }

        public TFirst FirstElem { get; private set; }
        public TSecond SecElement { get; private set; }

        public override string ToString()
        {
            return $"{FirstElem} -> {SecElement}";
        }
    }
}
