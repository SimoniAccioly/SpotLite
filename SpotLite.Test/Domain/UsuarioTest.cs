﻿using SpotLite.Domain.Conta.Agreggates;
using SpotLite.Domain.Financeiro.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Test.Domain
{
    public class UsuarioTest
    {
        [Fact]
        public void DeveCriarUsuarioComSucesso()
        {
            Plano plano = new Plano()
            {
                Descricao = "Lorem ipsum",
                Id = Guid.NewGuid(),
                Nome = "Plano Dummy",
                Valor = 19.90M
            };

            Cartao cartao = new Cartao()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite = 1000M,
                Numero = "6465465466",
            };

            string nome = "Dummy Usuario";
            string email = "teste@teste.com";
            string cpf = "000.000.000-000";
            string senha = "123456";

            //Act
            Usuario usuario = new Usuario();
            usuario.CriarConta(nome, email, senha, cpf, DateTime.Now, plano, cartao);

            //Assert
            Assert.NotNull(usuario.Email);
            Assert.NotNull(usuario.Nome);
            Assert.True(usuario.Email == email);
            Assert.True(usuario.Nome == nome);
            Assert.True(usuario.CPF == cpf);
            Assert.True(usuario.Senha != senha);

            Assert.True(usuario.Assinaturas.Count > 0);
            Assert.Same(usuario.Assinaturas[0].Plano, plano);

            Assert.True(usuario.Cartoes.Count > 0);
            Assert.Same(usuario.Cartoes[0], cartao);

            Assert.True(usuario.PlayLists.Count > 0);
            Assert.True(usuario.PlayLists[0].Nome == "Favoritas");
            Assert.False(usuario.PlayLists[0].Publica);
        }

        [Fact]
        public void NaoDeveCriarUsuarioComCartaoSemLimite()
        {
            Plano plano = new Plano()
            {
                Descricao = "Lorem ipsum",
                Id = Guid.NewGuid(),
                Nome = "Plano Dummy",
                Valor = 19.90M
            };

            Cartao cartao = new Cartao()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Limite = 10M,
                Numero = "6465465466",
            };

            string nome = "Dummy Usuario";
            string email = "teste@teste.com";
            string cpf = "000.000.000-000";
            string senha = "123456";

            //Act
            Assert.Throws<Exception>(() =>
            {
                Usuario usuario = new Usuario();
                usuario.CriarConta(nome, email, senha, cpf,DateTime.Now, plano, cartao);
            });
        }

        [Fact]
        public void DeveAdicionarPlaylistCorretamente()
        {
            // Arrange
            var usuario = new Usuario();

            // Act
            usuario.CriarPlaylist("MinhaPlaylist", true);

            // Assert
            Assert.Single(usuario.PlayLists);
            Assert.Equal("MinhaPlaylist", usuario.PlayLists.First().Nome);
            Assert.True(usuario.PlayLists.First().Publica);
        }
    }
}
