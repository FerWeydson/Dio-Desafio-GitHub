using Propriedades__métodos_e_contrutores_C_.Models;


// Coleções

// Dictionary - chave-valor armazenados sem ordem especifica

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PE", "Pernambuco");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");

foreach(var item in estados){
    System.Console.WriteLine(item);
}
System.Console.WriteLine($"Removendo item {estados.Remove("PE")}");

foreach(var item in estados){
    System.Console.WriteLine(item);
}




// Pilha - ultimo a entrar, primeiro a sair - LIFO

// Stack<int> pilha = new Stack<int>();
// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach(int item in pilha){
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine($"removendo da pilha {pilha.Pop()}");

// foreach(int item in pilha){
//     System.Console.WriteLine(item);
// }




//  Queue -  primeiro a entrar, primeiro a sair - FIFO


// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila){
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");

// foreach(int item in fila){
//     System.Console.WriteLine(item);
// }




// new ExemploExcecao().Metodo1();

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/Leitura.txt");

//     foreach(string linha in linhas){
//         System.Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     System.Console.WriteLine($"Deu merda na leitura. O arquivo não foi encontrado. {ex.Message}");
// }catch (DirectoryNotFoundException ex)
// {
//     System.Console.WriteLine($"Deu merda na busca do arquivo. Caminho não encontrado. {ex.Message}");
// }catch (Exception ex)
// {
//     System.Console.WriteLine($"Algum erro generico ocorreu. {ex.Message}");

// }



// usando construtor
// Pessoa p1 = new Pessoa(name: "Weslley Henrique", age: 25);


// Pessoa p2 = new Pessoa();
// p2.Name = "Weydson fernandes";
// p2.Age = 23;

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Name = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

