using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Models
{
    public class JenisItem
    {
        public int Id { get; set; }
        public string Nama { get; set; } = string.Empty;
        public override string ToString()
        {
            return Nama;
        }
    }
}