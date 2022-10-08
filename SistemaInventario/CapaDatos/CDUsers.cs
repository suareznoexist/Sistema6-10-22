using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CDUsers
    {
        public List<Usuarios> listaUsuarios() 
        {
            List<Usuarios> listaU = new List<Usuarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) 
            {

                try
                {
                    string cadena= "SELECT iduser, Usuario FROM users";

                    SqlCommand cmd = new SqlCommand(cadena, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        while (dr.Read())
                        {
                            listaU.Add(new Usuarios()
                            {
                                IdUser = Convert.ToInt32(dr["iduser"]),
                                Nameuser = dr["Usuario"].ToString()


                            }) ;                               
                        }                 
                    }
                }
                catch (Exception)
                {
                    listaU = new List<Usuarios>();
                }
                return listaU;            
            }       
        
        }

    }
}
