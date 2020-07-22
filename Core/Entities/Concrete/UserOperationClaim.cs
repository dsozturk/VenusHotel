using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public long UserId { get; set; }
        public long OperationClaimId { get; set; }

    }
}
