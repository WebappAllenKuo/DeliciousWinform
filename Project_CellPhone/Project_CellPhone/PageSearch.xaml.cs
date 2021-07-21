using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Project_CellPhone.ViewModels;

namespace Project_CellPhone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSearch : ContentPage
    {
        CBindingViewModel mbindingViewModels;
        
        public PageSearch()
        {
            InitializeComponent();
            mbindingViewModels = this.BindingContext as CBindingViewModel;
            (Application.Current as App).bviewModel = mbindingViewModels;

        }
        Dictionary<Button, Label> M_dictionary = new Dictionary<Button, Label>();
        private void IBSearch_Clicked(object sender, EventArgs e)
        {
            M_dictionary.Clear();
            m_grid.Children.Clear();
            int num_count;
            if (input.Text != null)
            {
                mbindingViewModels.Find(input.Text);
                num_count = 1;
                Label label = new Label
                {
                    Text = mbindingViewModels.M_Current.Receipt_name,
                    TextColor = Color.Black,
                    BackgroundColor = Color.White,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center
                    


                };
                m_grid.Children.Add(label, 0, 0);
                //欄 行
                Button button = new Button
                {

                    Text = "選擇" ,
                    TextColor = Color.Black,
                    BackgroundColor = Color.White,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };
                button.Clicked += Button_temp_Clicked;
                m_grid.Children.Add(button, 1, 0);
                M_dictionary.Add(button, label);
            }
            else
            {
                num_count = mbindingViewModels.M_All.Count();


                for (int i = 0; i < num_count; i++)
                {
                   
                    Label label = new Label
                    {
                        Text = mbindingViewModels.M_All[i].Receipt_name,
                        TextColor = Color.Black,
                        BackgroundColor = Color.White,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                         VerticalTextAlignment = TextAlignment.Center,
                        HorizontalTextAlignment = TextAlignment.Center

                    };
                    m_grid.Children.Add(label, 0, i);
                    //欄 行
                    Button button = new Button
                    {
                        
                        Text = "選擇" ,
                        TextColor = Color.Black,
                        BackgroundColor = Color.White,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                    };
                    button.Clicked += Button_temp_Clicked;
                    M_dictionary.Add(button, label);
                    m_grid.Children.Add( button, 1, i);
                }
            }
           
        }

        private void Button_temp_Clicked(object sender, EventArgs e)
        {
            string m_name = "";
            Button tempbut = (Button)sender;
            foreach (var item in M_dictionary)
            {
                if(item.Key == tempbut)
                {
                    m_name = item.Value.Text;
                }
                 
            }
            mbindingViewModels.Find(m_name);
            Navigation.PopAsync();
            


        }
    }
}