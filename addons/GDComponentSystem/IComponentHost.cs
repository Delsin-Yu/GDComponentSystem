#nullable enable
namespace Godot.Components.Hosts;

public interface IComponentHost
{
    void AddComponent(NodeComponent nodeComponent);
    void RemoveComponent(NodeComponent nodeComponent);
}