using Dependency.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Dependency.ViewModel
{
    public class OrientViewModel
    {
        public ICommand Button { get; set; }
        public string O { get;  set; }
           public OrientViewModel()
        {
            Button = new Command(() =>
            {
                DeviceOrientation orientation = DependencyService.Get<IOrientation>().GetOrientation(),

                O = orientation;

            }) ;

        }
    }
}
