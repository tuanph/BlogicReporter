namespace BLogicReport.Views
{
    using BLogicReport.ViewModel;
    using I18NPortable;
    using System;
    using System.Reflection;
    using Xamarin.Forms;

    public partial class SelectDateTimeControl : ContentView
    {
        I18NPortable.I18N Strings;
        private DateTime StartDate;
        private DateTime EndDate;
        public event EventHandler<string> ViewReportCalled ;
       
        public SelectDateTimeControl()
        {
            InitializeComponent();

            Assembly assembly = GetType().GetTypeInfo().Assembly;
            I18N.Current.SetFallbackLocale("vn").Init(assembly);
            Strings = I18NPortable.I18N.Current as I18N;
            BindingContext = new BaseViewModelcs();
            InitValueForSelectDateButton();
            InitValues();
        }

        private void InitValues()
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            this.pickerStartDate.Date = this.StartDate.Date;
            this.pickerEndDate.Date = this.StartDate.Date;
            this.pickerStartTime.Time = new TimeSpan(0, 0, 0);
            this.pickerEndTime.Time = new TimeSpan(23, 59, 59);
        }

        private void InitValueForSelectDateButton()
        {
            for (int i = 1; i <= 12; i++)
            {
                Button btn = this.myGrid.FindByName<Button>("btn" + i.ToString());
                if (btn != null)
                {
                    int currentMonths = DateTime.Now.Month;
                    DateTime date = DateTime.Now.AddMonths(i - 12);
                    btn.Text = date.ToString("MM-yyyy");
                    btn.Clicked += Btn_Clicked;
                    btn.ClassId = date.ToString();
                }
            }
        }
        private void Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DateTime date = Convert.ToDateTime(btn.ClassId);
            this.StartDate = new DateTime(date.Year, date.Month, 1);
            this.EndDate = this.StartDate.AddMonths(1).AddSeconds(-1);
            if (this.EndDate.Date > DateTime.Today)
                this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }
        private void ButtonToday_Clicked(object sender, EventArgs e)
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }
        private void ButtonThisWeek_Clicked (object sender, EventArgs e)
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }
        private void ButtonLastWeek_Clicked(object sender, EventArgs e)
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }
        private void ButtonThisQuater_Clicked(object sender, EventArgs e)
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }
        private void ButtonLastQuater_Clicked(object sender, EventArgs e)
        {
            this.StartDate = DateTime.Today;
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }
        private void ButtonThisYear_Clicked(object sender, EventArgs e)
        {
            this.StartDate =new DateTime(DateTime.Now.Year,1,1);
            this.EndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            if (this.ViewReportCalled != null)
                this.ViewReportCalled(sender, this.StartDate.ToString() + this.EndDate.ToString());
        }

    }
}
