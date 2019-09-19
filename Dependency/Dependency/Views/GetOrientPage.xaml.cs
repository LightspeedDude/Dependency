using Dependency.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dependency.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetOrientPage : ContentPage
    {
        public GetOrientPage()
        {
            InitializeComponent();
            BindingContext = new OrientViewModel();
        }
    }
}