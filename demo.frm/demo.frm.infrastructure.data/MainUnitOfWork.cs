using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain;
using demo.frm.domain.Entities;
//using demo.frm.infrastructure.data.EntityTypeConfigurations;

namespace demo.frm.infrastructure.data
{
    public class MainUnitOfWork : DbContext, IQueryableUnitOfWork
    {
        //public MainUnitOfWork()
        //    : base("MainUnitOfWork")
        //{
        //    Configuration.LazyLoadingEnabled = false;
        //}

        #region IDbSet Members

        //IDbSet<Tecnologia> _tecnologias;
        //public IDbSet<Tecnologia> Tecnologias
        //{
        //    get
        //    {
        //        if (_tecnologias == null)
        //            _tecnologias = base.Set<Tecnologia>();

        //        return _tecnologias;
        //    }
        //}

        #endregion

        #region IQueryableUnitOfWork Members

        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public int Commit()
        {
            return base.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();

                    saveFailed = false;

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.ToList()
                              .ForEach(entry =>
                              {
                                  entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                              });

                }
            } while (saveFailed);
        }

        public void RollbackChanges()
        {
            base.ChangeTracker.Entries()
                              .ToList()
                              .ForEach(entry => entry.State = System.Data.Entity.EntityState.Unchanged);
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        #endregion

        #region DbContext Overrides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(50));

            //modelBuilder.Configurations.Add(new TecnologiaTypeConfiguration());
        }

        #endregion
    }
}
