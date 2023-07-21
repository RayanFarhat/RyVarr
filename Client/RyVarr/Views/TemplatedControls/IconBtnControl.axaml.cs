using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace RyVarr.Views.TemplatedControls;

public class IconBtnControl : TemplatedControl
{
    public static readonly StyledProperty<IImage> SrcProperty =
    AvaloniaProperty.Register<IconBtnControl, IImage>(nameof(Src));

    public IImage Src
    {
        get => GetValue(SrcProperty);
        set => SetValue(SrcProperty, value);
    }

    public static readonly StyledProperty<ICommand> CommandProperty =
    AvaloniaProperty.Register<IconBtnControl, ICommand>(nameof(Command));

    public ICommand Command
    {
        get => GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public static readonly StyledProperty<object?> CommandParameterProperty =
            AvaloniaProperty.Register<IconBtnControl, object?>(nameof(CommandParameter));
    public object? CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public static readonly StyledProperty<int> SizeProperty =
    AvaloniaProperty.Register<IconBtnControl, int>(nameof(Size), defaultValue: 40);

    public int Size
    {
        get => GetValue(SizeProperty);
        set => SetValue(SizeProperty, value);
    }

}
