namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set;}
        public string cvv { get; set; }
        private string token = "d23f132f1a335fEW1W2Ff2WE";

        /// <summary>
        /// Validar token
        /// </summary>
        /// <returns>Se ele não está vazio</returns>
        public bool validarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}