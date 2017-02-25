using BLogicReport.ViewModel;
using I18NPortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BLogicReport.Views
{
    public partial class MainPages : ContentPage
    {
        I18NPortable.I18N Strings;
        public MainPages()
        {
            InitializeComponent();
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            I18N.Current.SetFallbackLocale("vn").Init(assembly);
            Strings = I18NPortable.I18N.Current as I18N;
            BindingContext = new BaseViewModelcs();
        }
    }
}
