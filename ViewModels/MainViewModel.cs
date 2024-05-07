using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private int _price = 0;

        [ObservableProperty]
        private int _aliter = 0;

        [ObservableProperty]
        private int _ergebnis = 0;

        [RelayCommand]
        void Calculate()
        {
            int zahl1 = Convert.ToInt32(this.Price);
            int zahl2 = Convert.ToInt32(this.Aliter);

            this.Ergebnis = zahl1 * zahl2;
        }


    }
}
