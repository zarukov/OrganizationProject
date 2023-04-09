using MessagePack;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;
public class WorkProgram
{
    [Key, Column("id")]
    public string Id { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }
    [Required, Column("member_nim", TypeName ="nchar(5)")]
    public int MemberNIM { get; set; }
    [Required, Column("department_id")]
    public int DepartmentId { get; set; }
    [Required, Column("start_date")]
    public DateOnly StartDate { get; set; }
    [Required, Column("end_date")]
    public DateTime EndDate { get; set; }
    [Required, Column("budget")]
    public int Budget { get; set; }
    [Required, Column("description"), MaxLength(255)]
    public string Description { get; set; }

    //cardinality
    [JsonIgnore]
    public Account? Account { get; set; }
    [JsonIgnore]
    public Department? Department { get; set; }
}
