﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TypefaceUtil.Avalonia
{
    public class SandBoxView : UserControl
    {
        public SandBoxView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

