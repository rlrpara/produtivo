﻿using Produtivo.Domain.Entities;

namespace Produtivo.Domain.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Login logar(Login login);
    }
}
