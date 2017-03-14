using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BLogicReport.Views.ShiftsReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShiftReport : ContentPage
    {
        public ShiftReport()
        {
            InitializeComponent();
        }

        private void SelectDateTimeControl_ViewReportCalled(object sender, string e)
        {
            DisplayAlert("Call From Report View",e,"OK");
        }
    }
}
