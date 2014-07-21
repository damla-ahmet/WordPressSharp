﻿using CookComputing.XmlRpc;

namespace WordPressSharp.Models
{
    public class CustomField
    {
        [XmlRpcMember("id")]
        public string Id { get; set; }

        [XmlRpcMember("key")]
        public string Key { get; set; }

        [XmlRpcMember("value")]
        public string Value { get; set; }
    }
}