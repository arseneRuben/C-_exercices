using System;
using System.Data.SqlClient;

namespace _11___exemple_ADO.NET {
    class Program {
        const string connString = @"Data Source=2R1FJW2\SQLEXPRESS;
                                    Initial Catalog = School;
                                    Integrated Security=True;
                                    Connect Timeout=5";
        static void Connection() {
            SqlConnection conn = new SqlConnection(connectionString: connString);
            conn.Open();
            Console.WriteLine("Connexion etablie!");
            conn.Close();
        }

        static void Requete1() {
            SqlConnection conn = new SqlConnection(connectionString: connString);
            conn.Open();
            Console.WriteLine("Connexion etablie!");

            //  ajout d'un etudiant
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT Student(name, age, isInternationalStu, " +
                "hobbies, YearsOfExperience, DoB) VALUES " +
                "('toto',24, 1, 'computing', 1, '1996/10/19')";
            int nbLignes = cmd.ExecuteNonQuery();
            Console.WriteLine("NbLignes = {0}", nbLignes);

            conn.Close();
        }

        static void Requete2() {
            SqlConnection conn = new SqlConnection(connectionString: connString);
            conn.Open();
            Console.WriteLine("Connexion etablie!");

            //  ajout d'un etudiant
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Student";
            //cmd.CommandText = "SELECT name FROM Student " +
            //    "WHERE id = 666";
            Object resultat = cmd.ExecuteScalar();
            Console.WriteLine("Resultat = {0}", resultat != null ? resultat : "NULL!!");

            conn.Close();
        }

        static Nullable<T> Lire<T>(SqlDataReader reader, int nCol) where T : struct {
            object value = reader.GetValue(nCol);
            return value is DBNull ? null : (Nullable<T>)value;
        }
        
        static void Requete3() {
            SqlConnection conn = new SqlConnection(connectionString: connString);
            conn.Open();
            Console.WriteLine("Connexion etablie!");

            //  ajout d'un etudiant
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT name, age, hobbies, yearsOfExperience FROM Student";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                String nom = (String)reader.GetValue(0);
                int age = (int)reader.GetValue(1);

                String hobbie;
                if (reader.GetValue(2) is DBNull) {
                    hobbie = "pas de hobbie speicifie";
                }
                else {
                    hobbie = reader.GetString(2);
                }

                //int? experience;
                //if (reader.GetValue(3) is DBNull) {
                //    experience = null;
                //}
                //else {
                //    experience = (int?)reader.GetValue(3);
                //}

                int? experience = Lire<int>(reader, 3);
                
                //int? experience = reader.GetValue(3) is DBNull ? null : (int?)reader.GetValue(3);

                Console.WriteLine("Nom : {0}, Age: {1}, Hobbie:{2}, Exp: {3}", nom, age, hobbie, experience);
            }


            conn.Close();

        }


        static void Main(string[] args) {
            //Program.Connection();
            //Program.Requete1();
            //Program.Requete2();
            Program.Requete3();
        }
    }
}
