using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSetup.Domain.Entidades
{
    public class Categoria
    {
        public Guid CategoriaId { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        //public ICollection<Evento> Eventos { get; set; }
    }
}
