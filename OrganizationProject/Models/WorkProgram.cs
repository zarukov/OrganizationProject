using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_m_workprogram")]
public class WorkProgram
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }
    [Required, Column("member_nim", TypeName = "nchar(5)")]
    public string MemberNIM { get; set; }
    [Required, Column("department id")]
    public int DepartmentId { get; set; }
    [Required, Column("start_date")]
    public DateTime StartDate { get; set; }
    [Required, Column("end_date")]
    public DateTime EndDate { get; set; }
    [Required, Column("budget")]
    public int Budget { get; set; }
    [Required, Column("description"), MaxLength(255)]
    public string Description { get; set; }

    //cardinality
    [JsonIgnore]
    [ForeignKey(nameof(MemberNIM))]
    public Account? Account { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(DepartmentId))]
    public Department? Department { get; set; }
}
