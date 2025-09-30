
using System.Collections.ObjectModel;

namespace figma;

public partial class NewPage1 : ContentPage
{
	private ObservableCollection<item> _Tasks;
	public NewPage1(ObservableCollection<item> Tasks)
	{
		InitializeComponent();
		_Tasks = Tasks;
	}

    private async void dodaj_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(dodajtxt.Text))
        {
            _Tasks.Add(new item { czynnosc = dodajtxt.Text, zaznaczone = false });

            await Navigation.PopAsync();
        }
    }
}