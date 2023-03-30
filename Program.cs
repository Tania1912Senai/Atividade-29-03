//Programa para calcular a idade de uma pessoa em meses, dias, horas e minutos

//Entrada de dados

//Console.WriteLine ("digite nome:");
//string nome = Console.ReadLine();
//Console.WriteLine ("digite idade:");
//int idade = int.Parse(Console.ReadLine());
//int meses = idade * 12;
//int dias = idade * 365;
//int horas = dias * 24;
//int minutos = horas * 60;
//Console.WriteLine ($"sua idade corresponde a: {idade} anos, ou {meses} meses, ou {dias} dias, ou {horas} horas, ou {minutos} minutos!");


//observacao da explicacao do professor na sala de aula 30.03.2023
//int anoNascimento;
//int idade;
//int idadeemSemanas;
//int anoAtual = DateTime.Now.Year;
//Console.Write($"informe o ano do nascimento");
//anoNascimento = int.Parse(Console.ReadLine());
//idade = (anoAtual - anoNascimento);
//idadeemSemanas = (idade* 52);
//Console.WriteLine($ "A idade em anos e (idade) em ano(s) e a idade em semanas e idadeEmSemanas e (idadeEmSemanas) semanas");


//Atividade para entregar
//Entrada de dados
//Console.WriteLine ("digite Aluno");
//string aluno = Console.ReadLine();

//Console.WriteLine($"digite o valor da nota 1");
//float n1 = float.Parse(Console.ReadLine());
//Console.WriteLine($"digite o valor da nota 2");
//float n2 = float.Parse(Console.ReadLine());
//Console.WriteLine($"digite o valor da nota 3");
//float n3 = float.Parse(Console.ReadLine());
//Console.WriteLine($"digite o valor da nota 4");
//float n4 = float.Parse(Console.ReadLine());
//Console.WriteLine($"digite o valor da nota 5");
//float n5 = float.Parse(Console.ReadLine());
//Processamento
//float media = (n1 + n2 + n3 + n4 + n5)/5

//aula 30.03.2023
//variavel condicional

//estrutura condicional simples

//boll sol =true;
//{
//    Console.WriteLine($"Vou para a praia");
//}
//if() {(" Condicional")
//Condicional composta


//bool sol = true;
//bool folga = false;


//if(sol && folga){
//    Console.WriteLine($"Vou para praia");
//}

// Explicacao de valor ternario
//Condicao verdade ? senao: false

//int x = 2;
//int y = 3;
//if (x ==y)
//Console.WriteLine($"Sao iguais");
//else
//Console.WriteLine($"Sao diferentes");
//string eIgual = (x ==y) ? "sao iguais" : "Sao diferentes";
//Console.WriteLine(eigual);

//condicional encadeada

//maior ou igual a 18 : pode entrar na festa
//maior de 16 menor de 18 : pode entrar na festa com responsavel
//menor do que 16 : nao pode entrar

//int idade = 18;
//if (idade >= 18)
//{
//    Console.WriteLine($"Pode entrar na festa");
//}
//else if (idade > 16 && idade < 18)
//{
//    Console.WriteLine($"pode entrar na festa com responsavel");
//}
//else
//{ Console.WriteLine($"Nao pode entrar"); }

//Atividades Classroom com 6 exercicios

//Exercicio 1

//Console.WriteLine($"Digite seu salario");
//float salario = float.Parse(Console.ReadLine());

//Console.WriteLine($"digite despesas");
//float despesas = float.Parse(Console.ReadLine());

//float saldo = (salario - despesas);
//Console.WriteLine($" esse e o saldo disponivel {saldo}");
//Resposta a despesa esta compativel com orcamento

//Exercicio 2

//Placar de Futebol
Console.WriteLine($"digite gols do time A");
float golTimeA = float.Parse(Console.ReadLine());

Console.WriteLine($"digite gols do timeB");
float  golTimeB = float.Parse(Console.ReadLine());


if (golTimeA > golTimeB) 
{
    Console.WriteLine($"venceu time A");
}
 else if(golTimeB > golTimeA) 
{
    Console.WriteLine($"venceu time B");
} else {
    Console.WriteLine($"Empate");
}


























