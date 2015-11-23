namespace MvvmTemplate.ViewModel
{
    class MainViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty (ref _message, value); }
        }

        public MainViewModel()
        {
            Message = "Hello Xamarin Forms MVVM!!";
        }
    }
}
