using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Bulb : FoodProduct
    {
        public Bulb(double price)
        {
            NameProduct = "Лук репчатый";
            DescriptionProduct = "Лук репчатый новый завоз. Лук не мытый. Цена указана за упаковку. В одной упаковке 0.7 кг. Урожай был собран 23.06.22. Был произведен на поле ООО 'ЛУК'. Хранить при температуре не ниже +6 градусов. ";
            PriceProduct = price;
            MeteringProduct = "за упаковку";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/bulb.png"));
        }
    }
}
