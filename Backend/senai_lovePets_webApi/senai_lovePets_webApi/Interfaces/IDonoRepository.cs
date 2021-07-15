using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IDonoRepository
    {
        List<Dono> List();

        Dono BuscarPorId(int idDono);

        void Cadastrar(Dono donoCadastrado);

        void Atualizar(int idDono, Dono donoAtualizado);

        void Deletar(int idDono);
    }
}
