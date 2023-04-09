using MessagePack;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;

public class AccountRole
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("account_id", TypeName ="nchar(5)")]
    public int AccountId { get; set; }
    [Required, Column("role_id")]
    public int RoleId { get; set; }

    //cardinality
    [JsonIgnore]
    public Account? Account { get; set; }
    [JsonIgnore]
    public Role? Role { get; set; }
}
