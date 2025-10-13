using System.Collections.ObjectModel;
using Xamarin.Google.Crypto.Tink.Subtle;


namespace figma
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<item> Tasks { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<item>();
            BindingContext = this;
            ToolbarItems.Add(new ToolbarItem { Text = "Wyloguj", Order = ToolbarItemOrder.Primary, Priority = 0, Command = new Command(Wyloguj) });
        }

        private async void add_Clicked(object sender, EventArgs e)
        {
            //Tasks.Add(new item { czynnosc = entry.Text, zaznaczone = false});
            await Navigation.PushAsync(new NewPage1(Tasks));
            list.ItemsSource = Tasks;
            
            
        }

        private void delete_Clicked(object sender, EventArgs e)
        {
            List<item> lista = [];
            
            
            for(int i =0;i < Tasks.Count; i++)
            {
                if (Tasks[i].zaznaczone == true)
                {
                    lista.Add(Tasks[i]);
                }
            }
            for(int i = 0; i < lista.Count; i++)
            {
                Tasks.Remove(lista[i]);
            }
            //Tasks.Remove((item)list.SelectedItem);
        }
        private async void Wyloguj()
        {
           
        }
    }   
}
