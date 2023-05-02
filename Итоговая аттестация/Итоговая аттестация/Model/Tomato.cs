using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Итоговая_аттестация.Model
{
    class Tomato : FoodProduct
    {
        public Tomato(double price)
        {
            NameProduct = "Помидоры";
            DescriptionProduct = "Помидоры красные гибридные. Помидоры не мытые. Цена указана за упаковку. В одной упаковке 0.7 кг. Урожай был собран 28.04.23. Был произведен на поле ООО 'ОвощСелРос'. Хранить при температуре не ниже +15 градусов.";
            PriceProduct = price;
            MeteringProduct = "за упаковку";
            urlProduct = new BitmapImage(new Uri("pack://application:,,,/Image/tomato.png"));
        }
    }
}
