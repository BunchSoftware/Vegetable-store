using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace Итоговая_аттестация.Model
{
    public class FoodProduction : Production<FoodProduct, FoodProduction>
    {
        public delegate void Produced();
        public event Produced? ProducedEvent;


        public override FoodProduct CreateProduct()
        {
           return new FoodProduct();
        }


        public override void Produce()
        {
            ProducedEvent?.Invoke();
        }

        // Мои те самые 5 обобщенных методов

        public override FoodProduct UpdateNameProduct(FoodProduct Production, string Name)
        {
           Production.NameProduct = Name;
           return Production;
        }

        public override FoodProduct UpdatePriceProduct(FoodProduct Production, double Price)
        {
            Production.PriceProduct = Price;
            return Production;
        }

        public override FoodProduct UpdateDescriptionProduct(FoodProduct Production, string Description)
        {
            Production.DescriptionProduct = DescriptionProduct;
            return Production;
        }

        public override FoodProduct UpdateMeteringProduct(FoodProduct Production, string Metering)
        {
            Production.MeteringProduct = Metering;
            return Production;
        }

        public override FoodProduct UpdateUrlProduct(FoodProduct Production, BitmapImage urlProduct)
        {
            Production.urlProduct = urlProduct;
            return Production;
        }
    }
}
