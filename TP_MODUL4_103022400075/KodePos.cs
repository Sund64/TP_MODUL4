using System;
using System.Collections.Generic;

public class KodePos
{
    // Method table-driven to get kode pos by kelurahan
    public static string getKodePos(string kelurahan)
    {
        if (kelurahan == null) return "Kode pos tidak ditemukan";

        var table = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" }
        };

        if (table.TryGetValue(kelurahan.Trim(), out var kode))
            return kode;

        return "Kode pos tidak ditemukan";
    }
}
