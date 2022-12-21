using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("Digite o nome do primeiro hospede");
p1.Nome = Console.ReadLine();
Console.WriteLine("Digite o nome do segundo hospede");
p2.Nome = Console.ReadLine();

hospedes.Add(p1) ;
hospedes.Add(p2);


// Cria a suíte
Suite suite = new Suite();
Console.WriteLine("Digite qual a capacidade da suite");
suite.Capacidade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite qual o valor da diaria da suite");
suite.ValorDiaria = int.Parse(Console.ReadLine());



//Cria uma nova reserva, passando a suíte e os hospedes
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

 // Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Os Hóspedes são {p1.Nome} e {p2.Nome}");
Console.WriteLine($"Valor total das diarias: {reserva.CalcularValorTotal()}");
