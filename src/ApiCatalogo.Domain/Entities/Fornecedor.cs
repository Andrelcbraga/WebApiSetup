﻿using ApiCatalogo.Domain.Common;

namespace ApiCatalogo.Domain.Entities
{
    public class Fornecedor : Entity
    {
        public string? Nome { get; set; }
        public string? Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco? Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
