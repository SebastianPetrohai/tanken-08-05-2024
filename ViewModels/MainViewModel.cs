using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanken.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Tanken";

        [ObservableProperty]
        private string _description1 = "Preis/Liter:";

        [ObservableProperty]
        private string _description2 = "Anzahl/Liter:";



    }
}
