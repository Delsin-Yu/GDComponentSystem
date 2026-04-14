#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Node" />
[Tool, GlobalClass]
public abstract partial class NodeComponent : Resource
{

    private protected IComponentHost _host;

    private protected virtual void _OnComponentAdded(Node hostInstance) { }

    private protected virtual void _OnComponentRemoved(Node hostInstance) { }

    /// <inheritdoc cref="Node.GetNode{T}(NodePath)" />
    public T GetNode<T>(NodePath @path) where T : class
        => ((Node)_host).GetNode<T>(@path);

    /// <inheritdoc cref="Node.GetNodeOrNull{T}(NodePath)" />
    public T GetNodeOrNull<T>(NodePath @path) where T : class
        => ((Node)_host).GetNodeOrNull<T>(@path);

    /// <inheritdoc cref="Node.GetChild{T}(int, bool)" />
    public T GetChild<T>(int @idx, bool @includeInternal) where T : class
        => ((Node)_host).GetChild<T>(@idx, @includeInternal);

    /// <inheritdoc cref="Node.GetChildOrNull{T}(int, bool)" />
    public T GetChildOrNull<T>(int @idx, bool @includeInternal) where T : class
        => ((Node)_host).GetChildOrNull<T>(@idx, @includeInternal);

    /// <inheritdoc cref="Node.GetOwner{T}()" />
    public T GetOwner<T>() where T : class
        => ((Node)_host).GetOwner<T>();

    /// <inheritdoc cref="Node.GetOwnerOrNull{T}()" />
    public T GetOwnerOrNull<T>() where T : class
        => ((Node)_host).GetOwnerOrNull<T>();

    /// <inheritdoc cref="Node.GetParent{T}()" />
    public T GetParent<T>() where T : class
        => ((Node)_host).GetParent<T>();

    /// <inheritdoc cref="Node.GetParentOrNull{T}()" />
    public T GetParentOrNull<T>() where T : class
        => ((Node)_host).GetParentOrNull<T>();

    /// <inheritdoc cref="Node._EnterTree()" />
    public virtual void _EnterTree() { }

    /// <inheritdoc cref="Node._ExitTree()" />
    public virtual void _ExitTree() { }

    /// <inheritdoc cref="Node._GetAccessibilityConfigurationWarnings()" />
    public virtual string[] _GetAccessibilityConfigurationWarnings() => ((Node)_host)._GetAccessibilityConfigurationWarnings();

    /// <inheritdoc cref="Node._GetConfigurationWarnings()" />
    public virtual string[] _GetConfigurationWarnings() => ((Node)_host)._GetConfigurationWarnings();

    /// <inheritdoc cref="Node._GetFocusedAccessibilityElement()" />
    public virtual Rid _GetFocusedAccessibilityElement() => ((Node)_host)._GetFocusedAccessibilityElement();

    /// <inheritdoc cref="Node._Input(InputEvent)" />
    public virtual void _Input(InputEvent @event) { }

    /// <inheritdoc cref="Node._PhysicsProcess(double)" />
    public virtual void _PhysicsProcess(double @delta) { }

    /// <inheritdoc cref="Node._Process(double)" />
    public virtual void _Process(double @delta) { }

    /// <inheritdoc cref="Node._Ready()" />
    public virtual void _Ready() { }

    /// <inheritdoc cref="Node._ShortcutInput(InputEvent)" />
    public virtual void _ShortcutInput(InputEvent @event) { }

    /// <inheritdoc cref="Node._UnhandledInput(InputEvent)" />
    public virtual void _UnhandledInput(InputEvent @event) { }

    /// <inheritdoc cref="Node._UnhandledKeyInput(InputEvent)" />
    public virtual void _UnhandledKeyInput(InputEvent @event) { }

    /// <inheritdoc cref="Node.AddSibling(Node, bool)" />
    public void AddSibling(Node @sibling, bool @forceReadableName) => ((Node)_host).AddSibling(@sibling, @forceReadableName);

