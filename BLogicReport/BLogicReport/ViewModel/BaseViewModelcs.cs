using I18NPortable;

namespace BLogicReport.ViewModel
{
    public class BaseViewModelcs
    {
        public I18N Strings => I18N.Current as I18N;
    }
}
