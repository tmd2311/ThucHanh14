using Bai1.Models;
using Bai1.Models.SanhModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThucHanh14.Models;
namespace Bai1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachAPIController : ControllerBase
    {
        QlthuVienContext db = new QlthuVienContext();
        [HttpGet]
        public IEnumerable<Sach> GetAllSach()
        {
            var sach = (from p in db.TSaches
                        select new Sach
                        {
                            MaSach = p.MaSach,
                            TenSach = p.TenSach,
                            FileAnh = p.FileAnh,
                            MaNxb=p.MaNxb
                        }).ToList();
            return sach;
        }

        [HttpGet("{maNXB}")]
        public IEnumerable<Sach> GetAllSach(string maXNB)
        {
            var sach = (from p in db.TSaches
                        where p.MaNxb == maXNB
                        select new Sach
                        {
                            MaSach = p.MaSach,
                            TenSach = p.TenSach,
                            FileAnh = p.FileAnh,
                            MaNxb=p.MaNxb
                            
                        }).ToList();
            return sach;

        }




    }
}
