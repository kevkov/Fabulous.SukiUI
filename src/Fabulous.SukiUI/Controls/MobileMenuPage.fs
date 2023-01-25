namespace Fabulous.SukiUI.Controls

open Fabulous.SukiUI.Native
open Avalonia.Media
open Fabulous.Avalonia
open Avalonia
open type View
open Extensions

[<AutoOpen>]
module MobileMenuPage =

    let MobileMenuPage (index:int) increment =
        let icon = MaterialIcon(enum<Material.Icons.MaterialIconKind> index, 48., 48., SolidColorBrush(Colors.Red))
        let pane () =
            Grid() {
               (Canvas() {
                    Border(
                        VStack() {
                            Button(icon, increment)
                                .classes("Accent")
                            TextBlock(string index).foreground(SolidColorBrush(Colors.Green))
                        }
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

