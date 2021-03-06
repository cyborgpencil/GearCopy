﻿using GearCopy.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GearCopy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Filemanager
            FileManager fm = new FileManager();

            base.OnStartup(e);

            var bootstapper = new Bootstrapper();
            bootstapper.Run();
        }
    }
}