    /// <inheritdoc cref="Node.SetName(StringName)" />
    public void SetName(StringName @name) => ((Node)_host).SetName(@name);

    /// <inheritdoc cref="Node.GetName()" />
    public StringName GetName() => ((Node)_host).GetName();

    /// <inheritdoc cref="Node.AddChild(Node, bool, Node.InternalMode)" />
    public void AddChild(Node @node, bool @forceReadableName, Node.InternalMode @internal) => ((Node)_host).AddChild(@node, @forceReadableName, @internal);

    /// <inheritdoc cref="Node.RemoveChild(Node)" />
    public void RemoveChild(Node @node) => ((Node)_host).RemoveChild(@node);

    /// <inheritdoc cref="Node.Reparent(Node, bool)" />
    public void Reparent(Node @newParent, bool @keepGlobalTransform) => ((Node)_host).Reparent(@newParent, @keepGlobalTransform);

    /// <inheritdoc cref="Node.GetChildCount(bool)" />
    public int GetChildCount(bool @includeInternal) => ((Node)_host).GetChildCount(@includeInternal);

    /// <inheritdoc cref="Node.GetChildren(bool)" />
    public Array<Node> GetChildren(bool @includeInternal) => ((Node)_host).GetChildren(@includeInternal);

    /// <inheritdoc cref="Node.GetChild(int, bool)" />
    public Node GetChild(int @idx, bool @includeInternal) => ((Node)_host).GetChild(@idx, @includeInternal);

    /// <inheritdoc cref="Node.HasNode(NodePath)" />
    public bool HasNode(NodePath @path) => ((Node)_host).HasNode(@path);

    /// <inheritdoc cref="Node.GetNode(NodePath)" />
    public Node GetNode(NodePath @path) => ((Node)_host).GetNode(@path);

    /// <inheritdoc cref="Node.GetNodeOrNull(NodePath)" />
    public Node GetNodeOrNull(NodePath @path) => ((Node)_host).GetNodeOrNull(@path);

    /// <inheritdoc cref="Node.GetParent()" />
    public Node GetParent() => ((Node)_host).GetParent();

    /// <inheritdoc cref="Node.FindChild(string, bool, bool)" />
    public Node FindChild(string @pattern, bool @recursive, bool @owned) => ((Node)_host).FindChild(@pattern, @recursive, @owned);

    /// <inheritdoc cref="Node.FindChildren(string, string, bool, bool)" />
    public Array<Node> FindChildren(string @pattern, string @type, bool @recursive, bool @owned) => ((Node)_host).FindChildren(@pattern, @type, @recursive, @owned);

    /// <inheritdoc cref="Node.FindParent(string)" />
    public Node FindParent(string @pattern) => ((Node)_host).FindParent(@pattern);

    /// <inheritdoc cref="Node.HasNodeAndResource(NodePath)" />
    public bool HasNodeAndResource(NodePath @path) => ((Node)_host).HasNodeAndResource(@path);

    /// <inheritdoc cref="Node.GetNodeAndResource(NodePath)" />
    public Array GetNodeAndResource(NodePath @path) => ((Node)_host).GetNodeAndResource(@path);

    /// <inheritdoc cref="Node.IsInsideTree()" />
    public bool IsInsideTree() => ((Node)_host).IsInsideTree();

    /// <inheritdoc cref="Node.IsPartOfEditedScene()" />
    public bool IsPartOfEditedScene() => ((Node)_host).IsPartOfEditedScene();

    /// <inheritdoc cref="Node.IsAncestorOf(Node)" />
    public bool IsAncestorOf(Node @node) => ((Node)_host).IsAncestorOf(@node);

    /// <inheritdoc cref="Node.IsGreaterThan(Node)" />
    public bool IsGreaterThan(Node @node) => ((Node)_host).IsGreaterThan(@node);

    /// <inheritdoc cref="Node.GetPath()" />
    public NodePath GetPath() => ((Node)_host).GetPath();

