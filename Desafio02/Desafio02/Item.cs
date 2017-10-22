namespace Desafio02
{
    class Item
    {
        #region Declaração de atributos
        public string Descricao;
        public object ValMax;
        public object ValMin;
        #endregion

        /// <summary>
        /// Construtor da classe Item
        /// </summary>
        /// <param name="descricao">Nome do tipo de variável</param>
        /// <param name="valMax">Valor máximo do tipo de variável</param>
        /// <param name="valMin">Valor mínimo do tipo de variável</param>
        public Item(string descricao, object valMax, object valMin)
        {
            this.Descricao = descricao;
            this.ValMax = valMax;
            this.ValMin = valMin;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
