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
using FileParameter = Traq.Client.FileParameter;
using OpenAPIDateConverter = Traq.Client.OpenAPIDateConverter;

namespace Traq.Model
{
    /// <summary>
    /// 自分のユーザー詳細情報
    /// </summary>
    [DataContract(Name = "MyUserDetail")]
    public partial class MyUserDetail : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public UserAccountState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MyUserDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MyUserDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MyUserDetail" /> class.
        /// </summary>
        /// <param name="id">ユーザーUUID (required).</param>
        /// <param name="bio">自己紹介(biography) (required).</param>
        /// <param name="groups">所属グループのUUIDの配列 (required).</param>
        /// <param name="tags">タグリスト (required).</param>
        /// <param name="updatedAt">更新日時 (required).</param>
        /// <param name="lastOnline">最終オンライン日時 (required).</param>
        /// <param name="twitterId">Twitter ID (required).</param>
        /// <param name="name">ユーザー名 (required).</param>
        /// <param name="displayName">ユーザー表示名 (required).</param>
        /// <param name="iconFileId">アイコンファイルUUID (required).</param>
        /// <param name="bot">BOTかどうか (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="permissions">所有している権限の配列 (required).</param>
        /// <param name="homeChannel">ホームチャンネル (required).</param>
        public MyUserDetail(Guid id = default(Guid), string bio = default(string), List<Guid> groups = default(List<Guid>), List<UserTag> tags = default(List<UserTag>), DateTimeOffset updatedAt = default(DateTimeOffset), DateTimeOffset? lastOnline = default(DateTimeOffset?), string twitterId = default(string), string name = default(string), string displayName = default(string), Guid iconFileId = default(Guid), bool bot = default(bool), UserAccountState state = default(UserAccountState), List<UserPermission> permissions = default(List<UserPermission>), Guid? homeChannel = default(Guid?))
        {
            this.Id = id;
            // to ensure "bio" is required (not null)
            if (bio == null)
            {
                throw new ArgumentNullException("bio is a required property for MyUserDetail and cannot be null");
            }
            this.Bio = bio;
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new ArgumentNullException("groups is a required property for MyUserDetail and cannot be null");
            }
            this.Groups = groups;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for MyUserDetail and cannot be null");
            }
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
            // to ensure "lastOnline" is required (not null)
            if (lastOnline == null)
            {
                throw new ArgumentNullException("lastOnline is a required property for MyUserDetail and cannot be null");
            }
            this.LastOnline = lastOnline;
            // to ensure "twitterId" is required (not null)
            if (twitterId == null)
            {
                throw new ArgumentNullException("twitterId is a required property for MyUserDetail and cannot be null");
            }
            this.TwitterId = twitterId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for MyUserDetail and cannot be null");
            }
            this.Name = name;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for MyUserDetail and cannot be null");
            }
            this.DisplayName = displayName;
            this.IconFileId = iconFileId;
            this.Bot = bot;
            this.State = state;
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new ArgumentNullException("permissions is a required property for MyUserDetail and cannot be null");
            }
            this.Permissions = permissions;
            // to ensure "homeChannel" is required (not null)
            if (homeChannel == null)
            {
                throw new ArgumentNullException("homeChannel is a required property for MyUserDetail and cannot be null");
            }
            this.HomeChannel = homeChannel;
        }

        /// <summary>
        /// ユーザーUUID
        /// </summary>
        /// <value>ユーザーUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// 自己紹介(biography)
        /// </summary>
        /// <value>自己紹介(biography)</value>
        [DataMember(Name = "bio", IsRequired = true, EmitDefaultValue = true)]
        public string Bio { get; set; }

        /// <summary>
        /// 所属グループのUUIDの配列
        /// </summary>
        /// <value>所属グループのUUIDの配列</value>
        [DataMember(Name = "groups", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// タグリスト
        /// </summary>
        /// <value>タグリスト</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<UserTag> Tags { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        /// <value>更新日時</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// 最終オンライン日時
        /// </summary>
        /// <value>最終オンライン日時</value>
        [DataMember(Name = "lastOnline", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset? LastOnline { get; set; }

        /// <summary>
        /// Twitter ID
        /// </summary>
        /// <value>Twitter ID</value>
        [DataMember(Name = "twitterId", IsRequired = true, EmitDefaultValue = true)]
        public string TwitterId { get; set; }

        /// <summary>
        /// ユーザー名
        /// </summary>
        /// <value>ユーザー名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// ユーザー表示名
        /// </summary>
        /// <value>ユーザー表示名</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// アイコンファイルUUID
        /// </summary>
        /// <value>アイコンファイルUUID</value>
        [DataMember(Name = "iconFileId", IsRequired = true, EmitDefaultValue = true)]
        public Guid IconFileId { get; set; }

        /// <summary>
        /// BOTかどうか
        /// </summary>
        /// <value>BOTかどうか</value>
        [DataMember(Name = "bot", IsRequired = true, EmitDefaultValue = true)]
        public bool Bot { get; set; }

        /// <summary>
        /// 所有している権限の配列
        /// </summary>
        /// <value>所有している権限の配列</value>
        [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = true)]
        public List<UserPermission> Permissions { get; set; }

        /// <summary>
        /// ホームチャンネル
        /// </summary>
        /// <value>ホームチャンネル</value>
        [DataMember(Name = "homeChannel", IsRequired = true, EmitDefaultValue = true)]
        public Guid? HomeChannel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MyUserDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LastOnline: ").Append(LastOnline).Append("\n");
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IconFileId: ").Append(IconFileId).Append("\n");
            sb.Append("  Bot: ").Append(Bot).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  HomeChannel: ").Append(HomeChannel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Bio (string) maxLength
            if (this.Bio != null && this.Bio.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for Bio, length must be less than 1000.", new [] { "Bio" });
            }

            if (this.TwitterId != null) {
                // TwitterId (string) pattern
                Regex regexTwitterId = new Regex(@"^[a-zA-Z0-9_]{1,15}$", RegexOptions.CultureInvariant);
                if (!regexTwitterId.Match(this.TwitterId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TwitterId, must match a pattern of " + regexTwitterId, new [] { "TwitterId" });
                }
            }

            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@"^[a-zA-Z0-9_-]{1,32}$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 32)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 32.", new [] { "DisplayName" });
            }

            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 0)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be greater than 0.", new [] { "DisplayName" });
            }

            yield break;
        }
    }

}
