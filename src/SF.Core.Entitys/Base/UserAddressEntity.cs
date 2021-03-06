﻿using System;
using SF.Core.Entitys.Abstraction;

namespace SF.Core.Entitys
{
    public class UserAddressEntity : BaseEntity
    {
        public long UserId { get; set; }

        public virtual UserEntity User { get; set; }

        public long AddressId { get; set; }

        public virtual AddressEntity Address { get; set; }

        public AddressType AddressType { get; set; }

        public DateTimeOffset? LastUsedOn { get; set; }
    }
}
