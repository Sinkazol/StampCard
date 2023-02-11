using System.Diagnostics;

namespace StampCard;

public partial class MainPage : ContentPage
{
	int count = 0;
    public string barcode="";

	public MainPage()
	{
		InitializeComponent();
        //BindingContext = this;
    }

    //private void barcodeView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    //{
    //    var x = e.Results.FirstOrDefault()?.Value;
    //    if (x != null)
    //    {
    //        barcode = x.ToString();
    //    }


    //}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        
       

       // FillTheCup(count);
    }

   
}

