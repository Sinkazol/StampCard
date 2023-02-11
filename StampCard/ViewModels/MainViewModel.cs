using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;

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
        private ICommand addCoffee;

        public MainViewModel()
        {
            addCoffee = new RelayCommand(_AddCoffee);
            ButtonText= "START";
            ButtonColor=Colors.Black;
        }

        private void _AddCoffee()
        {
            NumberOfCoffee++;

            if (NumberOfCoffee == 1)
                ButtonText = $" {NumberOfCoffee} Coffee";
            else
                ButtonText = $" {NumberOfCoffee} Coffees";

            if (NumberOfCoffee >= 10)
            {
                NumberOfCoffee = 0;
                ButtonColor = Colors.Black;
                ButtonText = $"START";
            }
            if (NumberOfCoffee == 9)
            {
                ButtonColor = Colors.Red;
                ButtonText = $"FREE COFFEE";
            }

            
        }

    }
}
