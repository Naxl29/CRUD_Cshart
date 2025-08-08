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
                    (primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimineto, tipo_documento_id, numero_documento,
                     grupo_sanguineo_id, factor_sanguineo_id, genero_id, programa_id)
                    VALUES
                    (@primer_nombre, @segundo_nombre, @primer_apellido, @segundo_apellido, @fecha_nacimineto, @tipo_documento_id, @numero_documento,
                     @grupo_sanguineo_id, @factor_sanguineo_id, @genero_id, @programa_id)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@primer_nombre", aprendiz.PrimerNombre);
                    cmd.Parameters.AddWithValue("@segundo_nombre", aprendiz.SegundoNombre);
                    cmd.Parameters.AddWithValue("@primer_apellido", aprendiz.PrimerApellido);
                    cmd.Parameters.AddWithValue("@segundo_apellido", aprendiz.SegundoApellido);
                    cmd.Parameters.AddWithValue("@fecha_nacimineto", aprendiz.FechaNacimiento);
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
    }
}
