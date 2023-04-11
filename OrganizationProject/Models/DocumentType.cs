using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_m_document_type")]
public class DocumentType
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("type"), MaxLength(255)]
    public string Type { get; set; }

    //cardinality
    [JsonIgnore]
    public ICollection<Document>? Documents { get; set; }
}
