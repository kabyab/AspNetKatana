﻿// <copyright file="FormsAuthenticationDefaults.cs" company="Microsoft Open Technologies, Inc.">
// Copyright 2011-2013 Microsoft Open Technologies, Inc. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace Microsoft.Owin.Security.Forms
{
    public static class FormsAuthenticationDefaults
    {
        public const string AuthenticationType = "Forms";
        public const string ApplicationAuthenticationType = "Application";
        public const string ExternalAuthenticationType = "External";

        public const string CookiePrefix = ".AspNet.";
        public const string LoginPath = "/Account/Login";
        public const string LogoutPath = "/Account/Logout";
        public const string ReturnUrlParameter = "ReturnUrl";
    }
}
