﻿using SF.Core.Entitys.Abstraction;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SF.Core.Entitys
{
    public class PermissionEntity : BaseEntity
    {
        public PermissionEntity()
        {
            RolePermissions = new List<RolePermissionEntity>();
        }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IList<RolePermissionEntity> RolePermissions { get; set; }
    }
}
