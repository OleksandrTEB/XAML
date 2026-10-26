namespace XAML;

public partial class NewProductPage : ContentPage
{
    private int licznik = 0;

	public NewProductPage()
	{
		InitializeComponent();
	}

    private void NowyProdukt(object sender, EventArgs e)
    {
        licznik++;

        Labelka.Text = $"Kliknieto razy: {licznik}";
    }

    private void Reset(object sender, EventArgs e)
    {
        licznik = 0;

        Labelka.Text = $"Kliknieto zero razy";
    }
}