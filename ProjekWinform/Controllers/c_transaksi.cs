using ProjekWinform.Models;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    public class c_transaksi
    {
        private TransaksiContext context = new TransaksiContext();

        public List<Transaksi> ReadTransaksi()
        {
            return context.ReadTransaksi();
        }

        public List<Transaksi> ReadTransaksiByKeyword(string keyword)
        {
            return context.ReadTransaksiByKeyword(keyword);
        }
    }
}