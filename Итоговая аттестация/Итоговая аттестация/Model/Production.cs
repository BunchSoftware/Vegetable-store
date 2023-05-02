using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    public abstract class Production <T,P> where T : Product<T> where P : Production<T,P>
    {
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public double PriceProduct { get; set; }
        public BitmapImage urlProduct { get; set; }
        public string MeteringProduct { get; set; }

        public abstract T CreateProduct();

        // Мои те самые 5 обобщенных методов
        public abstract T UpdateNameProduct(T Production, string Name);
        public abstract T UpdatePriceProduct(T Production, double Price);
        public abstract T UpdateDescriptionProduct(T Production, string Description);
        public abstract T UpdateMeteringProduct(T Production, string Metering);
        public abstract T UpdateUrlProduct(T Production, BitmapImage urlProduct);

        public abstract void Produce();
    }
}
