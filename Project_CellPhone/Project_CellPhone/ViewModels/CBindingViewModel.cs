using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Project_CellPhone.Models;

namespace Project_CellPhone.ViewModels
{
    public class CBindingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        List<CReceipt> temp = new List<CReceipt>();
        public int m_search_index = 0;
        int mPosition = 0;
        
        public CBindingViewModel()
        {
            temp = new CGetReceiptData().queryAll();
        }
        public void Move_First()
        {
            mPosition = 0;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("M_Current"));
            }
        }
        public void Move_Previous()
        {
            mPosition--;
            if (mPosition < 0) { mPosition = 0; }
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("M_Current"));
            }
        }
        public void Move_Next()
        {
            mPosition++;
            if (mPosition >= temp.Count) { Move_Last(); }
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("M_Current"));
            }
        }
        public void Move_Last()
        {
            mPosition = temp.Count - 1;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("M_Current"));
            }
        }
        public void Move_To(int get_index)
        {
            mPosition = get_index;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("M_Current"));
            }
        }
        public CReceipt M_Current
        {
            get { return temp[mPosition]; }
        }
        public List<CReceipt> M_All
        {
            get { return temp; }
        }

        internal bool Find(string searchName)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Receipt_name.Contains(searchName)  )
                {
                    mPosition = i;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("M_Current"));
                    }

                    return true;
                }
            }
            return false;
        }
    }
}
