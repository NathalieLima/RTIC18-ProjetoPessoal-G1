using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escabo.Application.Model.ViewInput;
using Escabo.Application.Model.ViewOutput;

namespace Escabo.Application.Services.Interface
{
    public interface IUsuarioService
    {
        public List<UsuarioViewModel> GetAll();
        public UsuarioViewModel? GetById(int id);
        public int Create(UsuarioInputModel usuario);
        public void Update(int id, UsuarioInputModel usuario);
        public void Delete(int id);
    }
}