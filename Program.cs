// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Sistema_De_Celular;

Celular1 C1 = new Celular1();

Console.WriteLine($"Qual é a cor do sue celular?");
C1.cor = Console.ReadLine();

Console.WriteLine($"Qual é o modelo do seu celular?");
C1.modelo = Console.ReadLine();

Console.WriteLine($"Qual é o tamnho dele?");
C1.modelo = Console.ReadLine();


Console.WriteLine($"Seu celular está ligado?");
string resposta = Console.ReadLine().ToLower();

if (resposta == "sim" || resposta == "s")
{
    C1.ligado = true;
}
else if (resposta == "não" || resposta == "n" || resposta == "nao")
{
    C1.ligado = false;

}
else
{
    C1.ligado = false;
    Console.WriteLine($"Resposta inválida");
}

string escolha;
do
{
    Console.WriteLine(@$"
        Menu:
    [1] Ligar para Alguém
    [2] Envia Mensagem para Alguém
    [0] Desligar
");
    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            Console.WriteLine($"Para quem você quer ligar?");
            C1.nomeContato = Console.ReadLine();

            Console.WriteLine($"Qual numero de telefone dele?");
            C1.NumeroContaro = Console.ReadLine();

            Console.WriteLine($"O contato {C1.ligacao()}, está indesponivel");

            break;
        case "2":
            Console.WriteLine($"Para quem você quer eniva mensagem?");
            C1.nomeContato = Console.ReadLine();

            Console.WriteLine($"Qual numero do Contato?");
            C1.NumeroContaro = Console.ReadLine();

            Console.WriteLine($"Que mensagem você que envia?");
            string mensagem = Console.ReadLine();

            Console.WriteLine(mensagem);
            Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"o número de {C1.nomeContato} está indisponível");
            break;
        case "0":
            C1.ligado = false;
            Console.WriteLine($"... Bye");
            break;
        default:
            C1.ligado = false;
            Console.WriteLine($"Opção inválida");
            break;
    }

}
while (escolha != "0" || C1.ligado != false);