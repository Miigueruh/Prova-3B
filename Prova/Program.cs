using Prova;

while (true)
{
    Console.Write("Deseja cadastrar um/outro usuário?\n 1 - Sim\n Qualquer outro número - Não\n");
    int opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("\nQue tipo de funcionário deseja cadastrar?\n 1 - Funcionário comum\n 2 - Médico\n 3 - Funcionário do Administrativo\n");
        int opcao2 = Convert.ToInt32(Console.ReadLine());

        if (opcao2 == 1)
        {

            Funcionario f = new Funcionario();
            Console.Write("\nDigite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.Write("\nDigite o CPF do funcionário: ");
            f.Cpf = Console.ReadLine();
            Console.Write("\nDigite a matrícula do funcionário: ");
            f.Matricula = Console.ReadLine();
            Console.Write("\nDigite a data de nascimento do funcionário: ");
            f.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nDigite o sexo do funcionário: ");
            f.Sexo = Console.ReadLine();
            Console.Write("\nDigite o salário do funcionário: ");
            f.Salario = Convert.ToDouble(Console.ReadLine());

            List<Funcionario> listaFun = new List<Funcionario>();
            listaFun.Add(f);
            Console.WriteLine("\nFuncionário cadastrado com sucesso.\n");
        }
        else if (opcao2 == 2)
        {
            Medico m = new Medico();
            Console.Write("\nDigite o nome do funcionário: ");
            m.Nome = Console.ReadLine();
            Console.Write("\nDigite o CPF do funcionário: ");
            m.Cpf = Console.ReadLine();
            Console.Write("\nDigite a matrícula do funcionário: ");
            m.Matricula = Console.ReadLine();
            Console.Write("\nDigite a data de nascimento do funcionário: ");
            m.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nDigite o sexo do funcionário: ");
            m.Sexo = Console.ReadLine();
            Console.Write("\nDigite o salário do funcionário: ");
            m.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o CRM do funcionário: ");
            m.Crm = Console.ReadLine();
            Console.Write("\nDigite o valor da hora extra do funcionário: ");
            m.ValorHoraExtra = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite a especialidade do funcionário: ");
            m.Especialidade = Console.ReadLine();



            Console.WriteLine("\nFuncionário cadastrado com sucesso.\n");
        }
        else if (opcao2 == 3)
        {

            Administrativo a = new Administrativo();
            Console.Write("\nDigite o nome do funcionário: ");
            a.Nome = Console.ReadLine();
            Console.Write("\nDigite o CPF do funcionário: ");
            a.Cpf = Console.ReadLine();
            Console.Write("\nDigite a matrícula do funcionário: ");
            a.Matricula = Console.ReadLine();
            Console.Write("\nDigite a data de nascimento do funcionário: ");
            a.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nDigite o sexo do funcionário: ");
            a.Sexo = Console.ReadLine();
            Console.Write("\nDigite o salário do funcionário: ");
            a.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite a função do funcionário: ");
            a.Funcao = Console.ReadLine();



            Console.WriteLine("\nFuncionário cadastrado com sucesso.\n");
        }

        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
    else
    {
        break;
    }

}
Console.ReadKey();