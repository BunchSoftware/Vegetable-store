using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Milk : FoodProduct
    {
        public Milk(double price)
        {
            NameProduct = "Молоко";
            DescriptionProduct = "Пастеризованное молоко. Масса нетто: 0,9 кг. Срок годности: 2 суток. Изготовлено и упаковано: дата указана на упаковке. Молоко пищевой продукт, содержащий более 100 питательных веществ, включая белки, жир, молочный сахар, минеральные вещества, фосфолипиды, органические кислоты, витамины, ферменты.";
            PriceProduct = price;
            MeteringProduct = "шт";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/milk.png"));
        }
    }
}
