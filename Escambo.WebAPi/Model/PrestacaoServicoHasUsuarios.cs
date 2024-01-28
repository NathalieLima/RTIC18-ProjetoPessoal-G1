using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPi.Model
{
    public class PrestacaoServicoHasUsuarios
    {
        
        public int PrestacaoServicoIdPrestacaoServico { get; set; }
        public int UsuariosIdUsuario { get; set; }
        public bool? IsPrestador { get; set; }
        public PrestacaoServico? PrestacaoServico { get; set; }
        public Usuario? Usuario { get; set; }
    }
}