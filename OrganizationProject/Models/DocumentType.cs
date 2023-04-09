using MessagePack;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;
[Table("tb_m_department")]
public class DocumentType
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("type"), MaxLength(255)]
    public int Type { get; set; }

    //cardinality
    [JsonIgnore]
    public ICollection<Document>? Documents { get; set; }
}
