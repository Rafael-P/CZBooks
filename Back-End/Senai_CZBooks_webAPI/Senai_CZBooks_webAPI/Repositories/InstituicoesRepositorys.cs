using Senai_CZBooks_webAPI.Contexts;
using Senai_CZBooks_webAPI.Domains;
using Senai_CZBooks_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Repositories
{
    public class InstituicoesRepositorys : IInstituicoesRepository
    {
        CZBooksContext ctx = new CZBooksContext();

        public void Atualizar(int id, Instituico instituicaoAtualizada)
        {
            Instituico instituicaoBuscada = ctx.Instituicoes.Find(id);

            if (instituicaoAtualizada.NomeInstituicao != null)
            {
                instituicaoBuscada.NomeInstituicao = instituicaoAtualizada.NomeInstituicao;
            }

            if (instituicaoAtualizada.Endereco != null)
            {
                instituicaoBuscada.Endereco = instituicaoAtualizada.Endereco;
            }

            if (instituicaoAtualizada.Telefone != null)
            {
                instituicaoBuscada.Telefone = instituicaoAtualizada.Telefone;
            }

            ctx.Instituicoes.Update(instituicaoBuscada);

            ctx.SaveChanges();
        }

        public Instituico BuscarPorId(int id)
        {
            return ctx.Instituicoes.FirstOrDefault(a => a.IdInstituicao == id);
        }

        public void Cadastrar(Instituico novaInstituicao)
        {
            ctx.Instituicoes.Add(novaInstituicao);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Instituicoes.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Instituico> Listar()
        {
            return ctx.Instituicoes.ToList();
        }
    }
}
