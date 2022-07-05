namespace Exercicio4
{
     public class Exercicio4_udemy
     {
        static void Main()
        {
           int alcool = 0, gasolina = 0, diesel = 0;
           int escolha = int.Parse(Console.ReadLine());

           while(escolha != 4)
           {
            if(escolha == 1)
            {
                alcool++;
            }
            else if(escolha == 2) 
            {
                gasolina++; 
            }
            else if(escolha == 3)
            {
                diesel++;
            }
            Console.WriteLine("Digite novamente : ");
            escolha = int.Parse(Console.ReadLine());
           }
            
           Console.WriteLine("MUITO OBRIGADO !");
           Console.WriteLine("Alcool : " + alcool); 
           Console.WriteLine("Gasolina : " +gasolina);
           Console.WriteLine("Diesel : " + diesel);
        }
     }
}