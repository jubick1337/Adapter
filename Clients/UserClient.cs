using System.Linq;
using Adapter.FirstOrmLibrary;
using Adapter.Models;
using Adapter.SecondOrmLibrary;

namespace Adapter.Clients
{
    public class UserClient
    {
        private IOrmAdapter _ormAdapter;

        private IFirstOrm<DbUserEntity> _firstOrm1;
        private IFirstOrm<DbUserInfoEntity> _firstOrm2;

        private readonly ISecondOrm _secondOrm;

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            return _ormAdapter.Get(userId);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _ormAdapter.Add(user, userInfo);
        }

        public void Remove(int userId)
        {
            _ormAdapter.Remove(userId);
        }

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }
    }
}
