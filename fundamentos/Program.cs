using fundamentos.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome= "Adriano";
pessoa1.Idade = 25;

pessoa1.Apresentar();


DateTime start = DateTime.Now;
Console.WriteLine(start);


string opcao;
bool exibirMenu = true;
while (exibirMenu){
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();


    switch (opcao) {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Remoção  de Cliente");
            break;
        case "4":  
            Console.WriteLine("Encerrando Programa"); 
            exibirMenu = false;
            // Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Condição Inválida");
            break; 

    }

}

Console.WriteLine("Programa finalizado com sucesso");

//finalizado