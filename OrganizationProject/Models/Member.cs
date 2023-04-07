using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;
public class Member
{
    public int NIM { get; set; }
    public int AccountId { get; set; }
    public string Name { get; set; }
    public string MemberId { get; set; }
    public string MajorName { get; set; }
    public DateTime BirthDate { get; set; }
    public string TitleName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
}
