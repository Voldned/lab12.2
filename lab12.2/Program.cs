using lab12._2;

TTallyList list = new TTallyList();
/*list.Fill(Console.ReadLine());
list.Print();
list.Delete(Console.ReadLine());
list.Print();*/
string cmd = "a";
while (cmd != "")
{
    Console.WriteLine("Введите 1/2/3 для добавления/удаления/просмотра");
    Console.WriteLine("ДЛЯ ЗАВЕРШЕНИЯ ВВОДА НАЖМИТЕ ENTER");
    cmd = Console.ReadLine();
    Console.WriteLine();
    switch (cmd.Trim())
    {
        case "1":
            Console.WriteLine("Введите название добавляемого товара: ");
            list.Fill(Console.ReadLine());
            Console.Clear();
            break;       
        case "2":          
            Console.WriteLine("Введите название удаляемого товара: ");
            list.Delete(Console.ReadLine());
            Console.Clear();
            break;
        case "3": 
            list.Print();
            break;
        case "":
            break;
        default:
            Console.WriteLine("Несуществующая команда!");
            break;
    }
}