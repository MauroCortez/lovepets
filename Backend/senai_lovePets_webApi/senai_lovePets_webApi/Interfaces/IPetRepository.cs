using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IPetRepository
    {
        List<Pet> Listar();

        Pet BuscarPorId(int idPet);

        void Cadastrar(Pet petCadastrado);

        void Atualizar(int idPet, Pet petAtualizado);

        void Deletar(int idPet);
    }
}
