﻿using System.Collections.Generic;
using AuthenticatorPro.Shared.Data;
using OtpNet;

namespace AuthenticatorPro.Shared.Query
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public class WearAuthenticator
    {
        public readonly AuthenticatorType Type;
        public readonly string Secret;
        public readonly string Icon;
        public readonly string Issuer;
        public readonly string Username;
        public readonly int Period;
        public readonly int Digits;
        public readonly OtpHashMode Algorithm;
        public readonly List<string> CategoryIds;


        public WearAuthenticator(AuthenticatorType type, string secret, string icon, string issuer, string username, int period, int digits, OtpHashMode algorithm, List<string> categoryIds)
        {
            Type = type;
            Secret = secret;
            Icon = icon;
            Issuer = issuer;
            Username = username;
            Period = period;
            Digits = digits;
            Algorithm = algorithm;
            CategoryIds = categoryIds;
        }
    }
}