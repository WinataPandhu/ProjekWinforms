using ProjekWinform.Models;
using System;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    public class c_pesanan
    {
        private PesananContext context = new PesananContext();

        public List<AlatPertanian> LoadBarang()
        {
            return context.LoadBarang();
        }

        public List<MetodePengambilan> LoadPengambilan()
        {
            return context.LoadPengambilan();
        }

        public List<MetodePembayaran> LoadPembayaran()
        {
            return context.LoadPembayaran();
        }

        public List<AlatPertanian> LoadKatalogBarang(string keyword = "")
        {
            return context.LoadKatalogBarang(keyword);
        }

        public decimal GetHargaAlat(int id_alat)
        {
            return context.GetHargaAlat(id_alat);
        }

        public int SimpanPelanggan(string nama, string noHp, string alamat)
        {
            return context.SimpanPelanggan(nama, noHp, alamat);
        }

        public int SimpanTransaksi(DateTime tanggal, int id_user, int id_pelanggan, object id_pengambilan, object id_pembayaran)
        {
            return context.SimpanTransaksi(tanggal, id_user, id_pelanggan, id_pengambilan, id_pembayaran);
        }

        public void SimpanDetailTransaksi(int qty, decimal subtotal, decimal harga, int id_transaksi, int id_alat)
        {
            context.SimpanDetailTransaksi(qty, subtotal, harga, id_transaksi, id_alat);
        }

        public void SimpanPengiriman(int id_transaksi, int id_user_kurir)
        {
            context.SimpanPengiriman(id_transaksi, id_user_kurir);
        }

        public int GetIdUserKurir()
        {
            return context.GetIdUserKurir();
        }

        public int GetIdUserByUsername(string username)
        {
            return context.GetIdUserByUsername(username);
        }
    }
}