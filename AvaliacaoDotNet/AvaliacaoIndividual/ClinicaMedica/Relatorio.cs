using System;
using System.Collections.Generic;
using System.Linq;

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

    
    }
}