//using static Java.IO.ObjectOutputStream;

namespace StampCard;

public partial class CoffeeView : ContentView
{
    //public static readonly BindableProperty CoffeeNumProperty = BindableProperty.Create(nameof(CoffeeNum),
    //    typeof(int),
    //    typeof(CoffeeView),
    //    0,
    //    BindingMode.TwoWay);

    //public int CoffeeNum
    //{
    //    get => (int)GetValue(CoffeeNumProperty);
    //    set
    //    {
    //        FillTheCup(value);
    //        SetValue(CoffeeNumProperty, value);
    //    }
    //}

    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
       typeof(string),
       typeof(CoffeeView),
       string.Empty,
       BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    int coffeenum;
    public int CoffeeNum
    {
        get => coffeenum;
        set
        {
            FillTheCup(value);
            coffeenum=value;
        }
    }
    public CoffeeView()
	{
		InitializeComponent();
        //this.BindingContext= this;
	}

    public void FillTheCup(int number)
    {
        if (number == 0)
        {
            a1.Source = "emty1.svg";
            a2.Source = "emty2.svg";
            a3.Source = "emty3.svg";
            a4.Source = "emty4.svg";
            a5.Source = "emty5.svg";
            a6.Source = "emty6.svg";
            a7.Source = "emty7.svg";
            a8.Source = "emty8.svg";
            a9.Source = "emty9.svg";
        }
        if (number == 1) a1.Source = "coffee1.svg";
        if (number == 2)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
        }
        if (number == 3)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
        }
        if (number == 4)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
            a4.Source = "coffee4.svg";
        }
        if (number == 5)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
            a4.Source = "coffee4.svg";
            a5.Source = "coffee5.svg";
        }
        if (number == 6)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
            a4.Source = "coffee4.svg";
            a5.Source = "coffee5.svg";
            a6.Source = "coffee6.svg";
        }
        if (number == 7)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
            a4.Source = "coffee4.svg";
            a5.Source = "coffee5.svg";
            a6.Source = "coffee6.svg";
            a7.Source = "coffee7.svg";
        }
        if (number == 8)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
            a4.Source = "coffee4.svg";
            a5.Source = "coffee5.svg";
            a6.Source = "coffee6.svg";
            a7.Source = "coffee7.svg";
            a8.Source = "coffee8.svg";
        }
        if (number == 9)
        {
            a1.Source = "coffee1.svg";
            a2.Source = "coffee2.svg";
            a3.Source = "coffee3.svg";
            a4.Source = "coffee4.svg";
            a5.Source = "coffee5.svg";
            a6.Source = "coffee6.svg";
            a7.Source = "coffee7.svg";
            a8.Source = "coffee8.svg";
            a9.Source = "coffee9.svg";
        }



    }
}