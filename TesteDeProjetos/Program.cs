Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
/*Next()é um método e WriteLine() também
  Random.Next() é acessado de maneira diferente do que se acessa o método Console.WriteLine()
  As forma diferentes de acessar devem-se ao fa cto de alguns métodos serem statefull e outros serem stateless

  */

   //int result = Random.Next();
  /* A linha anterior dá erro de Build indicando que é necessária uma referencia a um objeto para o campo, método ou propriedade não estático (static) Random.Next(). 

  Assim, é sempre necessário primeiro criar um objeto / variável (dice)

  */

