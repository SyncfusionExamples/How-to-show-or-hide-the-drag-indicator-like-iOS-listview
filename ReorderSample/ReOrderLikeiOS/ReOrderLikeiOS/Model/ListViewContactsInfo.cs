﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SfListViewSample
{
    [Preserve(AllMembers = true)]
    public class ListViewContactsInfo : INotifyPropertyChanged
    {
        #region Fields

        private string contactName;
        private string contactNo;
        private ImageSource image;
        private string contactType;
        private bool indicatorVisible;

        #endregion

        #region Constructor

        public ListViewContactsInfo()
        {
          
        }

        #endregion

        #region Public Properties

        public bool IndicatorVisible
        {
            get { return indicatorVisible; }
            set
            {
                this.indicatorVisible = value;
                this.RaisePropertyChanged("IndicatorVisible");
            }
        }

        public string ContactName
        {
            get { return this.contactName; }
            set
            {
                this.contactName = value;
                RaisePropertyChanged("ContactName");
            }
        }
        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
                RaisePropertyChanged("ContactNumber");
            }
        }

        public string ContactType
        {
            get { return contactType; }
            set
            {
                this.contactType = value;
                RaisePropertyChanged("ContactType");
            }
        }

        public ImageSource ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisePropertyChanged("ContactImage");
            }
        }
       
        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
