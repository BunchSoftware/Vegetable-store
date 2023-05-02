using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Sourcream : FoodProduct
    {
        public Sourcream(double price)
        {
            NameProduct = "Сметана";
            DescriptionProduct = "Сметана жирности 15%. Масса нетто: 0,5 кг. Срок годности: 7 суток. Изготовлено и упаковано: дата указана на крышке. В 100 граммах сметаны жирностью 15 процентов содержится 142 ккал.";
            PriceProduct = price;
            MeteringProduct = "шт";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/sourcream.png"));
        }
    }
}
