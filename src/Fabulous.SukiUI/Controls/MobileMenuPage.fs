namespace Fabulous.SukiUI.Controls

open Fabulous.SukiUI.Native
open Avalonia.Media
open Fabulous.Avalonia
open type View

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
                            TextBlock(string index).foreground(SolidColorBrush(Colors.Green))
                        }
                    )
                        .borderBrush(SolidColorBrush(Color.Parse("#454545")))
                        .borderThickness(0., 0., 1., 0.)
                })
                    .background(SolidColorBrush(Color.Parse("#333333")))
                    
            }
            
        let content () =
            TextBlock("World")

        View.SplitView(pane(), content())
            .compactPaneLength(0)
            .displayMode(Avalonia.Controls.SplitViewDisplayMode.CompactOverlay)
            .isPaneOpen(true)
            .openPaneLength(316.)
            .useLightDismissOverlayMode(true)

