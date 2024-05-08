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
        private double _price = 0;

        [ObservableProperty]
        private double _aliter = 0;

        [ObservableProperty]
        private double _ergebnis = 0;

        [RelayCommand]
        void Calculate()
        {
            double zahl1 = Convert.ToDouble(this.Price);
            double zahl2 = Convert.ToDouble(this.Aliter);

            this.Ergebnis = zahl1 * zahl2;
        }


    }
}