    /// <inheritdoc cref="Node.GetPathTo(Node, bool)" />
    public NodePath GetPathTo(Node @node, bool @useUniquePath) => ((Node)_host).GetPathTo(@node, @useUniquePath);

    /// <inheritdoc cref="Node.AddToGroup(StringName, bool)" />
    public void AddToGroup(StringName @group, bool @persistent) => ((Node)_host).AddToGroup(@group, @persistent);

    /// <inheritdoc cref="Node.RemoveFromGroup(StringName)" />
    public void RemoveFromGroup(StringName @group) => ((Node)_host).RemoveFromGroup(@group);

    /// <inheritdoc cref="Node.IsInGroup(StringName)" />
    public bool IsInGroup(StringName @group) => ((Node)_host).IsInGroup(@group);

    /// <inheritdoc cref="Node.MoveChild(Node, int)" />
    public void MoveChild(Node @childNode, int @toIndex) => ((Node)_host).MoveChild(@childNode, @toIndex);

    /// <inheritdoc cref="Node.GetGroups()" />
    public Array<StringName> GetGroups() => ((Node)_host).GetGroups();

    /// <inheritdoc cref="Node.SetOwner(Node)" />
    public void SetOwner(Node @owner) => ((Node)_host).SetOwner(@owner);

    /// <inheritdoc cref="Node.GetOwner()" />
    public Node GetOwner() => ((Node)_host).GetOwner();

    /// <inheritdoc cref="Node.GetIndex(bool)" />
    public int GetIndex(bool @includeInternal) => ((Node)_host).GetIndex(@includeInternal);

    /// <inheritdoc cref="Node.PrintTree()" />
    public void PrintTree() => ((Node)_host).PrintTree();

    /// <inheritdoc cref="Node.PrintTreePretty()" />
    public void PrintTreePretty() => ((Node)_host).PrintTreePretty();

    /// <inheritdoc cref="Node.GetTreeString()" />
    public string GetTreeString() => ((Node)_host).GetTreeString();

    /// <inheritdoc cref="Node.GetTreeStringPretty()" />
    public string GetTreeStringPretty() => ((Node)_host).GetTreeStringPretty();

    /// <inheritdoc cref="Node.SetSceneFilePath(string)" />
    public void SetSceneFilePath(string @sceneFilePath) => ((Node)_host).SetSceneFilePath(@sceneFilePath);

    /// <inheritdoc cref="Node.GetSceneFilePath()" />
    public string GetSceneFilePath() => ((Node)_host).GetSceneFilePath();

    /// <inheritdoc cref="Node.PropagateNotification(int)" />
    public void PropagateNotification(int @what) => ((Node)_host).PropagateNotification(@what);

    /// <inheritdoc cref="Node.PropagateCall(StringName, Array, bool)" />
    public void PropagateCall(StringName @method, Array @args, bool @parentFirst) => ((Node)_host).PropagateCall(@method, @args, @parentFirst);

    /// <inheritdoc cref="Node.SetPhysicsProcess(bool)" />
    public void SetPhysicsProcess(bool @enable) => ((Node)_host).SetPhysicsProcess(@enable);

    /// <inheritdoc cref="Node.GetPhysicsProcessDeltaTime()" />
    public double GetPhysicsProcessDeltaTime() => ((Node)_host).GetPhysicsProcessDeltaTime();

    /// <inheritdoc cref="Node.IsPhysicsProcessing()" />
    public bool IsPhysicsProcessing() => ((Node)_host).IsPhysicsProcessing();

    /// <inheritdoc cref="Node.GetProcessDeltaTime()" />
    public double GetProcessDeltaTime() => ((Node)_host).GetProcessDeltaTime();

    /// <inheritdoc cref="Node.SetProcess(bool)" />
    public void SetProcess(bool @enable) => ((Node)_host).SetProcess(@enable);

