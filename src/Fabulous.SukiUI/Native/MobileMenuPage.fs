namespace Fabulous.SukiUI.Native

open Fabulous
open Fabulous.Avalonia
open Fabulous.StackAllocatedCollections.StackList

type IFabMobileMenuPage = inherit IFabUserControl

module MobileMenuPage =
    let WidgetKey = Widgets.register<SukiUI.Controls.MobileMenuPage> ()

[<AutoOpen>]
module MobileMenuPageBuilders =
    type View with

        static member inline MobileMenuPage() =
            WidgetBuilder<'msg, IFabMobileMenuPage>(
                MobileMenuPage.WidgetKey,
                AttributesBundle(
                    StackList.empty (),
                    ValueSome [| |],
                    ValueNone
                )
            )