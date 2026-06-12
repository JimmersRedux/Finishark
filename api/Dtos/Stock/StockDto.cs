using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;

namespace api.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 chars.")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(100, ErrorMessage = "CompanyName cannot be over 100 chars.")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1,1000000000000, ErrorMessage = "Purchase Price incorrect.")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100, ErrorMessage = "Div incorrect.")]
        public decimal LastDiv {get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Inducstry cannot be over 10 chars.")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1,5000000000000, ErrorMessage = "Market Cap incorrect.")]
        public long MarketCap { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}