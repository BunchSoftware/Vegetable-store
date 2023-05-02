using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Cabbage : FoodProduct
    {
        public Cabbage(double price)
        {
            NameProduct = "Белокочанная капуста";
            DescriptionProduct = "Белокочанная капуста новый завоз. Капуста мытая. Цена указана за упаковку. В одной упаковке 0.7 кг. Урожай был собран 12.01.23. Был произведен на поле ООО 'ОвощСелРос'. Хранить при температуре не ниже +10 градусов.";
            PriceProduct = price;
            MeteringProduct = "за упаковку";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/cabbage.png"));
        }
    }
}
