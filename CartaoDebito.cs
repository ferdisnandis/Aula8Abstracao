namespace Aula08Abstracao
{
    public class CartaoDebito
    {
        public float saldo { get; set; }

        /// <summary>
        /// Transferencia
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>O valor que foi transferido</returns>
        public string Transferir(float valor){
            return $"R$ {valor} transferido da sua conta";
        }

        /// <summary>
        /// Pagar título
        /// </summary>
        /// <returns>Mensagem de confirmação</returns>
        public string PagarTitulo(){
            return "Título pago com cartão de débito";
        }
    }
}