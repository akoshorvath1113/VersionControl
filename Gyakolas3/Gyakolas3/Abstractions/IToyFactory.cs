using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gyakolas3.Entities;

namespace Gyakolas3.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
