using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OrganizationProject.Models;
public class Finance
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AccountId { get; set; }
    public DateTime Date { get; set; }
    public int IncomingFunds { get; set; }
    public int OutcomingFunds { get; set; }
    public int TotalFunds { get; set; }
    public string Information { get; set; }
}
