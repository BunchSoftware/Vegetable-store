using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Итоговая_аттестация.Core;

namespace Итоговая_аттестация.Model
{
    class Menu : ObservableObject
    {
        private int amount = 1;
        public int Amount { get => amount; }

        private FoodProduct currentProduct;
        public FoodProduct CurrentProduct { get => currentProduct; }

        private int index;
        public int Index { get => index; }

        private string currentNameProduct;
        private string currentDescriptionProduct;
        private double currentPriceProduct;
        private BitmapImage currentUrlProduct;
        private string currentMeteringProduct;

        public string CurrentNameProduct { get => currentNameProduct; }
        public string CurrentDescriptionProduct { get => currentDescriptionProduct; }
        public double CurrentPriceProduct { get => currentPriceProduct; }
        public BitmapImage CurrentUrlProduct { get => currentUrlProduct; }
        public string CurrentMeteringProduct { get => currentMeteringProduct; }

        private List<FoodProduct> foodProducts;


        public void AddAmount(int addAmount)
        {
            if ((amount + addAmount) >= 0 & (amount + addAmount) < 1000)
                amount += addAmount;
        }

        public void NextProduct(int step)
        {
            if ((index + step) < 0)
            {
                index = foodProducts.Count - 1;
                ChangeDataProduct(index);
            }
            else if ((index + step) == foodProducts.Count)
            {
                index = 0;
                ChangeDataProduct(index);
            }
            else
            {
                if ((index + step) >= 0 & (index + step) < foodProducts.Count)
                {
                    index += step;
                    ChangeDataProduct(index);
                }
            }
        }

        private void ChangeDataProduct(int index)
        {
            currentUrlProduct = foodProducts[index].urlProduct;
            currentProduct = foodProducts[index];
            currentNameProduct = foodProducts[index].NameProduct;
            currentDescriptionProduct = foodProducts[index].DescriptionProduct;
            currentPriceProduct = foodProducts[index].PriceProduct;
            currentMeteringProduct = foodProducts[index].MeteringProduct;
        }

        public void ResetAmountProduct()
        {
            amount = 1;
        }

        public Menu()
        {
            foodProducts = new List<FoodProduct>()
            {
                new Broad(26), 
                new Milk(50),
                new Sourcream(100),
                new Sausage(255),
                new Tomato(125.40),
                new Cucumber(99.99),
                new Bulb(55.65),
                new Cabbage(13.55),
            };

            index = 0;
            ChangeDataProduct(index);
        }
    }
}
