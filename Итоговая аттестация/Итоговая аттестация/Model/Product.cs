using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    public abstract class Product <T> where T : Product<T>
    {
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public double PriceProduct { get; set; }
        public BitmapImage urlProduct { get; set; }
        public string MeteringProduct { get; set; }
        public abstract void Produce();
    }
}
