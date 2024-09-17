class Program
{

    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Olá, Me chamo CALCULADORA! E estou aqui para lhe ajudar!!!");
        Console.WriteLine("[ 1 ] Somar");
        Console.WriteLine("[ 2 ] Subtrair");
        Console.WriteLine("[ 3 ] Multiplicar");
        Console.WriteLine("[ 4 ] Dividir");
        Console.WriteLine("[ 0 ] Sair");

        Console.WriteLine("-----------------------");
        Console.WriteLine("Escolha uma das opções!");

        int selecao = Convert.ToInt32(Console.ReadLine());

        switch(selecao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 0: Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    static void Soma()
    {

        Console.Clear();

        Console.WriteLine("-----------");
        Console.WriteLine("Somando...");
        Console.WriteLine("-----------");
        Console.WriteLine("");
    
        Console.WriteLine("Digite o primeiro número: ");
        double num1  = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        
        Console.WriteLine($"A soma dos números {num1} e {num2} é: {soma}");

        Console.ReadKey();
        Menu();
        
    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("--------------");
        Console.WriteLine("Subtraindo...");
        Console.WriteLine("--------------");
        Console.WriteLine("");

        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double subtracao = num1 - num2;

        Console.WriteLine($"A subtração dos números {num1} e {num2} é : {subtracao}");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("-----------------");
        Console.WriteLine("Multiplicando...");
        Console.WriteLine("-----------------");
        Console.WriteLine("");

        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double multiplicacao = num1 * num2;

        Console.WriteLine($"A Multiplicação dos números {num1} e {num2} é: {multiplicacao}");

        Console.ReadKey();
        Menu();
    }

    static void Divisao()

    {

    Console.Clear();

    Console.WriteLine("-------------");
    Console.WriteLine("Dividindo...");
    Console.WriteLine("-------------");
    Console.WriteLine("");

    Console.WriteLine("Digite o primeiro número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    if(num2 != 0){
        double divisao = num1 / num2;

        Console.WriteLine($"A Divisão dos números {num1} e {num2} é: {divisao}");
    }
    else
    {
        Console.WriteLine("Não é possível dividir por zero");
    }

    Console.ReadKey();
    Menu();

    }

}