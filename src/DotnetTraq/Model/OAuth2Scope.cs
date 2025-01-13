/*
 * traQ v3
 *
 * traQ v3 API
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DotnetTraq.Client.FileParameter;
using OpenAPIDateConverter = DotnetTraq.Client.OpenAPIDateConverter;

namespace DotnetTraq.Model
{
    /// <summary>
    /// OAuth2スコープ
    /// </summary>
    /// <value>OAuth2スコープ</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuth2Scope
    {
        /// <summary>
        /// Enum Openid for value: openid
        /// </summary>
        [EnumMember(Value = "openid")]
        Openid = 1,

        /// <summary>
        /// Enum Profile for value: profile
        /// </summary>
        [EnumMember(Value = "profile")]
        Profile = 2,

        /// <summary>
        /// Enum Read for value: read
        /// </summary>
        [EnumMember(Value = "read")]
        Read = 3,

        /// <summary>
        /// Enum Write for value: write
        /// </summary>
        [EnumMember(Value = "write")]
        Write = 4,

        /// <summary>
        /// Enum ManageBot for value: manage_bot
        /// </summary>
        [EnumMember(Value = "manage_bot")]
        ManageBot = 5
    }

}