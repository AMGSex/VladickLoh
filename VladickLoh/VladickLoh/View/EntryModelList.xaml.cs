using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VladickLoh.Model;
using VladickLoh.Service;

namespace VladickLoh.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryModelList : ContentPage
    {
        public EntryModelList()
        {
            InitializeComponent();
            
        }
    }
}