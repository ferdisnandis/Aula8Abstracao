namespace Aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public float novoLimite;

        /// <summary>
        /// Aumentar o limite do cartão
        /// </summary>
        /// <param name="limiteAtual"></param>
        /// <param name="acrescimo"></param>
        /// <returns>Novo limite</returns>
        public float AumentarLimite(float limiteAtual, float acrescimo){
            return novoLimite = limiteAtual + acrescimo;
        }
        public string BloquearCartaoDeCredito(){
            return "Cartão de Crédito bloqueado";
        }
    }
}