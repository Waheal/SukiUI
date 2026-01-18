using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using SukiUI.Enums;

namespace SukiUI.Controls;

[TemplatePart("PART_Root", typeof(Panel))]
[TemplatePart("PART_VisualLayerManager", typeof(VisualLayerManager))]
public class SukiMainHost : ContentControl
{

    public static readonly StyledProperty<Avalonia.Controls.Controls> HostsProperty =
        AvaloniaProperty.Register<SukiMainHost, Avalonia.Controls.Controls>(nameof(Hosts));

    /// <summary>
    /// These controls are displayed above all others and fill the entire window.
    /// You can include <see cref="SukiDialogHost"/> and <see cref="SukiToastHost"/> or create your own custom implementations.
    /// </summary>
    public Avalonia.Controls.Controls Hosts
    {
        get => GetValue(HostsProperty);
        set => SetValue(HostsProperty, value);
    }

    public SukiMainHost()
    {
        Hosts = [];
    }
}