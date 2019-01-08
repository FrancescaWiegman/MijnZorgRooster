﻿using mijnZorgRooster.Models.Entities;
using System;
using System.Threading.Tasks;

namespace mijnZorgRooster.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ZorginstellingContext _context;
        private IMedewerkerRepository _medewerkerRepository;
       // private IGenericRepository<Medewerker> _medewerkerRepository;

        public UnitOfWork(ZorginstellingContext context)
        {
            _context = context;
        }

        public IMedewerkerRepository MedewerkerRepository
        {
            get { return _medewerkerRepository ?? (_medewerkerRepository = new MedewerkerRepository(_context)); }
        }

        //public IGenericRepository<Medewerker> MedewerkerRepository
        //{
        //    get
        //    {
        //        return _medewerkerRepository ?? (_medewerkerRepository = new  GenericRepository<Medewerker>(_context));
        //    }
        //}

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
