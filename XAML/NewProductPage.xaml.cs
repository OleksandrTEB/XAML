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

    private void WprowadzonoLitere(object sender, TextChangedEventArgs e)
    {
        EtykietaWyniku.Text = $"Nazwa ma {Nazwa.Text.Length} znaków";
    }

    private void ZmianaSwicza(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            Dostempnosc.Text = "Produkt dostępny";
        }
        else
        {
            Dostempnosc.Text = "Produkt niedostępny";
        }
    }

    private void ZminaKategorii(object sender, EventArgs e)
    {
        EtykietaWyniku.Text = KategoriaPicker.SelectedItem.ToString();
    }
}