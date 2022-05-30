using FlixPrime.Classes;

Console.Clear();

while (true)
{
  Menu.MenuInicial();
  string opcao = Input.GetOption();

  switch (opcao.ToUpper())
  {
    case "C":
      Console.Clear();
      break;
    case "X":
      Input.EncerrarAplicacao();
      break;
    case "1":
      Menu.AbrirMenu(1);
      break;
    case "2":
      Menu.AbrirMenu(2);
      break;
    case "3":
      Menu.AbrirMenu(3);
      break;
    case "4":
      Menu.AbrirMenu(4);
      break;
    default:
      Console.WriteLine();
      Console.WriteLine("OPÇÃO INVÁLIDA");
      break;
  }
}


