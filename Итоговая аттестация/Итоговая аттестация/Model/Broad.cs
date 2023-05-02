using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Broad : FoodProduct
    {
        public Broad(double price) 
        {
            NameProduct = "Хлеб";
            DescriptionProduct = "Масса нетто: 0,7 кг. Срок годности: 3 суток.  Изготовлено и упаковано: дата указана на зажиме. Хлеб, приготовленный по артизанской технологии. Состав продукта: мука пшеничная в/сорта, масло подсолнечное, вода, сахар, соль, дрожжи.";
            PriceProduct = price;
            MeteringProduct = "шт";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/broad.png"));
        }
    }
}
