using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Text.Json.Serialization;

namespace OrganizationProject.Models;
[Table("tb_m_member")]
public class Member
{
    [Key, Column("student_member", TypeName = "nchar(5)")]
    public string NIM { get; set; }
    [Required, Column("name"), MaxLength(255)]
    public string Name { get; set; }
    [Required, Column("major_name"), MaxLength(255)]
    public string MajorName { get; set; }
    [Required, Column("birth_date")]
    public DateTime BirthDate { get; set; }
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
