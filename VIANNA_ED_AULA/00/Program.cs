﻿internal class Program
{
    private static void Main(string[] args)
    {
        int retornaSomaIntervalo(int menor, int maior){
            
            if (menor > maior){
                return 0;
            }

            return menor + retornaSomaIntervalo(menor + 1, maior);
        }

        Console.WriteLine($"Soma: {retornaSomaIntervalo(3,5)}");

        /*
        void imprimeSomaIntervalo(int menor, int maior, int soma){
            
            if (menor > maior){
                Console.WriteLine(soma);
                return; 
            }

            soma += menor;
            imprimeSomaIntervalo(menor + 1, maior, soma);
        }

        imprimeSomaIntervalo(3,5,0);
        */

        /*
        void imprimeIntervalo(int menor, int maior){
            if (menor > maior)
                return;

            Console.WriteLine(menor);
            imprimeIntervalo(menor + 1, maior);
        }

        imprimeIntervalo(3,5);
        */

        /*
        void imprime(int numero){
            
            if (numero < 1)
                return;
            
            imprime(numero - 1);
            Console.WriteLine(numero);  
        }

        imprime(10);
        */

        /*
        void imprimeDecrescente(int numero){
            
            if (numero < 1)
                return;
            
            Console.WriteLine(numero);
            imprimeDecrescente(numero - 1);
            
        }
        */

        /*
            void imprimeCrescente(int numero){

                if (numero < 1)
                    return;

                Console.WriteLine(numero);
                imprimeCrescente(numero + 1);

            }

            imprimeCrescente(1);    
            */
    }
}
