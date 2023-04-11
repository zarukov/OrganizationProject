using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_m_account")]
public class Account
{
    [Key, Column("member_nim", TypeName = "nchar(5)")]
    public string MemberNIM { get; set; }
    [Required, Column("password"), MaxLength(255)]
    public string Password { get; set; }

    //cardinalitty
    [JsonIgnore]
    public ICollection<AccountRole>? AccountRoles { get; set; }
    [JsonIgnore]
    public Member? Member { get; set; }
}

