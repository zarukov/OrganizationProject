using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_tr_accountrole")]
public class AccountRole
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("account_id", TypeName = "nchar(5)")]
    public string AccountId { get; set; }
    [Required, Column("role_id")]
    public int RoleId { get; set; }

    //cardinality
    [JsonIgnore]
    [ForeignKey(nameof(AccountId))]
    public Account? Account { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(RoleId))]
    public Role? Role { get; set; }
}
