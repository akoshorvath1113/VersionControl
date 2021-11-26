using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gyakolas3.Abstractions;

namespace Gyakolas3.Entities
{
   public class Ballfactory : Abstractions.IToyFactory
   {
        public Toy CreateNew()
        {
           return new Ball();
        }
   }
}
