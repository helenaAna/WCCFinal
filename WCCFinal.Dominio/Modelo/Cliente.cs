using System;
using System.Collections.Generic;
using System.Text;

namespace WCCFinal.Dominio.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DaataNasc { get; set; }
        public string Telefone { get; set; }
        public string DocIdentificador { get; set; }

    }
}
