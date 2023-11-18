int a;
int b;
      
        Console.Write("Digite o valor de 'a': ");
         a = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("Digite o valor de 'b': ");
         b = Convert.ToInt32(Console.ReadLine());

        // Verifica se 'a' é maior que 'b'
        bool resultado = (a > b);

        // Exibe o resultado
        Console.WriteLine($"O valor de 'a' ({a}) é maior que o valor de 'b' ({b})? {resultado}");

        Console.ReadLine();

