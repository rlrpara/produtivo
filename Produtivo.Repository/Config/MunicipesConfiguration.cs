using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produtivo.Dominio.Entidades;
using System;

namespace Produtivo.Repositorio.Config
{
    public class MunicipesConfiguration : IEntityTypeConfiguration<Municipe>
    {
        public void Configure(EntityTypeBuilder<Municipe> builder)
        {
            throw new NotImplementedException();
        }
    }
}
