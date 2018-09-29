using Jeffao_Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeffao_Web.Data
{
    public class PerguntasContext:DbContext
    {


        public PerguntasContext(DbContextOptions<PerguntasContext> options):base(options)
        {

        }

        //Incluíndo a Model no EF
        public DbSet<Pergunta> Perguntas { get; set;  }
    }
}
