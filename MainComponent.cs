using Godot;
using Godot.Components;

namespace GDComponentSystem.BindingGenerator;

[GlobalClass, Tool]
public partial class MainComponent : NodeComponent
{
    public override void _Ready()
    {
        GD.Print("Component is ready!");
    }
}