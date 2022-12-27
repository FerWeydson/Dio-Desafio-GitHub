using Bootcamp_Pottencial_.NET_Developer.Models;

string opcao;
bool exibirMenu = true;

while(exibirMenu){
    
    Console.Clear();
    System.Console.WriteLine("Digite uma opção: ");
    System.Console.WriteLine("1 - Cadastrar");
    System.Console.WriteLine("2 - Buscar");
    System.Console.WriteLine("3 - Excluir");
    System.Console.WriteLine("4 - Encerrar");
    
     opcao = Console.ReadLine();

     switch(opcao){
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de clientes");
        break;
    
        case "3":
            Console.WriteLine("Excluir cliente");
        break;

        case "4":
            Console.WriteLine("Encerrar programa");
            exibirMenu = false;
            //Environment.Exit(0);
            
        break;

        default:
            System.Console.WriteLine("Opção inválida");
            break;
     }
}








// Laços de repetição

// int soma = 0 , numero= 0;

// do {
//     System.Console.WriteLine("Digite um número. (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());    
//     soma += numero;

// }while(numero != 0);

// System.Console.WriteLine($"Total da soma dos numeros é: {soma}");



//cuidado com loop infinito

// int numero = 5;
// int b = 1;
// while(b <= 10){
//     System.Console.WriteLine($"{numero} x {b} = {numero * b }");
//     b++;
//     // interromper fluxo de execução
//     if (b == 5) {
//         break;
//     }
// }






// int numero = 5;
// for(int b = 0; b <= 10; b++){
//     System.Console.WriteLine($"{numero} x {b} = {numero * b }");
// }




// Classe operadores matemáticos

// Calculadora operacaoMatematica = new Calculadora();
// operacaoMatematica.Somar(15, 5);
// operacaoMatematica.Subtrair(15, 5);
// operacaoMatematica.Dividir(15, 5);
// operacaoMatematica.Multiplicar(15, 5);
// operacaoMatematica.Potencia(2, 2);
// operacaoMatematica.Coseno(30);
// operacaoMatematica.Seno(30);
// operacaoMatematica.Tangente(30);
// operacaoMatematica.RaizQuadrada(9);



// Operadores condicionais e lógicos


// bool presencaMinima = false;
// double media = 7.5;

// if(presencaMinima && media >= 7) {
//     System.Console.WriteLine("Aluno aprovado");
// }else {
//     System.Console.WriteLine("Aluno reprovado");
// }



// bool maiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if(maiorDeIdade || possuiAutorizacaoDoResponsavel) {
//     System.Console.WriteLine("Entrada liberada.");
// }else {
//     System.Console.WriteLine("Entrada negada.");
// }




// int quantidadeEmEstoque = 40;
// int quantidadeCompra = 5;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// System.Console.WriteLine($"É possível realizar venda? {possivelVenda}");

// if(quantidadeCompra == 0) {
//     System.Console.WriteLine("Venda inválida");
//     }else if (possivelVenda) {
//     System.Console.WriteLine("Venda realizada");
//     }else {
//     System.Console.WriteLine("Desculpe, quantidade insuficiente no estoque.");
//     }




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