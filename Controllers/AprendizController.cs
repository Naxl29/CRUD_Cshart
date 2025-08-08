using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Cshart.Database;
using CRUD_Cshart.Models;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD_Cshart.Controllers
{
    internal class AprendizController : ConexionMysql
    {
        public bool CrearAprendiz(Aprendiz aprendiz)
        {
            try
            {
                using (MySqlConnection conn = getConnection())
                {
                    string query = @"INSERT INTO aprendices 
                    (primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, tipo_documento_id, numero_documento,
                     grupo_sanguineo_id, factor_sanguineo_id, genero_id, programa_id)
                    VALUES
                    (@primer_nombre, @segundo_nombre, @primer_apellido, @segundo_apellido, @fecha_nacimiento, @tipo_documento_id, @numero_documento,
                     @grupo_sanguineo_id, @factor_sanguineo_id, @genero_id, @programa_id)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@primer_nombre", aprendiz.PrimerNombre);
                    cmd.Parameters.AddWithValue("@segundo_nombre", aprendiz.SegundoNombre);
                    cmd.Parameters.AddWithValue("@primer_apellido", aprendiz.PrimerApellido);
                    cmd.Parameters.AddWithValue("@segundo_apellido", aprendiz.SegundoApellido);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", aprendiz.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@tipo_documento_id", aprendiz.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@numero_documento", aprendiz.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@grupo_sanguineo_id", aprendiz.GrupoSanguineoId);
                    cmd.Parameters.AddWithValue("@factor_sanguineo_id", aprendiz.FactorSanguineoId);
                    cmd.Parameters.AddWithValue("@genero_id", aprendiz.GeneroId);
                    cmd.Parameters.AddWithValue("@programa_id", aprendiz.ProgramaId);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
                return false;
            }
        }
        public bool VerAprendiz(int id)
        {
            try
            {
                using (MySqlConnection conn = getConnection())
                {
                    string query = "SELECT * FROM aprendices WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Aprendiz aprendiz = new Aprendiz
                        {
                            Id = reader.GetInt32("id"),
                            PrimerNombre = reader.GetString("primer_nombre"),
                            SegundoNombre = reader.GetString("segundo_nombre"),
                            PrimerApellido = reader.GetString("primer_apellido"),
                            SegundoApellido = reader.GetString("segundo_apellido"),
                            FechaNacimiento = reader.GetDateTime("fecha_nacimiento"),
                            TipoDocumentoId = reader.GetInt32("tipo_documento_id"),
                            NumeroDocumento = reader.GetString("numero_documento"),
                            GrupoSanguineoId = reader.GetInt32("grupo_sanguineo_id"),
                            FactorSanguineoId = reader.GetInt32("factor_sanguineo_id"),
                            GeneroId = reader.GetInt32("genero_id"),
                            ProgramaId = reader.GetInt32("programa_id")
                        };
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Aprendiz no encontrado.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
                return false;
            }
        }

        public bool EliminarAprendiz(int id)
        {
            try
            {
                using (MySqlConnection conn = getConnection())
                {
                    string query = "DELETE FROM aprendices WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
        }
    }
}
