using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delicious_Kashir
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.PageControl.SelectedIndex = 12;  //首頁選定頁面
            Cell_Binding();
        }

        private void Cell_Binding() //綁定相同事件
        {
            Hot_dataGridView.CellClick += dataGridView_CellClick;
            c1_dataGridView.CellClick += dataGridView_CellClick;
            c2_dataGridView.CellClick += dataGridView_CellClick;
            c3_dataGridView.CellClick += dataGridView_CellClick;
            c4_dataGridView.CellClick += dataGridView_CellClick;
            c5_dataGridView.CellClick += dataGridView_CellClick;
            c6_dataGridView.CellClick += dataGridView_CellClick;
            c7_dataGridView.CellClick += dataGridView_CellClick;
            c8_dataGridView.CellClick += dataGridView_CellClick;
            c9_dataGridView.CellClick += dataGridView_CellClick;
            c10_dataGridView.CellClick += dataGridView_CellClick;
            c11_dataGridView.CellClick += dataGridView_CellClick;
            all_dataGridView.CellClick += dataGridView_CellClick;
            searchvalue_dataGridView.CellClick += dataGridView_CellClick;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) //點選的選項跳出新視窗瀏覽食譜
        {
            RecipePage recipePage = new RecipePage();
            recipePage.Show();
        }

        private void btn_Hot_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 0;
        }

        private void btn_Category1_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 1;
        }

        private void btn_Category2_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 2;
        }

        private void btn_Category3_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 3;
        }

        private void btn_Category4_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 4;
        }

        private void btn_Category5_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 5;
        }

        private void btn_Category6_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 6;
        }

        private void btn_Category7_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 7;
        }

        private void btn_Category8_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 8;
        }

        private void btn_Category9_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 9;
        }

        private void btn_Category10_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 10;

        }

        private void btn_Category11_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 11;
        }

        private void pb_LogoBox_Click(object sender, EventArgs e) //點選切換跳轉
        {
            this.PageControl.SelectedIndex = 12;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.PageControl.SelectedIndex = 13;
        }

        private void add_recipe_Click(object sender, EventArgs e)
        {
            Recipe Recipe_Form = new Recipe();
            Recipe_Form.Show();
        }

        
    }
}
