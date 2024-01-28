using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPi.Model
{
    public class ConversasHasUsuarios
    {
        public int ConversasIdMensagem { get; set; }
        public int UsuariosIdUsuario { get; set; }
        public Conversa? Conversa { get; set; }
        public Usuario? Usuario { get; set; }
    }
}