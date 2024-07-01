namespace money_manager.Models
{
    public class IncomeModel
    {
        public int IncomeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
