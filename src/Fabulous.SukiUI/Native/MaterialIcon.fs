namespace Fabulous.SukiUI.Native

open Fabulous
open Fabulous.Avalonia
open Fabulous.StackAllocatedCollections.StackList
open Material.Icons.Avalonia

type IFabMaterialIcon =
    inherit IFabTemplatedControl

module MaterialIcon =
    let WidgetKey = Widgets.register<MaterialIcon> ()

    let Kind = Attributes.defineAvaloniaPropertyWithEquality MaterialIcon.KindProperty

    let Width = Attributes.defineAvaloniaPropertyWithEquality MaterialIcon.WidthProperty

    let Height =
        Attributes.defineAvaloniaPropertyWithEquality MaterialIcon.HeightProperty

    let Foreground =
        Attributes.defineAvaloniaPropertyWidget MaterialIcon.ForegroundProperty


[<AutoOpen>]
module MaterialIconBuilders =
    type View with

        static member inline MaterialIcon(kind, width, height, foreground: WidgetBuilder<'msg, #IFabBrush>) =
            WidgetBuilder<'msg, IFabMaterialIcon>(
                MaterialIcon.WidgetKey,
                AttributesBundle(
                    StackList.three (
                        MaterialIcon.Kind.WithValue(kind),
                        MaterialIcon.Width.WithValue(width),
                        MaterialIcon.Height.WithValue(height)
                    ),
                    ValueSome [| MaterialIcon.Foreground.WithValue(foreground.Compile()) |],
                    ValueNone
                )
            )
