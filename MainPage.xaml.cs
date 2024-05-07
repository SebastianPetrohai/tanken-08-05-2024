using tanken.ViewModels;

namespace tanken
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }

        
    }

}
