using Adapter.Models;
using System.Collections.Generic;

namespace Adapter.SecondOrmLibrary
{
    public interface ISecondOrm
    {
        ISecondOrmContext Context { get; }
    }

    public interface ISecondOrmContext
    {
        HashSet<DbUserEntity> Users { get; }
        HashSet<DbUserInfoEntity> UserInfos { get; }
    }
}
