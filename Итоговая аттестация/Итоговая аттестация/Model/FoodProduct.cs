using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговая_аттестация.Model
{
    public class FoodProduct : Product<FoodProduct>
    {
        public delegate void Produced();
        public event Produced? ProducedEvent;

        public override void Produce()
        {
            ProducedEvent?.Invoke();
        }
    }
}
