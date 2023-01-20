namespace Fabulous.SukiUI.Controls

open Material.Icons
open Material.Icons.Avalonia
open Avalonia.Media
open Fabulous.Avalonia
open type View

[<AutoOpen>]
module MobileMenuPage =


    let MobileMenuPage (showHideMenu) =
        let icon = MaterialIcon(Kind = MaterialIconKind.ChevronLeft)
        let pane () =
            Grid() {
               (Canvas() {
                    Border(
                        VStack() {
                            Button(Grid() { icon }, showHideMenu)
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

