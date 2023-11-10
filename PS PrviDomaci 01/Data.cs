using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPrviDomaci
{
    public class Data
    {
        public static SqlConnection conn = new SqlConnection("Data Source=ETS-ZEMUN\\SQLEXPRESS;Initial Catalog=studentska_sluzba;User ID=ETS-ZEMUN-APP;Password=123123");
        public static List<Zvanje> VratiZvanja()
        {
            List<Zvanje> ret = new List<Zvanje>();
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM ZVANJE;",conn);
            SqlDataReader dr = comm.ExecuteReader();
            while(dr.Read())
            {
                ret.Add(new Zvanje(Convert.ToInt32(dr["ID"]), dr["NAZIV"].ToString()));
            }
            conn.Close();
            return ret;
        }

        public static List<Nastavnik> VratiNastavnike()
        {
            List<Nastavnik> ret = new List<Nastavnik>();
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT NASTAVNIK.ID AS NASTAVNIKID,IME,PREZIME,ZVANJE_ID,ZVANJE.NAZIV FROM NASTAVNIK INNER JOIN ZVANJE ON NASTAVNIK.ZVANJE_ID=ZVANJE.ID;", conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                ret.Add(new Nastavnik(Convert.ToInt32(dr["NASTAVNIKID"]), dr["IME"].ToString(), dr["PREZIME"].ToString(), new Zvanje(Convert.ToInt32(dr["ZVANJE_ID"]), dr["NAZIV"].ToString())));
            }
            conn.Close();
            return ret;
        }

        public static void ObrisiNastavnika(Nastavnik nastavnik)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("DELETE FROM NASTAVNIK WHERE ID = "+nastavnik.ID+";", conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public static void DodajNastavnika(Nastavnik nastavnik)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO NASTAVNIK VALUES(@NIME,@NPREZIME,@NZVANJEID);", conn);
            comm.Parameters.Add(new SqlParameter("NIME", nastavnik.Ime));
            comm.Parameters.Add(new SqlParameter("NPREZIME", nastavnik.Prezime));
            comm.Parameters.Add(new SqlParameter("@NZVANJEID", nastavnik.Zvanje.ID));
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public static void IzmeniNastavnika(Nastavnik nastavnik)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("UPDATE NASTAVNIK SET IME=@NIME,PREZIME=@NPREZIME,ZVANJE_ID=@NZVANJEID WHERE ID=@NID;", conn);
            comm.Parameters.Add(new SqlParameter("NID", nastavnik.ID));
            comm.Parameters.Add(new SqlParameter("NIME", nastavnik.Ime));
            comm.Parameters.Add(new SqlParameter("NPREZIME", nastavnik.Prezime));
            comm.Parameters.Add(new SqlParameter("@NZVANJEID", nastavnik.Zvanje.ID));
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
