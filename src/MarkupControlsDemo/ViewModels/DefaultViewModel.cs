using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using MarkupControlsDemo.Model;

namespace MarkupControlsDemo.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {

        public List<ProductModel> Products => Store.Products;

    }
}
