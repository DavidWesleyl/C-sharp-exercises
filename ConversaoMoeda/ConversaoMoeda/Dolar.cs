using System;


namespace ConversaoMoeda
{
    internal class Dolar
    {

        public static double ValorDolar; 

        public static double Quantidade;



        public static double Calculo() // Quantidade de dólares
        {

            return ValorDolar * Quantidade;             
        
        }

        public static double IOF() // Imposto de 6% sobre o valor em dolar
        {
            return 0.06 * Calculo();
        }
      

        public static double Total() // Total a ser pago
        {
            return Calculo() + IOF();
        }
        

       


    
    
    
    
    }
}
