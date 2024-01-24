using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Cerchio
    {
        public float Raggio { get; set; }
        public float AreaCerchio()
        {
            return (float)(Raggio * Raggio * Math.PI);
        }
        public float Circonferenza()
        {
            return (float)(Raggio * 2 * Math.PI);
        }
        public override string ToString()
        {
            return string.Format("Cerchio di raggio {0}", Raggio);
        }
    }
}
