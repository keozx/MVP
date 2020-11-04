﻿using System;
using System.Collections.Generic;
using MVP.Services.Interfaces;
using Xamarin.Forms;

namespace MVP.Pages
{
    public partial class WizardVisibilityPage
    {
        public WizardVisibilityPage(IAnalyticsService analyticsService)
            : base(analyticsService) => InitializeComponent();

        public void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            appFrame.ShadowOpacity = e.VerticalOffset / 50 > 1 ? 1 : e.VerticalOffset / 50;
        }
    }
}
