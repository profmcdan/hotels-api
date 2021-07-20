using System;

namespace HotelsAPI.Data
{
    public class Country
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}