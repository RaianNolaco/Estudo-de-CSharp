using Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_02
{
    public static class MainExemploDois
    {

        public static void Executar()
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2022 13:05:44"),
                "Traveling to new zeland",
                "i'm goig to visit this wonderful country!",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2022 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
            );

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }

    }
}
