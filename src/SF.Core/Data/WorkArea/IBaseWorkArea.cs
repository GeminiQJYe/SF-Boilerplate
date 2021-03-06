﻿/*******************************************************************************
* 命名空间: SF.Core.Data.WorkArea
*
* 功 能： N/A
* 类 名： IBaseWorkArea
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2016/11/11 15:13:21 疯狂蚂蚁 初版
*
* Copyright (c) 2016 SF 版权所有
* Description: SF快速开发平台
* Website：http://www.mayisite.com
*********************************************************************************/
using SF.Core.Abstraction.UoW;
using SF.Core.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SF.Core.Data.WorkArea
{

    public interface IBaseWorkArea : IWorkArea
    {
        IUserRepository User { get; }

        IPermissionRepository Permission { get; }

        IUserAddressRepository UserAddress { get; }

        IMediaRespository Media { get; }

        IDataItemRepository DataItem { get; }

        ISettingRepository Setting { get; }

        IUrlSlugRepository UrlSlug { get; }

        IDistrictRepository District { get; }

        ISiteSettingsRepository SiteSettings { get; }

        ISiteHostRepository SiteHost { get; }

    }
}
