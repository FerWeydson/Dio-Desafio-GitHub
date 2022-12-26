using Bootcamp_Pottencial_dotNET_Developer.Models;



// Operadores condicionais

int quantidadeEmEstoque = 40;
int quantidadeCompra = 5;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
System.Console.WriteLine($"É possível realizar venda? {possivelVenda}");

if(quantidadeCompra == 0) {
    System.Console.WriteLine("Venda inválida");
    }else if (possivelVenda) {
    System.Console.WriteLine("Venda realizada");
    }else {
    System.Console.WriteLine("Desculpe, quantidade insuficiente no estoque.");
    }





// Convertendo de maneira segura

// string a = "15-";
// int b = 0;
// int.TryParse(a, out b);

// Console.WriteLine(a);


// // Ordem dos operadores
// double a = 4 / 2 + 2;

// Console.WriteLine(a);


//converter variáveis

//cast ou casting

// Parse não aceita valores nulos, ja o convert, retorna o valor 0.
// int a = Convert.ToInt32("null");
// int a = int.Parse(null);
// int inteiro = 5;
// string a = inteiro.ToString();
//Console.WriteLine(a);

//casting implicito
// int a = 5;
// double b = a;
// // Console.WriteLine();













// // operadores 
// int a = 20;
// int b = 30;
// int c = a + b;

// //c = c + 5;
// c += 5;

// Console.WriteLine(c);


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Name = "weydson";
// pessoa1.Sobrenome = "Fernandes";
// pessoa1.Age = 23;
// pessoa1.apresentar();