using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$.$modelname$
{
    /// <summary>
    /// $modelname$Repository
    /// </summary>
    public class $modelname$Repository : I$modelname$Repository
    {
        private readonly ILogger<$modelname$Repository> logger;
        private readonly DbContext dbContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="logger"></param>
        public $modelname$Repository(DbContext dbContext, ILogger<$modelname$Repository> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<$modelname$>> GetAll()
        {
            return await dbContext.$modelname$.ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<$modelname$> GetById(int id)
        {
            return await dbContext.$modelname$.FindAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<$modelname$> Create($modelname$ item)
        {
            var entityEntry = await dbContext.$modelname$.AddAsync(item);
            return entityEntry.Entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Update($modelname$ item)
        {
            dbContext.$modelname$.Update(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Delete($modelname$ item)
        {
            dbContext.$modelname$.Remove(item);
        }
    }
}