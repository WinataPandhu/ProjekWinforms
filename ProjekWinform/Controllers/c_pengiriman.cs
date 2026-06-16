using ProjekWinform.Models;
using System.Data;

namespace ProjekWinform.Controllers
{
    public class c_pengiriman
    {
        private PengirimanContext context = new PengirimanContext();

        public DataTable ReadPengiriman(string tanggal = "")
        {
            return context.ReadPengiriman(tanggal);
        }

        public DataTable ReadPengirimanByNama(string keyword = "")
        {
            return context.ReadPengirimanByNama(keyword);
        }

        public string UbahStatus(int id_pengirim)
        {
            context.UbahStatus(id_pengirim);
            return "Status berhasil diubah!";
        }
    }
}