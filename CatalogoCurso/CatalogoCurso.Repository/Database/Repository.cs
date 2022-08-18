﻿using CatalogoCurso.CrossCutting.Repository;
using CatalogoCurso.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> Query { get; set; }
        public DbContext Context { get; set; }

        public Repository(CatalogoCursoContext context)
        {
            Context = context;
            Query = Context.Set<T>();
        }

        public async Task Desativar(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<T> ObterPorId(object id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await this.Query
                             .AsNoTrackingWithIdentityResolution()
                             .ToListAsync();
        }

        public async Task Salvar(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Atualizar(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();

        }
    }
}
