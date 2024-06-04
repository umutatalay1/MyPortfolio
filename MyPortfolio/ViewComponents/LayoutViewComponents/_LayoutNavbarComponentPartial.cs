using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount=context.ToDoLists.Where(x=>x.Status==false).Count(); // Yapılmamış olan bildirim sayısı
			var values = context.ToDoLists.Where(x=>x.Status==false).ToList(); //Yapılmamış olan metotları listeleyecek
			return View(values);
		}
	}
}
