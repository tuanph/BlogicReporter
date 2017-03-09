namespace BLogicReport.Views
{
    using BLogicReport.ViewModel;
    using I18NPortable;
    using System;
    using System.Reflection;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectDateTimeControl : ContentPage
    {
        I18NPortable.I18N Strings;
        public SelectDateTimeControl()
        {
            InitializeComponent();
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            I18N.Current.SetFallbackLocale("vn").Init(assembly);
            Strings = I18NPortable.I18N.Current as I18N;
            BindingContext = new BaseViewModelcs();
            InitValueForSelectDateButton();
        }

        private void InitValueForSelectDateButton()
        {
            for (int i = 1; i <= 12; i++)
            {
                Button btn = this.myGrid.FindByName<Button>("btn" + i.ToString());
                int currentMonths = DateTime.Now.Month;
                DateTime date = DateTime.Now.AddMonths(i - 12);
                btn.Text = date.ToString("MM-yyyy");
                btn.Clicked += Btn_Clicked;
            }

        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}
