using System.Text;
using DesafioProjetoHospedagem.Models;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome:"Sobrenome Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome:"Sobrenome Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome:"Sobrenome Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4", sobrenome:"Sobrenome Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5", sobrenome:"Sobrenome Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6", sobrenome:"Sobrenome Hóspede 6");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);
hospedes.Add(p6);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 7, valorDiaria: 50);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 7);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"A quantidade de hóspedes nesta suite são: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
