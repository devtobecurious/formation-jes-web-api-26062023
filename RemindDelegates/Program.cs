using RemindDelegates;

Afficher afficher = Console.WriteLine;

afficher("Hello");
afficher?.Invoke("Coucou");

afficher = mess =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mess);
    Console.ForegroundColor = ConsoleColor.White;
};
afficher("Ah que johny");

afficher = mess => Console.WriteLine(mess);
afficher("Oh yeah");