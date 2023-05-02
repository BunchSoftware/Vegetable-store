using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Cucumber : FoodProduct
    {
        public Cucumber(double price)
        {
            NameProduct = "Огурцы";
            DescriptionProduct = "Огурцы пупырчатые новый завоз. Огурцы не мытые. Цена указана за упаковку. В одной упаковке 0.7 кг. Урожай был собран 06.08.22. Был произведен на поле ООО 'ОвощСелРос'. Хранить при температуре не ниже +8 градусов.";
            PriceProduct = price;
            MeteringProduct = "за упаковку";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/cucumber.png"));
        }
    }
}