    /// <inheritdoc cref="Node.SetProcessPriority(int)" />
    public void SetProcessPriority(int @priority) => ((Node)_host).SetProcessPriority(@priority);

    /// <inheritdoc cref="Node.GetProcessPriority()" />
    public int GetProcessPriority() => ((Node)_host).GetProcessPriority();

    /// <inheritdoc cref="Node.SetPhysicsProcessPriority(int)" />
    public void SetPhysicsProcessPriority(int @priority) => ((Node)_host).SetPhysicsProcessPriority(@priority);

    /// <inheritdoc cref="Node.GetPhysicsProcessPriority()" />
    public int GetPhysicsProcessPriority() => ((Node)_host).GetPhysicsProcessPriority();

    /// <inheritdoc cref="Node.IsProcessing()" />
    public bool IsProcessing() => ((Node)_host).IsProcessing();

    /// <inheritdoc cref="Node.SetProcessInput(bool)" />
    public void SetProcessInput(bool @enable) => ((Node)_host).SetProcessInput(@enable);

    /// <inheritdoc cref="Node.IsProcessingInput()" />
    public bool IsProcessingInput() => ((Node)_host).IsProcessingInput();

    /// <inheritdoc cref="Node.SetProcessShortcutInput(bool)" />
    public void SetProcessShortcutInput(bool @enable) => ((Node)_host).SetProcessShortcutInput(@enable);

    /// <inheritdoc cref="Node.IsProcessingShortcutInput()" />
    public bool IsProcessingShortcutInput() => ((Node)_host).IsProcessingShortcutInput();

    /// <inheritdoc cref="Node.SetProcessUnhandledInput(bool)" />
    public void SetProcessUnhandledInput(bool @enable) => ((Node)_host).SetProcessUnhandledInput(@enable);

    /// <inheritdoc cref="Node.IsProcessingUnhandledInput()" />
    public bool IsProcessingUnhandledInput() => ((Node)_host).IsProcessingUnhandledInput();

    /// <inheritdoc cref="Node.SetProcessUnhandledKeyInput(bool)" />
    public void SetProcessUnhandledKeyInput(bool @enable) => ((Node)_host).SetProcessUnhandledKeyInput(@enable);

    /// <inheritdoc cref="Node.IsProcessingUnhandledKeyInput()" />
    public bool IsProcessingUnhandledKeyInput() => ((Node)_host).IsProcessingUnhandledKeyInput();

    /// <inheritdoc cref="Node.SetProcessMode(Node.ProcessModeEnum)" />
    public void SetProcessMode(Node.ProcessModeEnum @mode) => ((Node)_host).SetProcessMode(@mode);

    /// <inheritdoc cref="Node.GetProcessMode()" />
    public Node.ProcessModeEnum GetProcessMode() => ((Node)_host).GetProcessMode();

    /// <inheritdoc cref="Node.CanProcess()" />
    public bool CanProcess() => ((Node)_host).CanProcess();

    /// <inheritdoc cref="Node.SetProcessThreadGroup(Node.ProcessThreadGroupEnum)" />
    public void SetProcessThreadGroup(Node.ProcessThreadGroupEnum @mode) => ((Node)_host).SetProcessThreadGroup(@mode);

    /// <inheritdoc cref="Node.GetProcessThreadGroup()" />
    public Node.ProcessThreadGroupEnum GetProcessThreadGroup() => ((Node)_host).GetProcessThreadGroup();

    /// <inheritdoc cref="Node.SetProcessThreadMessages(Node.ProcessThreadMessagesEnum)" />
    public void SetProcessThreadMessages(Node.ProcessThreadMessagesEnum @flags) => ((Node)_host).SetProcessThreadMessages(@flags);

    /// <inheritdoc cref="Node.GetProcessThreadMessages()" />
    public Node.ProcessThreadMessagesEnum GetProcessThreadMessages() => ((Node)_host).GetProcessThreadMessages();

