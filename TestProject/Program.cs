
//Uso do método Random.Next() para simular o lançamento de um dado
Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);

/*int result = Random.Next();
Console.WriteLine(result);
Dá erro pois tem de ser criado um ojeto para aceder ao método Random.Next()*/
Random resultado = new Random();
int numero = resultado.Next();
Console.WriteLine($"\n{numero}");
