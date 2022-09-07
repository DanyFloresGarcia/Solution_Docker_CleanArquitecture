using Clean_Arqui.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Clean_Arqui.Core.Interfaces;
using System.Threading.Tasks;

namespace Clean_Arqui.Infrastucture.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public async Task<IEnumerable<Usuario>> GetUsers()
        {
            var posts = Enumerable.Range(1, 10).Select(x=> new Usuario
            {
                id = x,
                nombre = $"Description {x}",
                fechaCreacion = DateTime.Now,                
                rol = new Rol
                {
                    id = x * 2
                }
            });
            await Task.Delay(10);

            return posts;
        }
    }
}
