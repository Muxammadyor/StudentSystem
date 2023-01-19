﻿using System.Linq.Expressions;

namespace Yakuniy.Infrastract.EntityTypeConfigurations;

public interface IGenericRepasitory<TEntity, TKey>
{
    ValueTask<TEntity> InsertAsync(TEntity entity);
    IQueryable<TEntity> SelectAll();
    ValueTask<TEntity> SelectByIdAsync(TKey id);

    ValueTask<TEntity> SelectByIdWithDetailsAsync(
        Expression<Func<TEntity, bool>> expression,
        string[] includes);

    ValueTask<TEntity> UpdateAsync(TEntity entity);
    ValueTask<TEntity> DeleteAsync(TEntity entity);
    ValueTask<int> SaveChangesAsync();
}
