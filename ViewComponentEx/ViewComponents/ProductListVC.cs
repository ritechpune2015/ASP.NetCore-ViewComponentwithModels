using Microsoft.AspNetCore.Mvc;
using ViewComponentEx.Models;

namespace ViewComponentEx.ViewComponents
{
    public class ProductListVC:ViewComponent
    {
        CompanyContext cc;
        public ProductListVC(CompanyContext cc)
        {
            this.cc = cc;
        }
        public IViewComponentResult Invoke(decimal pr)
        {
            //var res = this.cc.Products.ToList();
            var res = this.cc.Products.Where(p => p.Price > pr).ToList();
            return View("ProductList",res);
        }
    }
}
