using System;

namespace Weelo.Application.Features.Owners.Queries.GetAll
{
    public class GetAllOwnersViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
    }
}
