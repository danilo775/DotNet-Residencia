// Em C#, você pode converter um tipo double para um tipo int usando a conversão explícita, 
// conhecida como cast. No entanto, ao fazer isso, a parte fracionária será truncada,
//  o que significa que qualquer valor após o ponto decimal será removido. 
//  Se a parte fracionária não puder ser representada como um número inteiro válido, 
// a conversão resultará em perda de dados.
 double numeroDouble = 10.75;

        // Convertendo double para int
        int numeroInteiro = (int)numeroDouble;

        Console.WriteLine("Número Double: " + numeroDouble);
        Console.WriteLine("Número Inteiro (após conversão): " + numeroInteiro);

        // O número 10.99 com a parte fracionária não pode ser representada como um int válido
        double numeroComParteFracionaria = 10.99;

        // Tentando converter double para int
        int numeroInteiroComParteFracionaria = (int)numeroComParteFracionaria;

        // Exibindo os resultados
        Console.WriteLine("\nNúmero Double com parte fracionária: " + numeroComParteFracionaria);
        Console.WriteLine("Número Inteiro com parte fracionária (após conversão): " + numeroInteiroComParteFracionaria);

        Console.ReadLine();