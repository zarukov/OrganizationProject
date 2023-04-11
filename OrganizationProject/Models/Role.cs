using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_m_role")]
public class Role
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(50)]
    public string Name { get; set; }

    //cardinality  
    [JsonIgnore]
    public ICollection<AccountRole>? AccountRoles { get; set; }
}
