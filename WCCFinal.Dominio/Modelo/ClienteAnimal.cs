using System;
using System.Collections.Generic;
using System.Text;

namespace WCCFinal.Dominio.Modelo
{
    public class ClienteAnimal
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int IdAnimal { get; set; }
        public Animal Animal { get; set; }

    }
}
