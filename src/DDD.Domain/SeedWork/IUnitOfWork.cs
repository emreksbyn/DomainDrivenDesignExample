﻿namespace DDD.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}