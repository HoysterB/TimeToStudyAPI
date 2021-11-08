using System.Threading.Tasks;
using TimeToStudy.Application.DTOs;

namespace TimeToStudy.Application.Contracts.Repository
{
    public interface IUsuarioRepository
    {
        public Task AdicionarUsuario(UsuarioDTO model);
        public Task AlterarUsuario(UsuarioDTO model);
        public Task ExcluirUsuario(int usuarioId);
        public Task RecuperarSenha(int usuarioId);
    }
}