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
    }
}