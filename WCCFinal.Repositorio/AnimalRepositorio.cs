using System;
using System.Collections.Generic;
using System.Text;
using WCCFinal.Dominio.Modelo;

namespace WCCFinal.Repositorio
{
    public class AnimalRepositorio
    {
        public  List<Animal> SelecionarTodosAnimais()
        {
            var dt = new Conexao().Consulta("select * from Animal");

            List<Animal> lst = new List<Animal>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Animal a = new Animal
                {
                    DataNasc = Convert.ToDateTime(dt.Rows[i]["DATANASC"].ToString()),
                    Femea = Convert.ToBoolean(dt.Rows[i]["FEMEA"]),
                    Id = Convert.ToInt32(dt.Rows[i]["ID"]),
                    Nome = dt.Rows[i]["NOME"].ToString(),
                    Porte = dt.Rows[i]["PORTE"].ToString(),
                    Raca = dt.Rows[i]["RACA"].ToString()
                };
                a.MeuTipoAnimal.Id = Convert.ToInt32(dt.Rows[i]["IDTIPOANIMAL"]);

                lst.Add(a);

            }

            return lst;
        }
        public void IncluirAnimal(Animal animal)
        {
            new Conexao().Executar(
                "INSERT INTO ANIMAL" +
                "(Nome, Raca, IdTipoAnimal, Porte," +
                "DataNasc, Femea) VALUES" +
                $"('{animal.Nome}'," +
                $"{animal.Raca}," +
                $"2," +
                $"{animal.Porte}," +
                $"{animal.DataNasc.ToString("yyyyMMdd")}," +
                $"{(animal.Femea ? "1" : "0")})");
        }
    }

}
