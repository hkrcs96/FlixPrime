using FlixPrime.Classes;
using FlixPrime.Context;
using FlixPrime.Enums;

namespace FlixPrime.Model
{
  public class Cadastro
  {
    public int id { get; private set; }
    public Tipo tipo { get; private set; }
    public Genero genero { get; private set; }
    public string titulo { get; private set; }
    public string descricao { get; private set; }
    public int ano { get; private set; }
    public bool ativo { get; private set; }

    private Cadastro() { }

    public static void NovoCadastro(int menuEscolhido)
    {
      Cadastro cadastro = new Cadastro();
      cadastro.id = default;
      cadastro.tipo = (Tipo)menuEscolhido;
      cadastro.genero = MudarGenero();
      cadastro.titulo = MudarTitulo();
      cadastro.descricao = MudarDescricao();
      cadastro.ano = MudarAno();
      cadastro.ativo = true;

      Console.WriteLine(SaveData(cadastro));
    }

    public static void ListData(int tipo)
    {
      using (var context = new CadastroContext())
      {
        var cadastros = context.Cadastros.Where(c => c.tipo.Equals((Tipo)tipo)).OrderBy(c => c.id).OrderByDescending(c => c.ativo).ToList();
        if (cadastros.Count == 0)
          Console.WriteLine($"Nenhum(a) {Enum.GetName(typeof(Tipo), tipo)} cadastrado(a)!");
        else
          Console.WriteLine((((Tipo)tipo).ToString()).ToUpper() + "(s)");
        foreach (Cadastro item in cadastros)
        {
          Console.WriteLine(item.ToString());
        }
      }
    }

    private static string SaveData(Cadastro cadastro)
    {
      try
      {
        using (var context = new CadastroContext())
        {
          context.Add(cadastro);
          context.SaveChanges();
        }
        return "Cadastro inserido.";
      }
      catch (System.Exception)
      {
        return "Erro ao inserir.";
      }
    }

    public static Cadastro? GetData(int ID)
    {
      using (var context = new CadastroContext())
      {
        Cadastro? cadastro = context.Cadastros.SingleOrDefault(c => c.id.Equals(ID));
        if (cadastro == null || cadastro.id != ID)
        {
          Console.WriteLine("Cadastro não encontrado.");
          return null;
        }
        return cadastro;
      }
    }

    public static void ChangeData(int ID, bool excluir)
    {

      Cadastro? newCadastro = GetData(ID);
      if (newCadastro != null)
      {
        bool alterar;

        Console.WriteLine(newCadastro.GetDetails() + Environment.NewLine);

        if (excluir)
        {
          Console.WriteLine("Deseja mesmo excluir este cadastro?");
          alterar = Input.GetBool();
          if (alterar) newCadastro.ativo = false;
        }
        else
        {
          if (newCadastro.ativo == false)
          {
            Console.WriteLine("Deseja reativar o cadastro?");
            alterar = Input.GetBool();
            if (alterar) newCadastro.ativo = true;
          }


          Console.WriteLine("Deseja alterar o gênero?");
          alterar = Input.GetBool();
          if (alterar) newCadastro.genero = MudarGenero();

          Console.WriteLine("Deseja alterar o título?");
          alterar = Input.GetBool();
          if (alterar) newCadastro.titulo = MudarTitulo();

          Console.WriteLine("Deseja alterar o ano?");
          alterar = Input.GetBool();
          if (alterar) newCadastro.ano = MudarAno();

          Console.WriteLine("Deseja alterar o descrição?");
          alterar = Input.GetBool();
          if (alterar) newCadastro.descricao = MudarDescricao();
        }
        try
        {
          using (var context = new CadastroContext())
          {
            context.Update(newCadastro);
            context.SaveChanges();
            Console.WriteLine("Alterações salvas!");
          }
        }
        catch (System.Exception)
        {
          Console.WriteLine("Erro ao salvar alterações");
        }
      }
    }

    private static Genero MudarGenero()
    {
      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        if (i < 10)
          Console.WriteLine(" {0} - {1}", i, ((Genero)i).ToString());
        else
          Console.WriteLine("{0} - {1}", i, ((Genero)i).ToString());
      }

      Console.WriteLine();
      Console.Write("Digite o número de um dos gêneros listados: ");
      int genero = Input.GetInt();
      return (Genero)genero;
    }

    private static string MudarTitulo()
    {
      Console.Write("Digite o título: ");
      string titulo = Input.GetInput();
      return titulo;
    }

    private static int MudarAno()
    {
      Console.Write("Digite o ano de estreia: ");
      int ano = Input.GetInt();
      return ano;
    }

    private static string MudarDescricao()
    {
      Console.Write("Insira uma descrição: ");
      string descricao = Input.GetInput();
      return descricao;
    }


    public override string ToString()
    {
      string retorno = $"[ID #{this.id}] | {this.titulo} ({this.ano})";
      retorno += ativo ? "" : " - (Excluído)";
      return retorno;
    }

    public string GetDetails()
    {
      string retorno = $"{(this.tipo.ToString()).ToUpper()}" + Environment.NewLine + $"Título: {this.titulo}"
      + Environment.NewLine + $"Ano: {this.ano}" + Environment.NewLine + $"Descrição: {this.descricao}"
      + Environment.NewLine + $"Gênero: {this.genero}";
      return retorno;
    }
  }
}