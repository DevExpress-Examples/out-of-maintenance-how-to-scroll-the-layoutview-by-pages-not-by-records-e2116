using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Layout.Events;

namespace WindowsApplication1
{
    public class MyLayoutViewScrollHelper
    {
        private LayoutView _SelectedLayoutView;
        public LayoutView SelectedLayoutView
        {
            get { return _SelectedLayoutView; }
            set { _SelectedLayoutView = value; }
        }

        public MyLayoutViewScrollHelper(LayoutView view)
        {
            SelectedLayoutView = view;
            SelectedLayoutView.VisibleRecordIndexChanged += SelectedLayoutView_VisibleRecordIndexChanged;
        }

        private int GetVisibleCardsCount()
        {
            int visibleCardsCount = (SelectedLayoutView.GetViewInfo() as LayoutViewInfo).VisibleCards.Count;
            return visibleCardsCount;
        }
        int GetPageByVisibleIndex(int visibleIndex)
        {
            return visibleIndex / GetVisibleCardsCount();
        }

        bool IsScrollForward(LayoutViewVisibleRecordIndexChangedEventArgs e)
        {
            return GetPageByVisibleIndex(e.VisibleRecordIndex) == GetPageByVisibleIndex(e.PrevVisibleRecordIndex);
        }

        int GetFirstCardIndex(int pageIndex, bool isForward)
        {
            int delta = isForward ? 1 : 0;
            return GetVisibleCardsCount() * (pageIndex + delta);
        }

        bool locked;

        private void ScrollPage(LayoutViewVisibleRecordIndexChangedEventArgs e)
        {
            SelectedLayoutView.VisibleRecordIndex = e.PrevVisibleRecordIndex;
            SelectedLayoutView.VisibleRecordIndex = GetFirstCardIndex(GetPageByVisibleIndex(e.VisibleRecordIndex), IsScrollForward(e));
        }
        void SelectedLayoutView_VisibleRecordIndexChanged(object sender, LayoutViewVisibleRecordIndexChangedEventArgs e)
        {
            if (locked) return;
            locked = true;
            ScrollPage(e);
            locked = false;
        }
    }
}
