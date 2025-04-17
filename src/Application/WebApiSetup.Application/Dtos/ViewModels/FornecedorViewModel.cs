using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSetup.Application.Dtos.ViewModels
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel(Guid id, string nome, string documento, int tipoFornecedor, EnderecoViewModel endereco, bool ativo)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
            TipoFornecedor = tipoFornecedor;
            Endereco = endereco;
            Ativo = ativo;
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public required string Documento { get; set; }

        public int TipoFornecedor { get; set; }

        public required EnderecoViewModel Endereco { get; set; }

        public bool Ativo { get; set; }

        public ICollection<ProdutoViewModel> Produtos { get; set; } = new List<ProdutoViewModel>();

    }
}
