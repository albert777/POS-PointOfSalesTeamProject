﻿using POS_ViewsLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ManagersApp.ViewModels
{
  

    class DashboardViewModel:ViewModel
    {
        public ObservableCollection<TestClass> Errors { get; private set; }
        public DashboardViewModel()
        {
            Errors = new ObservableCollection<TestClass>();
            Errors.Add(new TestClass() { Category = "Globalization", Number = 75 });
            Errors.Add(new TestClass() { Category = "Features", Number = 2 });
            Errors.Add(new TestClass() { Category = "ContentTypes", Number = 12 });
            Errors.Add(new TestClass() { Category = "Correctness", Number = 83 });
            Errors.Add(new TestClass() { Category = "Best Practices", Number = 29 });
        }
        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                // selected item has changed
                selectedItem = value;
            }
        }
    }

    // class which represent a data point in the chart
    public class TestClass
    {
        public string Category { get; set; }

        public int Number { get; set; }
    }
}
