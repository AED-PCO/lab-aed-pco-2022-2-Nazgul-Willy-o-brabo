// See https://aka.ms/new-console-template for more information
Console.WriteLine("selecione a atividade");
int op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        atv01();
        break;
          case 2:
            atv02();
        break;
        case 3:
        atv03();
        break;
        case 4:
        atv04();
        break;
}
