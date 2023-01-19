namespace Fabulous.SukiUI.Native

open Fabulous
open Fabulous.Avalonia
open Fabulous.StackAllocatedCollections.StackList
open SukiUI.Controls

type IFabMobileMenuPage = inherit IFabUserControl

module MobileMenuPage =
    let WidgetKey = Widgets.register<MobileMenuPage> ()

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