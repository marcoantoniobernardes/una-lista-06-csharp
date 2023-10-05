/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    // Vetor  ou array é uma estrutura de dados unidimensional que armazena elementos do mesmo tipo de dado de forma sequencial.
    int[] vetor = new int[] {0, 1, 2, 3};
    Console.WriteLine("Vetor: ");
    for(int i = 0; i<vetor.Length; i++)
        Console.Write(vetor[i]+" " );
        
    //Matriz é uma estrutura de dados bidimensional que organiza elementos em linhas e colunas, criando uma grade de elementos. Cada elemento é acessado por meio de dois índices: um para a linha e outro para a coluna. 
    Console.WriteLine("\nmatriz:");
    int[,] matriz = new int[,]
    {
        {0, 1, 2},
        {0, 1, 2},
        {0, 1, 2}
    };
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
    //Cubo é uma estrutura de dados tridimensional que organiza elementos em três dimensões: comprimento, largura e altura.
    int[,,] cubo = {
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            },
            {
                {10, 11, 12},
                {13, 14, 15},
                {16, 17, 18}
            }
        };
    for (int i = 0; i < cubo.GetLength(0); i++)
    {
        Console.WriteLine("Camada " + (i + 1) + ":");
        for (int j = 0; j < cubo.GetLength(1); j++)
        {
            for (int k = 0; k < cubo.GetLength(2); k++)
            {
                Console.Write(cubo[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
  }
}