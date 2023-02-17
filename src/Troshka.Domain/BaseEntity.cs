using shortid;
using shortid.Configuration;
using Troshka.Domain.Interfaces;

namespace Troshka.Domain.Entities.VehicleAggregate
{
    public abstract class BaseEntity : IEntity<string>
    {
        /// <summary>
        /// Gets or sets the entity id property
        /// </summary>
        public string Id { get; set; } = ShortId.Generate(new GenerationOptions(useNumbers: true, useSpecialCharacters: false, length: 20));

        /// <summary>
        /// Gets or sets the entity IsDeleted property
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the entity tracking id property
        /// </summary>

        public string TrackId { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the entity creation date property
        /// </summary>

        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.UtcNow;

        /// <summary>
        /// Gets or sets the entity last update property
        /// </summary>
        public DateTimeOffset? DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the entity deletion date
        /// </summary>
        public DateTimeOffset? DateDeleted { get; set; }
    }
}
