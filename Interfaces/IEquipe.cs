using System.Collections.Generic;
using Eplayers_MVC.Models;

namespace Eplayers_MVC.Interfaces
{
    public interface IEquipe
    {
         void Criar(Equipe e);
         List<Equipe> LerTodas();
         void Alterar(Equipe e);
         void Deletar(int Id);
    }
}