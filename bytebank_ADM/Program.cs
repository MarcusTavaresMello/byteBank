using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.Net.Http.Headers;

#region
//Funcionario pedro = new Funcionario("321654987", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("321654987");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo Salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo Salário do Roberta: " + roberta.Salario);
#endregion


//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456654");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("321654987");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("654987215");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("654987978");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("12365479");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("454654654");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    Console.WriteLine("Tentativa de login da Ingrid:");
    sistema.Logar(ingrid, "123");

    Console.WriteLine("Tentativa de login da Ursula:");
    sistema.Logar(ursula, "963");

    Console.WriteLine("Tentativa de login da Caio:");
    sistema.Logar(caio, "999");


}