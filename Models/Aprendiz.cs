using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Cshart.Models
{
    internal class Aprendiz
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public int GrupoSanguineoId { get; set; }
        public int FactorSanguineoId { get; set; }
        public int GeneroId { get; set; }
        public int ProgramaId { get; set; }


    }
}
