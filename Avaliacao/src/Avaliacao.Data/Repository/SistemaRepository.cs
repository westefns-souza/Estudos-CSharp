using Business.Interfaces;
using Business.Models;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class SistemaRepository : Repository<Sistema>, ISistemaRepository
    {
        public SistemaRepository(MeuDbContext context) : base(context) { }



    }
}
