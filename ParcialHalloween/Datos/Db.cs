using ParcialHalloween.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcialHalloween.Datos
{
    public class Db {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;

        public Db() {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = cadenaConexion;
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        #region CREATES
        public bool AgregarUsuario(string nombre, string nombreDeUsuario, string contraseña, string rol, string disfraz, string codigoInv, string foto)
        {
            int filas;
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AgregarUsuario";

                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@nombreDeUsuario", nombreDeUsuario));
                cmd.Parameters.Add(new SqlParameter("@contraseña", contraseña));
                cmd.Parameters.Add(new SqlParameter("@rol", rol));
                cmd.Parameters.Add(new SqlParameter("@disfraz", disfraz));
                cmd.Parameters.Add(new SqlParameter("@codigoInv", codigoInv));
                cmd.Parameters.Add(new SqlParameter("@foto", foto));

                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario");
            }
            finally
            {
                con.Close();
            }

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarParada(string nombre, int cant, string tipoDulces)
        {
            int filas;
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ParadasDulces (nombre, cantidadIni, cantidadAct, TipoDulces) VALUES (@nombre, @cant, @cant, @tipoDulces);";

                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@cant", cant));
                cmd.Parameters.Add(new SqlParameter("@tipoDulces", tipoDulces));

                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar parada");
            }
            finally
            {
                con.Close();
            }

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region READS
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Usuarios";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var usuario = new Usuario()
                        {
                            id = Convert.ToInt32(row["id"].ToString()),
                            nombre = row["nombre"].ToString(),
                            nombreDeUsuario = row["nombreDeUsuario"].ToString(),
                            contraseña = row["contraseña"].ToString(),
                            rol = row["rol"].ToString(),
                            disfraz = row["disfraz"].ToString(),
                            codigoInv = row["codigo_inv"].ToString(),
                            foto = row["foto"].ToString()
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios");
            }
            finally
            {
                con.Close();
            }
            return usuarios;
        }

        public List<Administrador> ObtenerAdministrador()
        {
            List<Administrador> administradores = new List<Administrador>();
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Usuarios WHERE rol = 'Administrador'";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var administrador = new Administrador()
                        {
                            id = Convert.ToInt32(row["id"].ToString()),
                            nombre = row["nombre"].ToString(),
                            nombreDeUsuario = row["nombreDeUsuario"].ToString(),
                            contraseña = row["contraseña"].ToString(),
                            rol = row["rol"].ToString()
                        };
                        administradores.Add(administrador);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener administradores");
            }
            finally
            {
                con.Close();
            }
            return administradores;
        }

        public List<Participante> ObtenerParticipante()
        {
            List<Participante> participantes = new List<Participante>();
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Usuarios WHERE rol = 'Participante'";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var participante = new Participante()
                        {
                            id = Convert.ToInt32(row["id"].ToString()),
                            nombre = row["nombre"].ToString(),
                            nombreDeUsuario = row["nombreDeUsuario"].ToString(),
                            contraseña = row["contraseña"].ToString(),
                            rol = row["rol"].ToString(),
                            disfraz = row["disfraz"].ToString(),
                            codigoInv = row["codigo_inv"].ToString(),
                            foto = row["foto"].ToString()
                        };
                        participantes.Add(participante);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener participantes");
            }
            finally
            {
                con.Close();
            }
            return participantes;
        }

        public List<Participante> ObtenerVotantes(int id) {
            List<Participante> participantes = new List<Participante>();
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Usuarios WHERE rol = 'Participante' AND id != @id;";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@id", id));
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var participante = new Participante()
                        {
                            id = Convert.ToInt32(row["id"].ToString()),
                            nombre = row["nombre"].ToString(),
                            nombreDeUsuario = row["nombreDeUsuario"].ToString(),
                            contraseña = row["contraseña"].ToString(),
                            rol = row["rol"].ToString(),
                            disfraz = row["disfraz"].ToString(),
                            codigoInv = row["codigo_inv"].ToString(),
                            foto = row["foto"].ToString()
                        };
                        participantes.Add(participante);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener participantes");
            }
            finally
            {
                con.Close();
            }
            return participantes;
        }

        public List<Parada_De_Dulces> ObtenerParadas()
        {
            List<Parada_De_Dulces> paradas = new List<Parada_De_Dulces>();

            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ParadasDulces";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var parada = new Parada_De_Dulces()
                        {
                            id = Convert.ToInt32(row["id"].ToString()),
                            nombre = row["nombre"].ToString(),
                            cant_inicial = Convert.ToInt32(row["cantidadIni"].ToString()),
                            cant_actual = Convert.ToInt32(row["cantidadAct"].ToString()),
                            tipoDulces = row["TipoDulces"].ToString(),
                            foto = row["foto"].ToString()
                        };
                        paradas.Add(parada);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener paradas de dulces");
            }
            finally
            {
                con.Close();
            }
            return paradas;
        }

        public List<Tabla_Puntuaciones> ObtenerTablaPuntuaciones()
        {
            List<Tabla_Puntuaciones> puntuaciones = new List<Tabla_Puntuaciones>();
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TablaDePuntajes";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var tablaPuntuaciones = new Tabla_Puntuaciones()
                        {
                            nombre = row["nombre"].ToString(),
                            puntos = Convert.ToInt32(row["puntos"].ToString())
                        };
                        puntuaciones.Add(tablaPuntuaciones);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener paradas de dulces");
            }
            finally
            {
                con.Close();
            }
            return puntuaciones;
        }

        public List<Parada_De_Dulces> ObtenerDisponibleParadas() {
            List<Parada_De_Dulces> paradas = new List<Parada_De_Dulces>();

            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ParadasDulces WHERE cantidadAct > 0";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var parada = new Parada_De_Dulces()
                        {
                            id = Convert.ToInt32(row["id"].ToString()),
                            nombre = row["nombre"].ToString(),
                            cant_inicial = Convert.ToInt32(row["cantidadIni"].ToString()),
                            cant_actual = Convert.ToInt32(row["cantidadAct"].ToString()),
                            tipoDulces = row["TipoDulces"].ToString(),
                            foto = row["foto"].ToString()
                        };
                        paradas.Add(parada);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener paradas de dulces");
            }
            finally
            {
                con.Close();
            }
            return paradas;
        }

        public List<Ranking> ObtenerRanking() {
            List<Ranking> ranking = new List<Ranking>();
            try {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RankingDisfraces";
                cmd.Parameters.Clear();
                ds = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        var rankinG = new Ranking()
                        {
                            nombre = row["nombre"].ToString(),
                            puntos = Convert.ToInt32(row["puntos"].ToString()),
                            disfraz = row["disfraz"].ToString(),
                            foto = row["foto"].ToString()
                        };
                        ranking.Add(rankinG);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ranking de puntuaciones");
            }
            finally
            {
                con.Close();
            }
            return ranking;
        }
        #endregion

        #region UPDATES
        public bool ActualizarUsuario(int id, string nombre, string nombreDeUsuario, string contraseña, string rol, string disfraz, string codigoInv, string foto) {
            int filas;
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarUsuario";
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@nombreDeUsuario", nombreDeUsuario));
                cmd.Parameters.Add(new SqlParameter("@contraseña", contraseña));
                cmd.Parameters.Add(new SqlParameter("@rol", rol));
                cmd.Parameters.Add(new SqlParameter("@disfraz", disfraz));
                cmd.Parameters.Add(new SqlParameter("@codigoInv", codigoInv));
                cmd.Parameters.Add(new SqlParameter("@foto", foto));

                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario");
            }
            finally {
                con.Close();
            }

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ActualizarParticipante(Participante participante)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Usuarios SET nombre = @nombre, nombreDeUsuario = @nombreDeUsuario, contraseña = @contraseña, disfraz = @disfraz, foto = @foto WHERE id = @id";

                cmd.Parameters.Add(new SqlParameter("@nombre", participante.nombre));
                cmd.Parameters.Add(new SqlParameter("@nombreDeUsuario", participante.nombreDeUsuario));
                cmd.Parameters.Add(new SqlParameter("@contraseña", participante.contraseña));
                cmd.Parameters.Add(new SqlParameter("@disfraz", participante.disfraz));
                cmd.Parameters.Add(new SqlParameter("@foto", participante.foto));
                cmd.Parameters.Add(new SqlParameter("@id", participante.id));

                con.Open();
                int filas = cmd.ExecuteNonQuery();

                return filas;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int ActualizarParada(Parada_De_Dulces parada) {
            try {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE ParadasDulces SET nombre = @nombre, cantidadIni = @cant, cantidadAct = @cant, TipoDulces = @tipoDulces WHERE id = @id";

                cmd.Parameters.Add(new SqlParameter("@nombre", parada.nombre));
                cmd.Parameters.Add(new SqlParameter("@cant", parada.cant_inicial));
                cmd.Parameters.Add(new SqlParameter("@tipoDulces", parada.tipoDulces));
                cmd.Parameters.Add(new SqlParameter("@id", parada.id));

                con.Open();
                int filas = cmd.ExecuteNonQuery();

                return filas;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public int ActualizarCantidadParadas(int cantidad, Parada_De_Dulces parada) {
            try {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE ParadasDulces SET cantidadAct = (cantidadAct - @cantidad) WHERE id = @id";

                cmd.Parameters.Add(new SqlParameter("@cantidad",cantidad));
                cmd.Parameters.Add(new SqlParameter("@id",parada.id));

                con.Open();
                int filas = cmd.ExecuteNonQuery();

                return filas;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion

        #region DELETES
        public bool EliminarUsuario(int id) {
            int filas;
            try {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Usuarios WHERE id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@id", id));

                filas = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario");
            }
            finally
            {
                con.Close();
            }

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarParada(int id) {
            int filas;
            try {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM ParadasDulces WHERE id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@id", id));

                filas = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar parada");
            }
            finally
            {
                con.Close();
            }

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}