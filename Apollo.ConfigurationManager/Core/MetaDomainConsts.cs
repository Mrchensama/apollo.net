﻿using Com.Ctrip.Framework.Apollo.Enums;
using Com.Ctrip.Framework.Apollo.Util;

namespace Com.Ctrip.Framework.Apollo.Core
{
    class MetaDomainConsts
    {
        public static string GetDomain(Env env)
        {
            switch(env)
            {
                case Env.Dev:
                    return GetAppSetting("DEV.Meta", ConfigConsts.DefaultMetaServerUrl);
                case Env.Fat:
                    return GetAppSetting("FAT.Meta", ConfigConsts.DefaultMetaServerUrl);
                case Env.Uat:
                    return GetAppSetting("UAT.Meta", ConfigConsts.DefaultMetaServerUrl);
                case Env.Pro:
                    return GetAppSetting("PRO.Meta", ConfigConsts.DefaultMetaServerUrl);
                default:
                    return ConfigConsts.DefaultMetaServerUrl;
            }
        }

        private static string GetAppSetting(string key, string defaultValue)
        {
            var value = ConfigUtil.GetAppConfig(key);

            return !string.IsNullOrWhiteSpace(value) ? value : defaultValue;
        }
    }
}
