using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Models;
using Adapter.SecondOrmLibrary;

namespace Adapter.Clients
{
    class SecondOrmAdapter : IOrmAdapter
    {
        private ISecondOrm _secondOrm;

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _secondOrm.Context.UserInfos.Add(userInfo);
            _secondOrm.Context.Users.Add(user);
        }
        
        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = _secondOrm.Context.Users.First(i => i.Id == userId);
            var userInfo = _secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);
            return (user, userInfo);
        }

        public void Remove(int userId)
        {
            var user = _secondOrm.Context.Users.First(i => i.Id == userId);
            var userInfo = _secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);
            _secondOrm.Context.Users.Remove(user);
            _secondOrm.Context.UserInfos.Remove(userInfo);
        }
    }
}
