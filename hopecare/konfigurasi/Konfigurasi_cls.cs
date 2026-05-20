using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIREMBA.konfigurasi
{
    abstract class Konfigurasi_cls
    {
        // method untuk penanganan INSERT, UPDATE, dan DELETE
        public abstract int eksekusiNonQuery(string query);

        // method untuk penanganan SELECT
        public abstract DataTable eksekusiQuery(string query);

    }
}
