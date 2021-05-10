using System;

namespace Weelo.Application.Features.Properties.Queries.GetAll
{
    public class GetAllPropertiesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
    }
}
