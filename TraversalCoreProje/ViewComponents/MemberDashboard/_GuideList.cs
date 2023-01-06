using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuidManager guidManager = new GuidManager(new EfGuideDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = guidManager.TGetList();
            return View(values);
        }
    }
}
