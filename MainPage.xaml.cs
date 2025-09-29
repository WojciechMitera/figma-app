using System.Collections.ObjectModel;

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
        }

        private void add_Clicked(object sender, EventArgs e)
        {
            Tasks.Add(new item { czynnosc = entry.Text, zaznaczone = false});
            list.ItemsSource = Tasks;
            entry.Text = "";
        }

       
    }   
}
