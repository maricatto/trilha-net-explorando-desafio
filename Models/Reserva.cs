namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      if (Suite.Capacidade >= hospedes.Count)
      {
        Hospedes = hospedes;
         Console.WriteLine($"Os hóspedes pertencentes a esta suíte são:");
        foreach (var hospede in Hospedes)
        {
            Console.WriteLine(hospede.NomeCompleto);
        }
      }
      else
      {
        throw new Exception("A capacidade do local é insuficiente para acomodar todos os hóspedes.");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      if (Hospedes != null)
      {
        return Hospedes.Count;
      }
      else
      {
        return 0;
      }
    }


    public decimal CalcularValorDiaria()
    {
      decimal valor = DiasReservados * Suite.ValorDiaria;

      // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
      if (DiasReservados >= 10)
      {
        valor -= valor * 0.1m; // Aplica o desconto de 10%
      }

      return valor;
    }
  }
}
