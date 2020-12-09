using NUnit.Framework;
using AulaCoreDesktop.Data;
using AulaCoreDesktop.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaCoreDesktop.TesteUnidade
{
    public class Tests
    {
        RepositoryCliente _repository;

        [SetUp]
        public void Setup()
        {
            _repository = new RepositoryCliente();
        }

        
        public void Incluir()
        {
            Cliente oCliente = new Cliente();
            oCliente.CliNome = "Teste Aula";
            oCliente.CliEmail = "Teste@gmail.com";
            oCliente.CliCpf = "11111155566";
            oCliente = _repository.Incluir(oCliente);
            Assert.Pass(oCliente.CliId.ToString());
        }


        
        public void IncluirFalhar()
        {
            Cliente oCliente = new Cliente();
            oCliente.CliId = 1;
            oCliente.CliNome = "Teste Aula 2";
            try
            {
                oCliente = _repository.Incluir(oCliente);
                Assert.Fail(oCliente.CliId.ToString());
            }
            catch(Exception ex)
            {
                Assert.Pass(ex.Message + "-" + ex.InnerException.Message);
            }           
        }

        [Test]
        public void AlterarCliente()
        {
            List<Cliente> TodosClientes = _repository.SelecionarTodos();
            Cliente oCliente = TodosClientes.First();
            string nome = oCliente.CliNome;
            string nomeAlteracao = nome + " Alterado";
            oCliente.CliNome = nomeAlteracao;
            try
            {
                _repository.Alterar(oCliente); 
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message + "-" + ex.InnerException.Message);
            }

            Assert.Pass();
        }
    }
}