using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace regg
{
    public class dataAccess
    {
        public static bool aliBazaObstaja()
        {
            try
            {
                using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public List<oseba> getOsebe()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                var output = connection.Query<oseba>($"select * from Oseba").ToList();
                return output;
            } 
        }

        

        public void VstaviOsebo(string ime , string priimek, string idKartice)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                oseba novaOseba = new oseba { ime = ime, priimek = priimek, id_kartice = idKartice };

                List<oseba> osebe = new List<oseba>();
                osebe.Add(novaOseba);
                connection.Execute("dbo.Dodaj_osebo @ime, @priimek, @id_kartice", osebe);



            }
        }

        public bool aliJeOsebaVStavbi(string id)
        {
            string aliJeNot;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                aliJeNot = connection.Query<string>("SELECT id_kartice FROM prihod WHERE id_kartice = @id", new { id = id }).FirstOrDefault();
            }
            return aliJeNot!=null;
        }

        public bool dodaj_prihod(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                prihod novPrihod = new prihod { Id = id, Prihod = DateTime.Now };
                List<prihod> vsiPrihodi = new List<prihod>();
                vsiPrihodi.Add(novPrihod);
                try
                {
                    //doda prhod v bazo, pri pogoju, d
                    //connection.Execute("dbo.dodaj_prihod @id_kartice, @prihod", vsiPrihodi);
                    connection.Execute("INSERT INTO dbo.prihod (id_kartice, prihod) VALUES (@id, @prihod)", new { id = id, prihod = DateTime.Now });
                    return true;
                }
                
                catch
                {
                    //IZHOD!!!
                   
                    izhod(id);

                    return false;

                }



            }
        }
        public void izhod(string id)
        {
            DateTime prihod = new DateTime();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                prihod = connection.Query<DateTime>($"SELECT prihod from prihod WHERE id_kartice=@Id", new { Id = id }).FirstOrDefault();
            }
            TimeSpan skupaj = new TimeSpan();
            skupaj = DateTime.Now - prihod;
            double ure = skupaj.TotalHours;
            int min = skupaj.Minutes;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
               //doda izhod v bazo izhodov
                connection.Execute("dbo.izhod @Id_kartice, @prihod, @izhod, @ure, @minute", new { Id_kartice = id, prihod = prihod, izhod = DateTime.Now, ure = ure, minute = min });
               
                //izbriše iz baze prihodov
                connection.Execute("dbo.izbriši_prihod @Id_kartice", new { Id_kartice = id });
            }
        }

        public int skupnoStMinut(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                return connection.Query<int>($"select minute from dnevnik where id_kartice=@id;", new { Id = id }).Sum();
            }
        }

        public oseba getOseboById(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                return  connection.Query<oseba>($"select * from oseba where id_kartice= @Id", new { Id = id }).FirstOrDefault(); 
            }
        }

        public int skupnoStUr(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                return connection.Query<int>($"select ure from dnevnik where id_kartice=@id;", new { Id = id }).Sum();
            }
        }

        public double stUr(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                return connection.Query<double>($"select ure from dnevnik where id_kartice=@id;", new { Id = id }).LastOrDefault();
            }
        }

        public double stMin(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("registratorBaza2")))
            {
                return connection.Query<double>($"select minute from dnevnik where id_kartice=@id;", new { Id = id }).LastOrDefault();
            }
        }

    }
}
