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
        private int _price = 0;

        [ObservableProperty]
        private int _aliter = 0;

        



    }
}
