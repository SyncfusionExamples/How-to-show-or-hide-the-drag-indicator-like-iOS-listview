using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.ListView.XForms;
using Xamarin.Forms.Internals;

namespace SfListViewSample
{
    [Preserve(AllMembers = true)]
    public class ViewModel 
    {
        #region Fields

        private ObservableCollection<ListViewContactsInfo> contactsInfo;
        Command<object> tapCommand;

        #endregion

        #region Constructor

        public ViewModel()
        {
            GenerateSource(100);
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewContactsInfo> ContactsInfo
        {
            get { return contactsInfo; }
            set { this.contactsInfo = value; }
        }

        public Command<object> TapCommand
        {
            get { return tapCommand; }
            protected set { tapCommand = value; }
        }
        #endregion

        #region ItemSource

        public void GenerateSource(int count)
        {
            ListViewContactsInfoRepository contactRepository = new ListViewContactsInfoRepository();
            contactsInfo = contactRepository.GetContactDetails(count);

            TapCommand = new Command<object>(OnTapped);
        }

        private void OnTapped(object obj)
        {
            for (int i = 0; i < ContactsInfo.Count; i++)
            {
                ContactsInfo[i].IndicatorVisible = true;
            }
        }

        #endregion
    }
}
