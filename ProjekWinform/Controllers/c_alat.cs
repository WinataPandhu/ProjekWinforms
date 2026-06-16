using ProjekWinform.Models;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    public class c_alat
    {
        private AlatContext context = new AlatContext();

        public List<AlatPertanian> Read()
        {
            return context.Read();
        }

        public string Create(AlatPertanian alat)
        {
            context.Create(alat);
            return "Produk berhasil ditambahkan!";
        }

        public string UpdateHarga(AlatPertanian alat)
        {
            context.UpdateHarga(alat);
            return "Harga berhasil diupdate!";
        }

        public string Restok(AlatPertanian alat, int jumlah, int hargaBeli, int id_user)
        {
            context.Restok(alat.id_alat, jumlah, hargaBeli, id_user);
            return "Restok berhasil!";
        }

        public List<HistoriRestok> ReadRestok()
        {
            return context.ReadRestok();
        }

        public List<HistoriRestok> ReadRestokByKeyword(string keyword)
        {
            return context.ReadRestokByKeyword(keyword);
        }

        public string Update(AlatPertanian alat)
        {
            context.Update(alat);
            return "Produk berhasil diupdate!";
        }
    }
}