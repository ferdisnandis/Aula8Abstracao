using System;

namespace Aula08Abstracao
{
    public class Pagamento
    {
        //get = permissão de leitura da variável
        //set = permissão de escrita da variável

        public DateTime data { get; set; }
        public float valor { get; set; }

        /// <summary>
        /// Pagamento feito
        /// </summary>
        /// <returns>Mensagem que foi efetuado</returns>
        public string Pagar(){
            return "Pagamento efetuado";
        }

        /// <summary>
        /// Pagamento cancelado
        /// </summary>
        /// <returns>Mensagem que foi cancelado</returns>
        public string CancelarPagamento(){
            return "Pagamento cancelado";
        }
    }
}