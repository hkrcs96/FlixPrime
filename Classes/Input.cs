
namespace FlixPrime.Classes
{
  public static class Input
  {
    public static int GetInt()
    {
      int retorno = 0;
      bool validou = false;

      while (!validou)
      {
        try
        {
          retorno = int.Parse(Console.ReadLine());
          validou = true;
        }
        catch (System.FormatException)
        {
          Console.WriteLine("Digite apenas números!");
        }
      }
      return retorno;
    }

    public static string GetOption()
    {
      string retorno = "";
      bool validou = false;

      while (!validou)
      {
        retorno = Console.ReadLine();
        if (retorno.Length == 1) return retorno;
        Console.WriteLine("Digite apenas o índice da opção");
      }
      return retorno;
    }

    public static string GetInput()
    {
      string retorno = "";

      while ((retorno = Console.ReadLine()) == null)
      {
        Console.WriteLine("Campo não pode ser nulo!");
      }

      return retorno;
    }

    public static bool GetBool()
    {
      bool repetir = true;
      while (true)
      {
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        string input = Console.ReadLine();
        if (input == "1") return true;
        if (input == "2") return false;
      }
    }
    public static void EncerrarAplicacao()
    {
      Console.WriteLine(Environment.NewLine + "Agracemos por usar nossos serviços."
          + Environment.NewLine + "Pressione qualquer tecla para sair!");
      Console.ReadKey();
      Environment.Exit(0);
    }
  }
}