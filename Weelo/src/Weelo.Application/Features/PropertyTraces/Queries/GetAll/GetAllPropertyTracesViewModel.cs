using System;

namespace Weelo.Application.Features.PropertyTraces.Queries.GetAll
{
    public class GetAllPropertyTracesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Tax { get; set; }
        public DateTime DateSale { get; set; }
        public bool Enabled { get; set; }
    }
}
