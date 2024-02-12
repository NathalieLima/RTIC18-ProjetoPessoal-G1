using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escabo.Application.Model.ViewInput;
using Escabo.Application.Model.ViewOutput;
using Escabo.Application.Services.Interface;
using Escambo.Dommain.Model;
using Escambo.Infra.Context;

namespace Escabo.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly EscamboContext _context;
        public UsuarioService(EscamboContext context)
        {
            _context = context;
        }

        public int Create(UsuarioInputModel usuarioInput)
        {
            var novoUsuario = new Usuario
            {
                Nome = usuarioInput.Nome,
                Email = usuarioInput.Email,
                Senha = usuarioInput.Senha,
                CPF = usuarioInput.CPF,
                RG = usuarioInput.RG,
                Nascimento = usuarioInput.Nascimento,
                Endereço = usuarioInput.Endereço,
                Status = usuarioInput.Status,
                Credito = usuarioInput.Credito,
                LinkLinkedln = usuarioInput.LinkLinkedln,
                Sobre = usuarioInput.Sobre
            };

            _context.Usuarios.Add(novoUsuario);

            _context.SaveChanges();

            return novoUsuario.UsuarioId;
        }

        private Usuario GetByDbId(int id)
        {
            var _usuario = _context.Usuarios.Find(id);

            if (_usuario is null)
                return null;

            return _usuario;
        }
        public void Delete(int id)
        {
            _context.Usuarios.Remove(GetByDbId(id));
            _context.SaveChanges();
        }

        public List<UsuarioViewModel> GetAll()
        {
            var usuarios = _context.Usuarios.Select(u => new UsuarioViewModel
            {
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                CPF = u.CPF,
                RG = u.RG,
                Nascimento = u.Nascimento,
                Endereço = u.Endereço,
                Status = u.Status,
                Credito = u.Credito,
                LinkLinkedln = u.LinkLinkedln,
                Sobre = u.Sobre
            }).ToList();

            return usuarios;
        }

        public UsuarioViewModel? GetById(int id)
        {
            var usuario = GetByDbId(id);
            if (usuario == null)
                return null;

            var usuarioViewModel = new UsuarioViewModel
            {
               
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                CPF = usuario.CPF,
                RG = usuario.RG,
                Nascimento = usuario.Nascimento,
                Endereço = usuario.Endereço,
                Status = usuario.Status,
                Credito = usuario.Credito,
                LinkLinkedln = usuario.LinkLinkedln,
                Sobre = usuario.Sobre
            };

            return usuarioViewModel;
        }

        public void Update(int id, UsuarioInputModel usuario)
        {
            var _usuario = GetByDbId(id);
            if (_usuario != null)
            {
                _usuario.Nome = usuario.Nome;
                _usuario.Email = usuario.Email;
                _usuario.Senha = usuario.Senha;
                _usuario.CPF = usuario.CPF;
                _usuario.RG = usuario.RG;
                _usuario.Nascimento = usuario.Nascimento;
                _usuario.Endereço = usuario.Endereço;
                _usuario.Status = usuario.Status;
                _usuario.Credito = usuario.Credito;
                _usuario.LinkLinkedln = usuario.LinkLinkedln;
                _usuario.Sobre = usuario.Sobre;

                _context.SaveChanges();
            }
        }
    }
}