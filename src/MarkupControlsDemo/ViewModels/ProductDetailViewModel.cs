using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using MarkupControlsDemo.Model;

namespace MarkupControlsDemo.ViewModels
{
    public class ProductDetailViewModel : MasterPageViewModel
    {

        public ProductModel Product { get; set; }

        public OrderModel Order { get; set; } = new();


        [FromRoute("id")]
        public int Id { get; set; }

        public override Task PreRender()
        {
            if (!Context.IsPostBack)
            {
                Product = Store.Products.Single(p => p.Id == Id);
            }
            return base.PreRender();
        }

    }
}

