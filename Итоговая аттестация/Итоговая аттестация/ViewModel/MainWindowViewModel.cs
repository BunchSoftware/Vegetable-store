using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Итоговая_аттестация.Core;
using Итоговая_аттестация.Model;

namespace Итоговая_аттестация.ViewModel
{
    class MainWindowViewModel : ObservableObject
    {
        private MainWindowModel model;
        private MainWindow view;

        public string Amount
        {
            get
            {
                return model.Amount.ToString();
            }
        }

        public string CurrentNameProduct 
        { 
            get => model.CurrentNameProduct; 
        }
        public string CurrentDescriptionProduct 
        { 
            get => model.CurrentDescriptionProduct; 
        }
        public string CurrentPriceProduct 
        { 
            get => $"Цена: {model.CurrentPriceProduct} ₽/{model.CurrentMeteringProduct}."; 
        }
        public BitmapImage CurrentUrlProduct 
        { 
            get => model.CurrentUrlProduct; 
        }


        private RelayCommand addAmountCommand;
        public RelayCommand AddAmountCommand
        {
            get
            {
                return addAmountCommand ??
                  (addAmountCommand = new RelayCommand(obj =>
                  {
                      model.AddAmount(1);
                      view.Result.Text = $"Итог: {Math.Round(model.Amount * model.CurrentPriceProduct, 2)} ₽";
                      OnPropertyChanged(nameof(Amount));
                  }));
            }
        }

        private RelayCommand decreaseAmountCommand;
        public RelayCommand DecreaseAmountCommand
        {
            get
            {
                return decreaseAmountCommand ??
                  (decreaseAmountCommand = new RelayCommand(obj =>
                  {
                      model.AddAmount(-1);
                      view.Result.Text = $"Итог: {Math.Round(model.Amount * model.CurrentPriceProduct, 2)} ₽";
                      OnPropertyChanged(nameof(Amount));
                  }));
            }
        }

        private RelayCommand buyCommand;
        public RelayCommand BuyCommand
        {
            get
            {
                return buyCommand ??
                  (buyCommand = new RelayCommand(obj =>
                  {
                      model.ResetAmountProduct();
                      view.Result.Text = $"Итог: {Math.Round(model.Amount * model.CurrentPriceProduct, 2)} ₽";
                      OnPropertyChanged(nameof(Amount));
                  }));
            }
        }

        private RelayCommand forwardProductCommand;
        public RelayCommand ForwardProductCommand
        {
            get
            {
                return forwardProductCommand ??
                  (forwardProductCommand = new RelayCommand(obj =>
                  {
                      model.NextProduct(1);
                      model.ResetAmountProduct();
                      view.Result.Text = $"Итог: 0 ₽";
                      OnPropertyChanged(nameof(Amount));
                      OnPropertyChanged(nameof(CurrentNameProduct));
                      OnPropertyChanged(nameof(CurrentPriceProduct));
                      OnPropertyChanged(nameof(CurrentDescriptionProduct));
                      OnPropertyChanged(nameof(CurrentUrlProduct));
                      view.Result.Text = $"Итог: {Math.Round(model.Amount * model.CurrentPriceProduct, 2)} ₽";
                  }));
            }
        }
        
        private RelayCommand backProductCommand;
        public RelayCommand BackProductCommand
        {
            get
            {
                return backProductCommand ??
                  (backProductCommand = new RelayCommand(obj =>
                  {
                      model.NextProduct(-1);
                      model.ResetAmountProduct();
                      OnPropertyChanged(nameof(Amount));
                      OnPropertyChanged(nameof(CurrentNameProduct));
                      OnPropertyChanged(nameof(CurrentPriceProduct));
                      OnPropertyChanged(nameof(CurrentDescriptionProduct));
                      OnPropertyChanged(nameof(CurrentUrlProduct));
                      view.Result.Text = $"Итог: {Math.Round(model.Amount * model.CurrentPriceProduct, 2)} ₽";
                  }));
            }
        }

        public MainWindowViewModel(MainWindow view)
        {
            model = new MainWindowModel();
            this.view = view;
            view.Result.Text = $"Итог: {Math.Round(model.Amount * model.CurrentPriceProduct, 2)} ₽";
        }
    }
}
