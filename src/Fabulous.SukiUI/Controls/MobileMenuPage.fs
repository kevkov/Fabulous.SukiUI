namespace Fabulous.SukiUI.Controls

open Avalonia.Layout
open Fabulous.SukiUI.Native
open Avalonia.Media
open Fabulous.Avalonia
open Avalonia
open type View
open Extensions

[<AutoOpen>]
module MobileMenuPage =

    let MobileMenuPage (index:int) increment =
        let icon = MaterialIcon(enum<Material.Icons.MaterialIconKind> index)
                        .height(35.)
                        .width(35.)
                        .foregroundStyle("SukiText")
        let pane () =
            Grid() {
               (Canvas() {
                    Border(
                        (VStack() {
                            Button(Grid () { icon }, increment)
                                .classes("Accent")
                                .horizontalAlignment(HorizontalAlignment.Right)
                                .margin(Thickness(0,5,25,0))
                            TextBlock(string index).foreground(SolidColorBrush(Colors.Green))
                        })
                            .margin(Thickness(-20,0,0,0.))
                    )
                        .borderThickness(0., 0., 1., 0.)
                        .borderBrushStyle("SukiBorderBrush")
                })
                    .backgroundStyle("SukiBackground")
            }
            
        let content () =
            TextBlock("World")

        View.SplitView(pane(), content())
            .compactPaneLength(0)
            .displayMode(Avalonia.Controls.SplitViewDisplayMode.CompactOverlay)
            .isPaneOpen(true)
            .openPaneLength(316.)
            .useLightDismissOverlayMode(true)

