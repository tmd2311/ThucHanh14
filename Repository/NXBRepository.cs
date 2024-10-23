using ThucHanh14.Models;
namespace ThucHanh14.Repository
{
	public class NXBRepository : INXBRepository
	{
		private readonly QlthuVienContext _context;
		public NXBRepository(QlthuVienContext context)
		{
				_context = context;
		}
		public TNhaXb Add(TNhaXb tNXB)
		{
			_context.TNhaXbs.Add(tNXB);
			_context.SaveChanges();	
			return tNXB;
		}

		public TNhaXb Delete(string maNXB)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TNhaXb> GetAllNXB()
		{
			return _context.TNhaXbs;
		}

		public TNhaXb GetDg(string maXNB)
		{
			return _context.TNhaXbs.Find(maXNB);
		}

		public TNhaXb Update(TNhaXb tNXB)
		{
			_context.TNhaXbs.Update(tNXB);
			_context.SaveChanges();
			return tNXB;
		}
	}
}
