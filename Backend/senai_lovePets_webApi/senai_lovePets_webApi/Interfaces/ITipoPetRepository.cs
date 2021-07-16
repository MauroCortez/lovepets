using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoPetRepository
    {

        List<TipoPet> List();

        TipoPet BuscarPorId(int idTipoPet);

        void Cadastrar(TipoPet tipoPetCadastrado);

        void Atualizar(int idTipoPet, TipoPet tipoPetAtualizado);

        void Deletar(int idTipoPet);
    }
}
