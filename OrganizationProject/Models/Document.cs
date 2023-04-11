using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_m_document")]
public class Document
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("member_nim", TypeName = "nchar(5)")]
    public string MemberNIM { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }
    [Required, Column("date")]
    public DateTime Date { get; set; }
    [Column("file"), MaxLength(255)]
    public string? File { get; set; }
    [Required, Column("document_type")]
    public int DocumentTypeId { get; set; }
    [Required, Column("document_information"), MaxLength(255)]
    public string Information { get; set; }


    //cardinality
    [JsonIgnore]
    [ForeignKey(nameof(MemberNIM))]
    public Account? Account { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(DocumentTypeId))]
    public DocumentType? DocumentType { get; set; }
}
