namespace GerenciamentoConsultorio
{
    class Consultorio
    {
        private List<Medico> medicos;
        private List<Paciente> pacientes;

        public Consultorio()
        {
            medicos = new List<Medico>();
            pacientes = new List<Paciente>();
        }

        public void AdicionarMedico(Medico medico)
        {
            if (!medicos.Exists(m => m.CPF == medico.CPF || m.CRM == medico.CRM))
            {
                medicos.Add(medico);
                Console.WriteLine("Médico adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("CPF ou CRM já existente!");
            }
        }

        public void AdicionarPaciente(Paciente paciente)
        {
            if (!pacientes.Exists(p => p.CPF == paciente.CPF))
            {
                pacientes.Add(paciente);
                Console.WriteLine("Paciente adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("CPF já existente!");
            }
        }

        
    }
}