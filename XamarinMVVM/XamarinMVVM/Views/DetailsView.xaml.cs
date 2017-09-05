using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinMVVM.Models;

namespace XamarinMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsView : ContentPage
    {
        public DetailsView()
        {
            InitializeComponent();
            BindingContext = App.Locator.DetailsViewModel;
        }
    }
}