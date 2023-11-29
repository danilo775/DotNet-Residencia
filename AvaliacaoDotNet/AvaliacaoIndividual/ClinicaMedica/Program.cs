namespace GerenciamentoConsultorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
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

            List<Medico> medicosComIdadeEntre = Relatorios.MedicosComIdadeEntre(medicos, 30, 50);
            Console.WriteLine("Médicos com idade entre 30 e 50 anos:");
            foreach (var medico in medicosComIdadeEntre)
            {
                Console.WriteLine(medico.Nome);
            }

            Console.WriteLine();

            List<Paciente> pacientesComIdadeEntre = Relatorios.PacientesComIdadeEntre(pacientes, 20, 30);
            Console.WriteLine("Pacientes com idade entre 20 e 30 anos:");
            foreach (var paciente in pacientesComIdadeEntre)
            {
                Console.WriteLine(paciente.Nome);
            }

            Console.WriteLine();

            List<Paciente> pacientesPorSexo = Relatorios.PacientesPorSexo(pacientes, "Feminino");
            Console.WriteLine("Pacientes do sexo feminino:");
            foreach (var paciente in pacientesPorSexo)
            {
                Console.WriteLine(paciente.Nome);
            }

            Console.WriteLine();

            List<Paciente> pacientesEmOrdemAlfabetica = Relatorios.PacientesEmOrdemAlfabetica(pacientes);
            Console.WriteLine("Pacientes em ordem alfabética:");
            foreach (var paciente in pacientesEmOrdemAlfabetica)
            {
                Console.WriteLine(paciente.Nome);
            }

            Console.WriteLine();

            List<Paciente> pacientesPorSintoma = Relatorios.PacientesPorSintoma(pacientes, "Dor");
            Console.WriteLine("Pacientes com sintoma de dor:");
            foreach (var paciente in pacientesPorSintoma)
            {
                Console.WriteLine(paciente.Nome);
            }
        }
    }
}