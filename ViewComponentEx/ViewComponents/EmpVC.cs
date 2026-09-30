using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewComponentEx.Models;

namespace ViewComponentEx.ViewComponents
{
    public class EmpVC:ViewComponent
    {
        CompanyContext cc;
        public EmpVC(CompanyContext cc)
        {
            this.cc = cc;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await this.cc.Emps.FirstOrDefaultAsync());
        }

    }
}
