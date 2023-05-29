using System.Collections.ObjectModel;
using System.ComponentModel.Design;

namespace Basico
{
    public class Program
    {
        private object intArray;
        private object intList;

        static void Main(string[] args)
        {
            int idade = 30;

            float peso = 70.25f;

            string Nome = "Emerson";

            bool isTeste = true;

            int[] intArray = new int[] {1,2,3,4,5,6,7,8,9,10 };

            List<int> intlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            inList.Add(5);
            inList.Remove(1);

            Console.WriteLine(idade);
            Console.WriteLine(peso);
            Console.WriteLine(Nome);
            Console.WriteLine(isTeste);
        }

        void Movimento() 
        {
            foreach (int intNumbers in intList)//foreach pode ser usado tanto com arry com list
            {

            }
            for (int i = 0; i < intArray.Length; i++) //length valor a ser passado para a quantidade de leitura
            {
                int currentNumber = intArray[i];
            }
            for (int i = 0; i < intList.Count; i++) //Count valor a ser passado para a quantidade de leitura
            {
                int currentNumber = intList[i];
            }

            if (speed >= 0)
            {
                Console.WriteLine("Em movimento!")
            }
        }
        Else(speed< 0)
        {
            Console.WriteLine("Está parado")
        }
}