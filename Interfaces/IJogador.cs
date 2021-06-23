using System.Collections.Generic;
using Eplayers_MVC.Models;

namespace Eplayers_MVC.Interfaces
{
    public interface IJogador
    {
         void Criar(Jogador j);
         List<Jogador> LerTodos();
         void Alterar(Jogador j);
         void Deletar(int id);
    }
}