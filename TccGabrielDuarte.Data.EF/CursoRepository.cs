﻿using TccGabrielDuarte.Model;

namespace TccGabrielDuarte.Data.EF
{
    public class CursoRepository : EntityBaseRepository<Curso>, ICursoRepository
    {
        public CursoRepository(TccContext context) : base(context) { }
    }
}
