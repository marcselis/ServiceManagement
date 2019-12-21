using System;
using System.Collections.Generic;

namespace Domain
{
    /// <summary>
    /// Represents a service delivered by a certain squad
    /// </summary>
    public class Service
    {
        public Service(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public List<Component> Components { get; } = new List<Component>();
        public string Description { get; private set; }
        public Guid Id { get; }
        public string Name { get; private set; }
    }
}