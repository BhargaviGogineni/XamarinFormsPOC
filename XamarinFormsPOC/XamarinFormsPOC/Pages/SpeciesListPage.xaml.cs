using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsPOC.Pages
{
    public partial class SpeciesListPage : ContentPage
    {
        public SpeciesListPage()
        {
            InitializeComponent();
            if (Device.Idiom == TargetIdiom.Phone)
            {
                flowlistview.FlowColumnCount = 1;
            }
            else { flowlistview.FlowColumnCount = 2; }
        }
    }
}
