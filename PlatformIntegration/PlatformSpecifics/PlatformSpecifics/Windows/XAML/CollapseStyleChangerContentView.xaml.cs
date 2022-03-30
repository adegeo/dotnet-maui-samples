﻿using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public partial class CollapseStyleChangerContentView : ContentView
    {
        public static readonly BindableProperty ParentPageProperty = BindableProperty.Create("ParentPage", typeof(Microsoft.Maui.Controls.FlyoutPage), typeof(CollapseStyleChangerContentView), null, propertyChanged:OnParentPagePropertyChanged);

        public Microsoft.Maui.Controls.FlyoutPage ParentPage
        {
            get { return (Microsoft.Maui.Controls.FlyoutPage)GetValue(ParentPageProperty); }
            set { SetValue(ParentPageProperty, value); }
        }

        public CollapseStyleChangerContentView()
        {
            InitializeComponent();
            PopulatePicker();
        }

        void PopulatePicker()
        {
            var enumType = typeof(CollapseStyle);
            var collapseOptions = Enum.GetNames(enumType);
            foreach (string option in collapseOptions)
            {
                picker.Items.Add(option);
            }
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            ParentPage.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetCollapseStyle((CollapseStyle)Enum.Parse(typeof(CollapseStyle), picker.Items[picker.SelectedIndex]));
        }

        static void OnParentPagePropertyChanged(BindableObject element, object oldValue, object newValue)
        {
            if (newValue != null)
            {
                var enumType = typeof(CollapseStyle);
                var instance = element as CollapseStyleChangerContentView;
                instance.picker.SelectedIndex = Array.IndexOf(Enum.GetNames(enumType), Enum.GetName(enumType, instance.ParentPage.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetCollapseStyle()));
            }
        }
    }
}
