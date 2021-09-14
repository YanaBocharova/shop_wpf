using ShopAppDemo.Services.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.ViewModel
{

    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected Mapper mapper;
        public BaseViewModel()
        {
            mapper = Mapper.Instance;
        }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool isLoad;
        public bool IsLoad
        {
            get { return isLoad; }
            set
            {
                if (value != isLoad)
                {
                    isLoad = value;
                    OnPropertyChanged(nameof(IsLoad));
                }
            }
        }
    }
}
