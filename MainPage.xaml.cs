using MD.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace MD
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Binding myBinding = new Binding()
            {
                Source = Emails,
                Mode = BindingMode.OneWay
            };

            MyMasterDetailsView.SetBinding(MasterDetailsView.ItemsSourceProperty, myBinding);

            var emails = MyEmailManager.GetEmails();
            emails.ForEach(email => Emails.Add(email));
        }

        public ObservableCollection<Email> Emails = new ObservableCollection<Email>();
    }
}
