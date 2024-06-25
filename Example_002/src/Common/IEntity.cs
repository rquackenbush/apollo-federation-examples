using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Common
{
    [InterfaceType("Entity")]
    public interface IEntity
    {
        [ID]
        public string Id { get; set; }
    }
}
