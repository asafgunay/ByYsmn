using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ByYsmn.Application.Shared
{
    public interface IBaseService<TPKey, TCreateInput, TUpdateInput, TModel>
    {
        Task<List<TModel>> GetAll();
        Task<List<TModel>> GetAllByUserId(Guid userId);
        Task<List<TModel>> GetAllByKeyWord(string input);
        Task<TModel> Get(EntityInput<TPKey> input);
        Task<TModel> Create(TCreateInput input);
        Task<TModel> Update(TUpdateInput input);
        Task<bool> Delete(EntityInput<TPKey> input);
    }
}