    /// <inheritdoc cref="Node.SetProcessThreadGroupOrder(int)" />
    public void SetProcessThreadGroupOrder(int @order) => ((Node)_host).SetProcessThreadGroupOrder(@order);

    /// <inheritdoc cref="Node.GetProcessThreadGroupOrder()" />
    public int GetProcessThreadGroupOrder() => ((Node)_host).GetProcessThreadGroupOrder();

    /// <inheritdoc cref="Node.QueueAccessibilityUpdate()" />
    public void QueueAccessibilityUpdate() => ((Node)_host).QueueAccessibilityUpdate();

    /// <inheritdoc cref="Node.GetAccessibilityElement()" />
    public Rid GetAccessibilityElement() => ((Node)_host).GetAccessibilityElement();

    /// <inheritdoc cref="Node.SetDisplayFolded(bool)" />
    public void SetDisplayFolded(bool @fold) => ((Node)_host).SetDisplayFolded(@fold);

    /// <inheritdoc cref="Node.IsDisplayedFolded()" />
    public bool IsDisplayedFolded() => ((Node)_host).IsDisplayedFolded();

    /// <inheritdoc cref="Node.SetProcessInternal(bool)" />
    public void SetProcessInternal(bool @enable) => ((Node)_host).SetProcessInternal(@enable);

    /// <inheritdoc cref="Node.IsProcessingInternal()" />
    public bool IsProcessingInternal() => ((Node)_host).IsProcessingInternal();

    /// <inheritdoc cref="Node.SetPhysicsProcessInternal(bool)" />
    public void SetPhysicsProcessInternal(bool @enable) => ((Node)_host).SetPhysicsProcessInternal(@enable);

    /// <inheritdoc cref="Node.IsPhysicsProcessingInternal()" />
    public bool IsPhysicsProcessingInternal() => ((Node)_host).IsPhysicsProcessingInternal();

    /// <inheritdoc cref="Node.SetPhysicsInterpolationMode(Node.PhysicsInterpolationModeEnum)" />
    public void SetPhysicsInterpolationMode(Node.PhysicsInterpolationModeEnum @mode) => ((Node)_host).SetPhysicsInterpolationMode(@mode);

    /// <inheritdoc cref="Node.GetPhysicsInterpolationMode()" />
    public Node.PhysicsInterpolationModeEnum GetPhysicsInterpolationMode() => ((Node)_host).GetPhysicsInterpolationMode();

    /// <inheritdoc cref="Node.IsPhysicsInterpolated()" />
    public bool IsPhysicsInterpolated() => ((Node)_host).IsPhysicsInterpolated();

    /// <inheritdoc cref="Node.IsPhysicsInterpolatedAndEnabled()" />
    public bool IsPhysicsInterpolatedAndEnabled() => ((Node)_host).IsPhysicsInterpolatedAndEnabled();

    /// <inheritdoc cref="Node.ResetPhysicsInterpolation()" />
    public void ResetPhysicsInterpolation() => ((Node)_host).ResetPhysicsInterpolation();

    /// <inheritdoc cref="Node.SetAutoTranslateMode(Node.AutoTranslateModeEnum)" />
    public void SetAutoTranslateMode(Node.AutoTranslateModeEnum @mode) => ((Node)_host).SetAutoTranslateMode(@mode);

    /// <inheritdoc cref="Node.GetAutoTranslateMode()" />
    public Node.AutoTranslateModeEnum GetAutoTranslateMode() => ((Node)_host).GetAutoTranslateMode();

    /// <inheritdoc cref="Node.CanAutoTranslate()" />
    public bool CanAutoTranslate() => ((Node)_host).CanAutoTranslate();

    /// <inheritdoc cref="Node.SetTranslationDomainInherited()" />
    public void SetTranslationDomainInherited() => ((Node)_host).SetTranslationDomainInherited();

    /// <inheritdoc cref="Node.GetWindow()" />
    public Window GetWindow() => ((Node)_host).GetWindow();

