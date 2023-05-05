// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. 

// A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);

// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);

// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);

// Subir : para subir um andar (não deve subir se já estiver no último andar);

// Descer : para descer um andar (não deve descer se já estiver no térreo);

// Encapsular todos os atributos da classe (criar os métodos set e get).

using Exercicios_POO;

Elevador elevador = new Elevador();

elevador.andarTotal = 10;
elevador.capacidade = 7;
elevador.Inicializar(elevador.andarTotal, elevador.capacidade);

string opcao; 
do
{
    
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($@"
============================================
Bem-vindo ao menu do elevador!
Escolha a opção que mais atende aos seus desejos!

[1] - Entrar.
[2] - Remover.
[3] - Subir.
[4] - Descer.
[0] - Encerrar sistema.
=============================================
");
Console.ResetColor();
 opcao =  Console.ReadLine()!;


switch (opcao)
{
    case "1":
    elevador.Entrar();
    Console.WriteLine($"Uma pessoa entrou no elevador...");
    break;
    case "2":
    elevador.Sair();
    Console.WriteLine($"Uma pessoa foi removida do elevador...");
    break;
    case "3": 
    elevador.Subir();
    Console.WriteLine($"O elevador está subindo...");
    break;
    case "4":
    elevador.Descer();
    Console.WriteLine($"O elevador está descendo...");
    break;
    case "0":
    Console.WriteLine($"Encerrando o sistema elevador...");
    break;
    default:
        break;
} 
} while (opcao != "0");




// Console.WriteLine(@$"
// Bem vindo ao elevador comercial! precione a tecla referente ao andar desejado :");
// Console.WriteLine(@$"
// || [1] - SUBIR    ||
// || [2] - DESCER   ||
// || [3] - ENTRAR   ||
// || [4] - SAIR     ||
// ||                ||
// || [0] - DESLIGAR ||
// ");