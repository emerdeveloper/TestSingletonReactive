using System;
using System.ComponentModel;

namespace TestSingletonReactive
{
    public class Customer : INotifyPropertyChanged
    {
        public Customer()
        {
        }
        #region Attributes
        private string name;
        #endregion

        #region Properties
        public string Document { get; set; }

        public string DocumentType { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string Mail { get; set; }

        public string CellPhone { get; set; }
        #endregion


        //-- INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
