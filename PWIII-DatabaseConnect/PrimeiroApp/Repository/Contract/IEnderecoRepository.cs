using PrimeiroApp.Models;

namespace PrimeiroApp.Repository.Contract
{
    public interface IEnderecoRepository
    {
        //CRUD
        void Cadastrar(Endereco endereco);
        void Atualizar (Endereco endereco);

        void Excluir(int Id);

        Endereco ObterEndereco(int Id);

        IEnumerable<Endereco> ObterTodosEnderecos();

    }
}
