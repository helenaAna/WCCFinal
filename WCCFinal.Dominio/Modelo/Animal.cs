using System;
using System.Collections.Generic;
using System.Text;

namespace WCCFinal.Dominio.Modelo
{
    public class Animal
    {
        public Animal()
        {
            MeuTipoAnimal = new TipoAnimal();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public TipoAnimal MeuTipoAnimal { get; set; }
        public string Porte { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Femea { get; set; }
    }
}
