using System;
using System.Collections.Generic;

namespace Suites
{
    abstract class Suite
    {
        abstract public IEnumerable<Object> LaSuite(int nbDepart);
    }
}
