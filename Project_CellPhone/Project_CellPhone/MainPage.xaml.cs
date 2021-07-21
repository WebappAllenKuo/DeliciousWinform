using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Project_CellPhone.ViewModels;


namespace Project_CellPhone
{
    public partial class MainPage : ContentPage
    {
        CBindingViewModel mbindingViewModels;
        public MainPage()
        {
            InitializeComponent();
            
            mbindingViewModels = this.BindingContext as CBindingViewModel;
            (Application.Current as App).bviewModel = mbindingViewModels;
             
        }
        
        private void forword_Clicked(object sender, EventArgs e)
        {

            mbindingViewModels.Move_First();


        }


        private void back_Clicked(object sender, EventArgs e)
        {
            mbindingViewModels.Move_Previous();


        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            mbindingViewModels.Move_Next();


        }

        private void End_Clicked(object sender, EventArgs e)
        {
            mbindingViewModels.Move_Last();


        }

        private void btnQuery_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageSearch());

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            App x = Application.Current as App;
            if (x.bviewModel == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(x.bviewModel.M_Current.Receipt_name))
            {
                return;
            }
            mbindingViewModels.Find(x.bviewModel.M_Current.Receipt_name);

            x.bviewModel = null;
        }

        //private void btn_all_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new PageSearch());
        //}
    }
}
