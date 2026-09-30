using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewComponentEx.Models;

namespace ViewComponentEx.ViewComponents
{
    public class BookVC:ViewComponent
    {
        CompanyContext cc;
        public BookVC(CompanyContext cc)
        {
            this.cc = cc;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var res = await this.cc.Books.FirstOrDefaultAsync();
            return View(res);
        }
    }
}
