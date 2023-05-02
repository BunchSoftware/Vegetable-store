using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Sausage : FoodProduct
    {
        public Sausage(double price)
        {
            NameProduct = "Колбасная нарезка";
            DescriptionProduct = "Колбасная нарезка: салями, сыровяленая, вареная, полукопченая. Масса нетто: 0,6 кг. Срок годности: 30 суток. Изготовлено и упаковано: дата указана на упаковке. Калорийность: на 100 грамм продукта 400 ккал.";
            PriceProduct = price;
            MeteringProduct = "шт";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/sausage.png"));
        }
    }
}
