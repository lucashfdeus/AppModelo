using System;

namespace LH.UI.Site.Areas.Produtos.Models
{
    public class Produto
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
