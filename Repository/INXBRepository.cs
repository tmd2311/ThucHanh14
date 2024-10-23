using ThucHanh14.Models;
namespace ThucHanh14.Repository
{
	public interface INXBRepository
	{
		TNhaXb Add(TNhaXb tNXB);
		TNhaXb Update(TNhaXb tNXB);
		TNhaXb Delete(string maNXB);
		TNhaXb GetDg(string mãNB);
		IEnumerable<TNhaXb> GetAllNXB();
	}
}
