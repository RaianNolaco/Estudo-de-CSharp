// See https://aka.ms/new-console-template for more information


using Estudo.CursoUdemy.Secao13.ExemploAula.HashCodeEquals;
using Estudo.CursoUdemy.Secao13.ExemploAula.IntroGenerics;
using Estudo.CursoUdemy.Secao13.ExemploAula.RestricoesGenerics;

//IntroGenericsParte1.executar();
//RestricoesGenerics.executar();
HashCodeEquals.executar();

var a = (1,2) switch
{
    (1,2) => 1
};