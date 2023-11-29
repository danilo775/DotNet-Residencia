namespace GerenciamentoConsultorio
{
    static class Relatorios
    {
        public static List<Medico> MedicosComIdadeEntre(List<Medico> medicos, int idadeMinima, int idadeMaxima)
        {
            return medicos.Where(medico =>
                CalculaIdade(medico.DataNascimento) >= idadeMinima &&
                CalculaIdade(medico.DataNascimento) <= idadeMaxima).ToList();
        }

   

        private static int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Today.Year - dataNascimento.Year;
            if (dataNascimento.Date > DateTime.Today.AddYears(-idade))
                idade--;
            return idade;
        }

        public static List<Paciente> PacientesComIdadeEntre(List<Paciente> pacientes, int idadeMinima, int idadeMaxima)
        {
            return pacientes.Where(paciente =>
                CalculaIdade(paciente.DataNascimento) >= idadeMinima &&
                CalculaIdade(paciente.DataNascimento) <= idadeMaxima).ToList();
        }

        public static List<Paciente> PacientesPorSexo(List<Paciente> pacientes, string sexo)
        {
            return pacientes.Where(paciente => paciente.Sexo.Equals(sexo)).ToList();
        }

        public static List<Paciente> PacientesEmOrdemAlfabetica(List<Paciente> pacientes)
        {
            return pacientes.OrderBy(paciente => paciente.Nome).ToList();
        }

        public static List<Paciente> PacientesPorSintoma(List<Paciente> pacientes, string sintoma)
        {
            return pacientes.Where(paciente => paciente.Sintomas.Contains(sintoma)).ToList();
        }

        public static List<Pessoa> AniversariantesDoMes(List<Medico> medicos, List<Paciente> pacientes, int mes)
        {
            return medicos.Cast<Pessoa>().Concat(pacientes.Cast<Pessoa>())
                .Where(pessoa => pessoa.DataNascimento.Month == mes).ToList();
        }
    }
}