using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using StampCard.DataStore;

namespace StampCard.ViewModels
{
   
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int numberOfCoffee;

        [ObservableProperty]
        private string buttonText;

        [ObservableProperty]
        private Color buttonColor;

        [ObservableProperty]
        private bool cupShow;

        [ObservableProperty]
        private bool camShow;

        [ObservableProperty]
        private ICommand addCoffee;

        private DateTime dateTime;

        private const string MYCODE = "2022";

        private string qrCode;
        public string QrCodeReaded
        {
            get => MYCODE;
            set
            {
                qrCode = value;
                if ((DateTime.Now-dateTime) > TimeSpan.FromSeconds(5) )
                {
                    dateTime = DateTime.Now;

                    if(qrCode == MYCODE && CamShow == true )
                    {
                        NumberOfCoffee++;
                        if (NumberOfCoffee < 9)
                        ButtonText = $" Scan ";

                        if (NumberOfCoffee == 10)
                        {
                            NumberOfCoffee = 0;
                            ButtonColor = Colors.Black;
                            ButtonText = $" Scan ";
                        }
                        if (NumberOfCoffee == 9)
                        {
                            ButtonColor = Colors.Red;
                            ButtonText = $"FREE COFFEE";
                        }
                        coffeStore.Save(NumberOfCoffee);
                        CupShow = true;
                        CamShow = false;
                        
                    }
                }
            }
        }

        private readonly CoffeStore coffeStore;

        public MainViewModel()
        {
            addCoffee = new RelayCommand(_AddCoffee);
            ButtonText= "Scan";
            ButtonColor=Colors.Black;
            coffeStore = new CoffeStore();
            NumberOfCoffee = coffeStore.Read();
            dateTime = DateTime.Now;
            CupShow = true;
            CamShow = false;
        }

        private void _AddCoffee()
        {                    
            if (!CamShow)
            {
                CupShow = false;
                CamShow = true;
                ButtonText = "EXIT";
            }
            else
            {
                CupShow = true;
                CamShow = false;
                ButtonText = "Scan";
            }
        }

    }
}
