using CommunityToolkit.Maui.Alerts;
using StampCard.ViewModels;
using System.Diagnostics;

namespace StampCard;

public partial class MainPage : ContentPage
{

    private readonly MainViewModel vm;

    public MainPage()
    {
        InitializeComponent();
        vm = (MainViewModel)BindingContext;
        FillTheCup(vm.NumberOfCoffee);
        vm.PropertyChanged += Vm_PropertyChanged;
    }

    private void Vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        try
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                FillTheCup(vm.NumberOfCoffee);
            });
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void barcodeView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        var x = e.Results.FirstOrDefault()?.Value;
        if (x != null)
        {
            vm.QrCodeReaded = x.ToString();
        }
    }


    public void FillTheCup(int number)
    {
               

        
        switch (number)
        {
            case 0:
                cup.Source = "c0";
                break;
            case 1:
                cup.Source = "c1";
                break;
            case 2:
                cup.Source = "c2";
                break;
            case 3:
                cup.Source = "c3";
                break;
            case 4:
                cup.Source = "c4";
                break;
            case 5:
                cup.Source = "c5";
                break;        
            case 6:
                cup.Source = "c6";
                break;          
            case 7:
                cup.Source = "c7";
                break;          
            case 8:
                cup.Source = "c8";
                break;          
            case 9:
                cup.Source = "c9";
                break; 
            case 10:
              
               cup.Source = "c0";
                break;
        }

    }
    public void FillTheCup2(int number)
    {



        //first version
        //if (number == 0)
        //{
        //    a1.Source = "emty1.svg";
        //    a2.Source = "emty2.svg";
        //    a3.Source = "emty3.svg";
        //    a4.Source = "emty4.svg";
        //    a5.Source = "emty5.svg";
        //    a6.Source = "emty6.svg";
        //    a7.Source = "emty7.svg";
        //    a8.Source = "emty8.svg";
        //    a9.Source = "emty9.svg";
        //}
        //if (number == 1) a1.Source = "coffee1.svg";
        //if (number == 2)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //}
        //if (number == 3)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //}
        //if (number == 4)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //    a4.Source = "coffee4.svg";
        //}
        //if (number == 5)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //    a4.Source = "coffee4.svg";
        //    a5.Source = "coffee5.svg";
        //}
        //if (number == 6)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //    a4.Source = "coffee4.svg";
        //    a5.Source = "coffee5.svg";
        //    a6.Source = "coffee6.svg";
        //}
        //if (number == 7)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //    a4.Source = "coffee4.svg";
        //    a5.Source = "coffee5.svg";
        //    a6.Source = "coffee6.svg";
        //    a7.Source = "coffee7.svg";
        //}
        //if (number == 8)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //    a4.Source = "coffee4.svg";
        //    a5.Source = "coffee5.svg";
        //    a6.Source = "coffee6.svg";
        //    a7.Source = "coffee7.svg";
        //    a8.Source = "coffee8.svg";
        //}
        //if (number == 9)
        //{
        //    a1.Source = "coffee1.svg";
        //    a2.Source = "coffee2.svg";
        //    a3.Source = "coffee3.svg";
        //    a4.Source = "coffee4.svg";
        //    a5.Source = "coffee5.svg";
        //    a6.Source = "coffee6.svg";
        //    a7.Source = "coffee7.svg";
        //    a8.Source = "coffee8.svg";
        //    a9.Source = "coffee9.svg";
        //}


    }
}

