namespace GerenciamentoConsultorio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Medico> medicos = new List<Medico>
            {
                new Medico { Nome = "João", DataNascimento = new DateTime(1980, 5, 10), CPF = "12345678901", CRM = "12345" },
                new Medico { Nome = "Maria", DataNascimento = new DateTime(1975, 8, 20), CPF = "23456789012", CRM = "23456" },
                new Medico { Nome = "Pedro", DataNascimento = new DateTime(1992, 2, 15), CPF = "34567890123", CRM = "34567" }
            };

            List<Paciente> pacientes = new List<Paciente>
            {
                new Paciente { Nome = "Ana", DataNascimento = new DateTime(1990, 3, 20), CPF = "45678901234", Sexo = "Feminino", Sintomas = "Dor de cabeça" },
                new Paciente { Nome = "Carlos", DataNascimento = new DateTime(1985, 10, 25), CPF = "56789012345", Sexo = "Masculino", Sintomas = "Febre" },
                new Paciente { Nome = "Mariana", DataNascimento = new DateTime(1998, 7, 12), CPF = "67890123456", Sexo = "Feminino", Sintomas = "Dor de garganta" }
            };

        }
    }
}