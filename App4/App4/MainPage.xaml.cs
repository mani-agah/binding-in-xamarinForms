using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<MyView> GetText = new ObservableCollection<MyView>();
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnSave(object sender, EventArgs e)
        {
            MyView mv = new MyView();
            mv.Prop = EntryText.Text;
            this.BindingContext = new MyView();
            ListV.ItemsSource = GetText;
            GetText.Add(mv);
        }

        private void BtnErase(object sender, EventArgs e)
        {
            EntryText.Text = null;
        }

        private async void ListV_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        }
    }
}
