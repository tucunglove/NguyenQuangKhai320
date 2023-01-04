using System.ComponentModel.DataAnnotations;
namespace NguyenQuangKhai320.Models;

public class CompanyNQK320
{
    [Key]
    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }
}