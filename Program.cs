string nomeEquipamento = "Notebook";
bool situacao = false;
int quantidadeEmprestada = 1;
bool emprestimoAtrasado = false;

int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("\n===== CAMPUSLAB =====");
    Console.WriteLine("1 - Consultar Equipamentos");
    Console.WriteLine("2 - Solicitar empréstimo");
    Console.WriteLine("3 - Consultar meus empréstimos");
    Console.WriteLine("4 - Sair");
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nVocê escolheu consultar equipamentos.");
            Console.WriteLine("Equipamento: " + nomeEquipamento);

            if (situacao == true)
            {
                Console.WriteLine("Equipamento disponível.");
            }
            else
            {
                Console.WriteLine("Equipamento não disponível.");
            }
            break;

        case 2:
            Console.WriteLine("\nVocê escolheu solicitar empréstimo.");

            if (situacao == true && emprestimoAtrasado == false && quantidadeEmprestada < 2)
            {
                Console.WriteLine("Você pode solicitar um novo empréstimo.");
            }
            else
            {
                Console.WriteLine("Não pode solicitar um novo empréstimo.");
            }
            break;

        case 3:
            Console.WriteLine("\nVocê escolheu consultar meus empréstimos.");
            Console.WriteLine("Quantidade de empréstimos: " + quantidadeEmprestada);
            break;

        case 4:
            Console.WriteLine("\nEncerrando o CampusLab. Até mais!");
            break;

        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            break;
    }
}