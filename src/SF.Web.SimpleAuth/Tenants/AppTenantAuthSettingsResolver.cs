﻿
using SF.Web.SimpleAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SF.Web.SimpleAuth.Tenants
{
    public class AppTenantAuthSettingsResolver : IAuthSettingsResolver
    {
        public AppTenantAuthSettingsResolver(AppTenant tenant)
        {
            this.tenant = tenant;

            authSettings = new SimpleAuthSettings();
            authSettings.AuthenticationScheme = tenant.AuthenticationScheme;
            authSettings.RecaptchaPrivateKey = tenant.RecaptchaPrivateKey;
            authSettings.RecaptchaPublicKey = tenant.RecaptchaPublicKey;
            authSettings.EnablePasswordHasherUi = tenant.EnablePasswordHasherUi;
        }

        private AppTenant tenant;
        private SimpleAuthSettings authSettings;

        public SimpleAuthSettings GetCurrentAuthSettings()
        {
            return authSettings;
        }
    }
}
