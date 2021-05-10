using System;

namespace Weelo.Application.Features.Properties.Queries.GetAll
{
    public class GetAllPropertiesViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public System.Collections.Generic.IList<PropertyImageViewModel> PropertyImages { get; set; }
    }
    public class PropertyImageViewModel
    {
        public string Id { get; set; }
        public string File { get; set; }
        public bool Enabled { get; set; }

        public int PropertyId { get; set; }
        
    }
}

