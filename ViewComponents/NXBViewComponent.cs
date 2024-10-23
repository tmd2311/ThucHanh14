using ThucHanh14.Models;
using Microsoft.AspNetCore.Mvc;
using ThucHanh14.Repository;
namespace ThucHanh14.ViewComponents
{
	public class NXBViewComponent : ViewComponent
	{
		private readonly INXBRepository _nhaXuatBan;
		public NXBViewComponent(INXBRepository nhaXuatBan)
		{
			_nhaXuatBan = nhaXuatBan;
		}
		public IViewComponentResult Invoke()
		{
			List<TNhaXb> nhaXbs = new List<TNhaXb>();
			List<TNhaXb> lst= _nhaXuatBan.GetAllNXB().OrderBy(x => x.TenNxb).ToList();
			for(int i=0; i<7; i++)
			{
				nhaXbs.Add(lst[i]);
			}
			return View(nhaXbs);
		}
	}
}
