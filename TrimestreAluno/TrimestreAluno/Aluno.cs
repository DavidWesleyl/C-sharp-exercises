using System;


namespace TrimestreAluno
{
    internal class Aluno 
    {

        public string Nome; // Atributos;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double NotaFinal() // Calculo das notas;
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() // Retorna se Está ou não aprovado;
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }

  

        public double NotasRestantes() // Notas restantes para aprovação.
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return NotaFinal() - 60.0;
            }
        
        
        
        
        
        
        
        }














    }















}
