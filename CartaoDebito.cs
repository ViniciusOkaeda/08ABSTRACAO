using System;

namespace AULA08ABSTRACAO
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public string Transferir(){
            return "Transferência efetuada";
        }

        public string PagarTitulo(){
            return "Titulo pago";
        }
    }
}