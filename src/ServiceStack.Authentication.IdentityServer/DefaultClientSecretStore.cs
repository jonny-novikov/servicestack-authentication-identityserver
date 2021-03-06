﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
namespace ServiceStack.Authentication.IdentityServer
{
    using System.Threading.Tasks;
    using Configuration;
    using Extensions;
    using Interfaces;

    class DefaultClientSecretStore : IClientSecretStore
    {
        private readonly IAppSettings appSettings;
        public DefaultClientSecretStore(IAppSettings appSettings)
        {
            this.appSettings = appSettings;
        }

        public Task<string> GetSecretAsync(string clientId)
        {
            return Task.FromResult(appSettings.GetOauthSetting("ClientSecret"));
        }
    }
}
