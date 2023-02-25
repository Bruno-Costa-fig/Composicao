using Composicao.Classes;

Endereco endereco = new Endereco()
{
    Logradouro = "Nome da rua",
    Bairro = "Seu bairro",
    Numero = "21",
    Cidade = "Sua cidade",
    CEP = "99000000",
    Estado = "CE",
    Pais = "Brasil"
};

// Upcasting
//Pessoa aluno = new Aluno("Bruno Costa", DateTime.Parse("1999-01-25"), endereco, "ADS", 1);
//Console.ReadLine(aluno.Curso);


//// Downcasting
//Pessoa pessoa = new Aluno("Bruno Costa", DateTime.Parse("1999-01-25"), endereco, "ADS", 1);
//Console.WriteLine(aluno.Curso);
//// Aqui da erro pois o objeto é do tipo Pessoa
//Aluno aluno = (Aluno)pessoa;
//// Converte de Pessoa para Aluno

//Console.WriteLine(aluno.Curso);
//// Agora por ser do tipo Aluno vai exibir 'ADS'

