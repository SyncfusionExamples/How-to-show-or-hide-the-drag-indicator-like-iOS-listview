using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SfListViewSample
{
    class Behavior : Behavior <ContentPage>
    {
        ViewModel viewModel;
        Button button;
        public SfListView listview { get; private set; }
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            listview = (bindable as ContentPage).FindByName<SfListView>("listView");
            button = (bindable as ContentPage).FindByName<Button>("editButton");
            viewModel = new ViewModel();
            listview.BindingContext = viewModel;
            button.BindingContext = viewModel;
            listview.ItemDragging += Listview_ItemDragging;
        }

        private void Listview_ItemDragging(object sender, ItemDraggingEventArgs e)
        {
            if (e.Action == Syncfusion.ListView.XForms.DragAction.Drop)
            {
                for (int i = 0; i < viewModel.ContactsInfo.Count; i++)
                {
                    viewModel.ContactsInfo[i].IndicatorVisible = false;
                }
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            listview.ItemDragging -= Listview_ItemDragging;
            listview = null;
            button = null;
        }
    }
}
