using System;

namespace CursoFoop_ModeloAnemico1
{
    class Item
    {

        public Item(int itemId, int  pedidoId, string itemNome, decimal itemPreco)
        {
            if (pedidoId <= 0)
            {
                throw new ArgumentException("O codigo do pedido tem quer ser maior que zero");
            }

            if (itemId <= 0 )
            {
                throw new ArgumentException("codigo invalido");
            }

            this.ItemId = itemId;
            this.PedidoId = pedidoId;
            this.ItemNome = itemNome;
            this.ItemPreco = itemPreco;                
        }

        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }

        private string _itemNome;
        public string ItemNome
        { 
            get => this._itemNome;
            private set
            {
                this._itemNome = (value.Length > 100) ? throw new ArgumentOutOfRangeException(nameof(ItemNome),"Excedeu 100 caracteres") : value;
            }
        }
        private decimal _itemPreco;
        public decimal ItemPreco 
        { get => this._itemPreco;
          private set
            {
                this._itemPreco = (value <= 0) ? throw new ArgumentOutOfRangeException(nameof(ItemPreco), "Preco zero") : value;
            }
        }

    }
}
