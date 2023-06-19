using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingSystem.Models;

public class Transaction
{
    [Key]
    public int TransactionId { get; set; }
    
    [Column(TypeName = "nvarchar(12)")]
    [DisplayName("Account Number")]
    [Required(ErrorMessage = "This field is required.")]
    public string AccountNumber { get; set; }
    
    [Column(TypeName = "nvarchar(100)")]
    [DisplayName("Beneficiary Name")]
    [Required(ErrorMessage = "This field is required.")]
    public string BeneficiaryName { get; set; }
    
    [Column(TypeName =  "nvarchar(100)")]
    [DisplayName("Bank Name")]
    [Required(ErrorMessage = "This field is required.")]
    public string BankName { get; set; }
    
    [Column(TypeName =  "nvarchar(11)")]
    [DisplayName("SWIFT Code")]
    [Required(ErrorMessage = "This field is required.")]
    [MaxLength(11, ErrorMessage = "SWIFT Code must be 11 characters long.")]
    public string SWIFTCode { get; set; }
    
    [Required(ErrorMessage = "This field is required.")]
    [DisplayName("Amount")]
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    
}