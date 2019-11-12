using Adapter.Models.Interfaces;

namespace Adapter.FirstOrmLibrary
{
    interface IFirstOrm<TDbEntity> where TDbEntity : IDbEntity
    {
        void Add(TDbEntity entity);
        TDbEntity Read(int id);
        void Delete(TDbEntity entity);

    }
}
