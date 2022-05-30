using FlixPrime.Model;

namespace FlixPrime.Classes
{
  public static class Menu
  {
    public static void AbrirMenu(int menuEscolhido)
    {
      bool repetir = true;

      while (repetir)
      {
        switch (menuEscolhido)
        {
          case 1:
            OpcaoFilme();
            break;
          case 2:
            OpcaoSerie();
            break;
          case 3:
            OpcaoNovela();
            break;
          case 4:
            OpcaoDesenho();
            break;
        }

        string escolha = Input.GetOption();

        switch (escolha.ToUpper())
        {
          case "0":
            repetir = false;
            break;
          case "1":
            Cadastro.ListData(menuEscolhido);
            Console.WriteLine(Environment.NewLine + "Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
          case "2":
            Cadastro.NovoCadastro(menuEscolhido);
            Console.WriteLine(Environment.NewLine + "Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
          case "3":
            Console.Write("Digite o ID do cadastro que deseja fazer modificações: ");
            int idForChanges = Input.GetInt();
            Cadastro.ChangeData(idForChanges, false);
            Console.WriteLine(Environment.NewLine + "Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
          case "4":
            Console.Write("Digite o ID do cadastro que deseja excluir: ");
            idForChanges = Input.GetInt();
            Cadastro.ChangeData(idForChanges, true);
            Console.WriteLine("Para desfazer exclusões bastar passar o ID do cadastro no menu de atualizar!");
            Console.WriteLine(Environment.NewLine + "Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
          case "5":
            Console.Write("Digite o ID do cadastro que deseja visualizar detalhes: ");
            idForChanges = Input.GetInt();
            Cadastro? cadastro = Cadastro.GetData(idForChanges);
            if (cadastro != null) Console.WriteLine(cadastro.GetDetails());
            Console.WriteLine(Environment.NewLine + "Pressione ENTER para continuar.");
            Console.ReadLine();
            break;
          case "C":
            Console.Clear();
            break;
          case "X":
            Input.EncerrarAplicacao();
            break;
          default:
            Console.WriteLine("Opção não encontrada, tente novamente.");
            break;
        }
      }
    }

    public static void MenuInicial()
    {
      Console.WriteLine();
      Console.WriteLine("Bem vindo(a) ao Flix Prime, escolha uma opção:");
      Console.WriteLine("1 - Filmes");
      Console.WriteLine("2 - Series");
      Console.WriteLine("3 - Novelas");
      Console.WriteLine("4 - Desenhos");
      Console.WriteLine("C - Limpar tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();
    }
    public static void OpcaoFilme()
    {
      Console.WriteLine();
      Console.WriteLine("Flix Prime Filmes a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("0 - Retornar ao menu anterior");
      Console.WriteLine("1 - Listar filmes");
      Console.WriteLine("2 - Inserir novo filme");
      Console.WriteLine("3 - Atualizar filme");
      Console.WriteLine("4 - Excluir filme");
      Console.WriteLine("5 - Visualizar filme");
      Console.WriteLine("C - Limpar tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();
    }

    public static void OpcaoSerie()
    {
      Console.WriteLine();
      Console.WriteLine("Flix Prime Séries a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("0 - Retornar ao menu anterior");
      Console.WriteLine("1 - Listar séries");
      Console.WriteLine("2 - Inserir nova série");
      Console.WriteLine("3 - Atualizar série");
      Console.WriteLine("4 - Excluir série");
      Console.WriteLine("5 - Visualizar série");
      Console.WriteLine("C - Limpar tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();
    }

    public static void OpcaoNovela()
    {
      Console.WriteLine();
      Console.WriteLine("Flix Prime Novelas a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("0 - Retornar ao menu anterior");
      Console.WriteLine("1 - Listar novelas");
      Console.WriteLine("2 - Inserir nova novela");
      Console.WriteLine("3 - Atualizar novela");
      Console.WriteLine("4 - Excluir novela");
      Console.WriteLine("5 - Visualizar novela");
      Console.WriteLine("C - Limpar tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();
    }

    public static void OpcaoDesenho()
    {
      Console.WriteLine();
      Console.WriteLine("Flix Prime Desenhos a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("0 - Retornar ao menu anterior");
      Console.WriteLine("1 - Listar desenhos");
      Console.WriteLine("2 - Inserir novo desenho");
      Console.WriteLine("3 - Atualizar desenho");
      Console.WriteLine("4 - Excluir desenho");
      Console.WriteLine("5 - Visualizar desenho");
      Console.WriteLine("C - Limpar tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

    }
  }
}