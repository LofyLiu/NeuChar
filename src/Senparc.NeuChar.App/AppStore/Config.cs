﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2021 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc
  
    文件名：Config.cs
    文件功能描述：调试设置
    
    
    创建标识：Senparc - 20150319

    修改标识：Senparc - 20230610
    修改描述：v1.1.6 添加“默认 NeuChar AppStore 的接口地址”设置属性


----------------------------------------------------------------*/

namespace Senparc.NeuChar.App.AppStore
{
    /// <summary>
    /// AppStore 配置
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// 是否启用调试状态
        /// </summary>
        public static bool IsDebug = false;

        /// <summary>
        /// 默认 NeuChar AppStore 的接口地址
        /// </summary>
        public static string DefaultDomainName = "https://www.neuchar.com";
    }
}
