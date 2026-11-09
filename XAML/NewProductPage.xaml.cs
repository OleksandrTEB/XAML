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
        //licznik++;
        //EtykietaWyniku.Text = $"Kliknieto razy: {licznik}";

        string? nazwa = Nazwa.Text;
        if (string.IsNullOrEmpty(nazwa))
        {
            EtykietaWyniku.Text = "Niwprowadzino nazwy!";
            return;
        }

        if (!double.TryParse(Cena.Text, out double cena)) {
            EtykietaWyniku.Text = "Niepodana ceny";
            return;
        }

        if (!int.TryParse(Ilosc.Text, out int ilocs))
        {
            EtykietaWyniku.Text = "Niepodana ilosc";
            return;
        }

        if (KategoriaPicker.SelectedItem == null)
        {
            EtykietaWyniku.Text = "Nie wybrano kategorii!";
            return;
        }

        double wartosc = ilocs * cena;
        EtykietaWyniku.Text = $"Produkt: {nazwa}, cena: {cena}, ilosc: {ilocs}, kategoria: {KategoriaPicker.SelectedItem}, wartosc: {wartosc} zł";
    }

    private void Reset(object sender, EventArgs e)
    {
        licznik = 0;

        EtykietaWyniku.Text = $"Kliknieto zero razy";
    }

    private void WprowadzonoLitere(object sender, TextChangedEventArgs e)
    {
        //EtykietaWyniku.Text = $"Nazwa ma {Nazwa.Text.Length} znaków";
    }

    private void ZmianaSwicza(object sender, ToggledEventArgs e)
    {
        if (AwaliableSwtich.IsToggled)
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

    private void Cena_TextChanged(object sender, TextChangedEventArgs e)
    {
        Entry s = (Entry)sender;
        if (double.TryParse(s.Text, out double wartosc))
        {
            if (wartosc < 0)
            {
                s.Background = Colors.Red;
            }
            else
            {
                s.Background = Colors.Green;
            }
        }

        if (!double.TryParse(Cena.Text, out double cena))
        {
            NowaEtykietaWyniku.Text = "Niepodana ceny";
            return;
        }

        if (!int.TryParse(Ilosc.Text, out int ilocs))
        {
            NowaEtykietaWyniku.Text = "Niepodana ilosc";
            return;
        }

        NowaEtykietaWyniku.Text = $"Wartosc: {cena * ilocs}";
    }
}