using MessagePack;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;
public class Account
{
    [Key, Column("member_nim", TypeName = "nchar(5)")]
    public int MemberNIM { get; set; }
    [Required, Column("password"), MaxLength(255)]
    public string Password { get; set; }

    //cardinality
    [JsonIgnore]
    public ICollection<AccountRole>? AccountRoles { get; set; }
    [JsonIgnore]
    public Member? Member { get; set; }
}

