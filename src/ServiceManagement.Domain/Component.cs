using System;

namespace Domain
{
    /// <summary>
    /// Represents a component of a certain service
    /// </summary>
    public class Component
    {
        public Component(Guid id, string name, string description, Guid serviceId)
        {
            Id = id;
            Name = name;
            Description = description;
            ServiceId = serviceId;
        }

        public Guid Id { get; }
        public string Name { get; private set; }
        public string Description { get; }
        public Guid ServiceId { get; }
    }

    public class Asset
    {

    }

    public class AssetVersion
    {

    }

    public class Package
    {

    }
}