    /// <inheritdoc cref="Node.GetLastExclusiveWindow()" />
    public Window GetLastExclusiveWindow() => ((Node)_host).GetLastExclusiveWindow();

    /// <inheritdoc cref="Node.GetTree()" />
    public SceneTree GetTree() => ((Node)_host).GetTree();

    /// <inheritdoc cref="Node.CreateTween()" />
    public Tween CreateTween() => ((Node)_host).CreateTween();

    /// <inheritdoc cref="Node.Duplicate(int)" />
    public Node Duplicate(int @flags) => ((Node)_host).Duplicate(@flags);

    /// <inheritdoc cref="Node.ReplaceBy(Node, bool)" />
    public void ReplaceBy(Node @node, bool @keepGroups) => ((Node)_host).ReplaceBy(@node, @keepGroups);

    /// <inheritdoc cref="Node.SetSceneInstanceLoadPlaceholder(bool)" />
    public void SetSceneInstanceLoadPlaceholder(bool @loadPlaceholder) => ((Node)_host).SetSceneInstanceLoadPlaceholder(@loadPlaceholder);

    /// <inheritdoc cref="Node.GetSceneInstanceLoadPlaceholder()" />
    public bool GetSceneInstanceLoadPlaceholder() => ((Node)_host).GetSceneInstanceLoadPlaceholder();

    /// <inheritdoc cref="Node.SetEditableInstance(Node, bool)" />
    public void SetEditableInstance(Node @node, bool @isEditable) => ((Node)_host).SetEditableInstance(@node, @isEditable);

    /// <inheritdoc cref="Node.IsEditableInstance(Node)" />
    public bool IsEditableInstance(Node @node) => ((Node)_host).IsEditableInstance(@node);

    /// <inheritdoc cref="Node.GetViewport()" />
    public Viewport GetViewport() => ((Node)_host).GetViewport();

    /// <inheritdoc cref="Node.QueueFree()" />
    public void QueueFree() => ((Node)_host).QueueFree();

    /// <inheritdoc cref="Node.RequestReady()" />
    public void RequestReady() => ((Node)_host).RequestReady();

    /// <inheritdoc cref="Node.IsNodeReady()" />
    public bool IsNodeReady() => ((Node)_host).IsNodeReady();

    /// <inheritdoc cref="Node.SetMultiplayerAuthority(int, bool)" />
    public void SetMultiplayerAuthority(int @id, bool @recursive) => ((Node)_host).SetMultiplayerAuthority(@id, @recursive);

    /// <inheritdoc cref="Node.GetMultiplayerAuthority()" />
    public int GetMultiplayerAuthority() => ((Node)_host).GetMultiplayerAuthority();

    /// <inheritdoc cref="Node.IsMultiplayerAuthority()" />
    public bool IsMultiplayerAuthority() => ((Node)_host).IsMultiplayerAuthority();

    /// <inheritdoc cref="Node.GetMultiplayer()" />
    public MultiplayerApi GetMultiplayer() => ((Node)_host).GetMultiplayer();

    /// <inheritdoc cref="Node.RpcConfig(StringName, Variant)" />
    public void RpcConfig(StringName @method, Variant @config) => ((Node)_host).RpcConfig(@method, @config);

    /// <inheritdoc cref="Node.GetNodeRpcConfig()" />
    public Variant GetNodeRpcConfig() => ((Node)_host).GetNodeRpcConfig();

    /// <inheritdoc cref="Node.SetEditorDescription(string)" />
    public void SetEditorDescription(string @editorDescription) => ((Node)_host).SetEditorDescription(@editorDescription);

    /// <inheritdoc cref="Node.GetEditorDescription()" />
    public string GetEditorDescription() => ((Node)_host).GetEditorDescription();

    /// <inheritdoc cref="Node.SetUniqueNameInOwner(bool)" />
    public void SetUniqueNameInOwner(bool @enable) => ((Node)_host).SetUniqueNameInOwner(@enable);

