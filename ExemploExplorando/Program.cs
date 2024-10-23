using ExemploExplorando.Models;
using System.Globalization;


try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}






















// string dataString = "2022-04-170 18:00"; 

// bool sucesso = DateTime.TryParseExact(dataString,
//                          "yyyy-MM-dd HH:mm",
//                           CultureInfo.InvariantCulture,
//                           DateTimeStyles.None, out DateTime data);


// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }






























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));















// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado); 






















//  Pessoa p1 = new Pessoa(nome: "Renan", sobrenome: "Soares");
//  Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");
 
//  Curso cursoDeiIgles = new Curso();
//  cursoDeiIgles.Nome = "Ingles";
//  cursoDeiIgles.Alunos = new List<Pessoa>();

//  cursoDeiIgles.AdicionarAluno(p1);
//  cursoDeiIgles.AdicionarAluno(p2);
//  cursoDeiIgles.ListarAlunos();






















// Pessoa p1 = new Pessoa();
// p1.Nome = "Renan";
// p1.Sobrenome = "Soares";
// p1.Idade = 34;
// p1.Apresentar();
