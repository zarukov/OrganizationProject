using MessagePack;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;
public class Member
{
    [Key, Column("student_number", TypeName ="nchar(5)")]
    public int NIM { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }
    [Required, Column("member_id", TypeName ="nchar(8)")]
    public int MemberId { get; set; }
    [Required, Column("major_name"), MaxLength(255)]
    public string MajorName { get; set; }
    [Required, Column("birth_date")]
    public DateOnly BirthDate { get; set; }
    [Required, Column("title_name"), MaxLength(255)]
    public string TitleName { get; set; }
    [Required, Column("phone_number"), MaxLength(255)]
    public string PhoneNumber { get; set; }
    [Required, Column("address"), MaxLength(255)]
    public string Address { get; set; }
    [Required, Column("email"), MaxLength(255)]
    public string Email { get; set; }

    //cardinality
    [JsonIgnore]
    public Account? Account { get; set; }
}
