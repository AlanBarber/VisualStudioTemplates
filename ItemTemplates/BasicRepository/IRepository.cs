using System.Collections.Generic;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    /// <summary>
    /// Standard Repository for $modelname$
    /// Supports basic CRUD operations
    /// </summary>
    public interface I$modelname$Repository
    {
        Task<ICollection<$modelname$>> GetAll();
        Task<$modelname$> GetById(int id);
        Task<$modelname$> Create($modelname$ item);
        void Update($modelname$ item);
        void Delete($modelname$ item);
    }
}