    /// <inheritdoc cref="Node.IsUniqueNameInOwner()" />
    public bool IsUniqueNameInOwner() => ((Node)_host).IsUniqueNameInOwner();

    /// <inheritdoc cref="Node.Atr(string, StringName)" />
    public string Atr(string @message, StringName @context) => ((Node)_host).Atr(@message, @context);

    /// <inheritdoc cref="Node.AtrN(string, StringName, int, StringName)" />
    public string AtrN(string @message, StringName @pluralMessage, int @n, StringName @context) => ((Node)_host).AtrN(@message, @pluralMessage, @n, @context);

    /// <inheritdoc cref="Node.Rpc(StringName, Variant[])" />
    public Error Rpc(StringName @method, Variant[] @args) => ((Node)_host).Rpc(@method, @args);

    /// <inheritdoc cref="Node.Rpc(StringName, ReadOnlySpan{Variant})" />
    public Error Rpc(StringName @method, ReadOnlySpan<Variant> @args) => ((Node)_host).Rpc(@method, @args);

    /// <inheritdoc cref="Node.RpcId(long, StringName, Variant[])" />
    public Error RpcId(long @peerId, StringName @method, Variant[] @args) => ((Node)_host).RpcId(@peerId, @method, @args);

    /// <inheritdoc cref="Node.RpcId(long, StringName, ReadOnlySpan{Variant})" />
    public Error RpcId(long @peerId, StringName @method, ReadOnlySpan<Variant> @args) => ((Node)_host).RpcId(@peerId, @method, @args);

    /// <inheritdoc cref="Node.UpdateConfigurationWarnings()" />
    public void UpdateConfigurationWarnings() => ((Node)_host).UpdateConfigurationWarnings();

    /// <inheritdoc cref="Node.CallDeferredThreadGroup(StringName, Variant[])" />
    public Variant CallDeferredThreadGroup(StringName @method, Variant[] @args) => ((Node)_host).CallDeferredThreadGroup(@method, @args);

    /// <inheritdoc cref="Node.CallDeferredThreadGroup(StringName, ReadOnlySpan{Variant})" />
    public Variant CallDeferredThreadGroup(StringName @method, ReadOnlySpan<Variant> @args) => ((Node)_host).CallDeferredThreadGroup(@method, @args);

    /// <inheritdoc cref="Node.SetDeferredThreadGroup(StringName, Variant)" />
    public void SetDeferredThreadGroup(StringName @property, Variant @value) => ((Node)_host).SetDeferredThreadGroup(@property, @value);

    /// <inheritdoc cref="Node.NotifyDeferredThreadGroup(int)" />
    public void NotifyDeferredThreadGroup(int @what) => ((Node)_host).NotifyDeferredThreadGroup(@what);

    /// <inheritdoc cref="Node.CallThreadSafe(StringName, Variant[])" />
    public Variant CallThreadSafe(StringName @method, Variant[] @args) => ((Node)_host).CallThreadSafe(@method, @args);

    /// <inheritdoc cref="Node.CallThreadSafe(StringName, ReadOnlySpan{Variant})" />
    public Variant CallThreadSafe(StringName @method, ReadOnlySpan<Variant> @args) => ((Node)_host).CallThreadSafe(@method, @args);

    /// <inheritdoc cref="Node.SetThreadSafe(StringName, Variant)" />
    public void SetThreadSafe(StringName @property, Variant @value) => ((Node)_host).SetThreadSafe(@property, @value);

    /// <inheritdoc cref="Node.NotifyThreadSafe(int)" />
    public void NotifyThreadSafe(int @what) => ((Node)_host).NotifyThreadSafe(@what);

    /// <inheritdoc cref="Node.GetRpcConfig()" />
    public Variant GetRpcConfig() => ((Node)_host).GetRpcConfig();

    /// <inheritdoc cref="Node.SetName(string)" />
    public void SetName(string @name) => ((Node)_host).SetName(@name);

}
