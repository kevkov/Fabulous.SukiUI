namespace Fabulous.SukiUI.Controls

[<AutoOpen>]
module MobileMenuPage =

    open Fabulous.Avalonia
    open type View

    let MobileMenuPage () =
        let pane () =
            Grid() {
                Canvas() {
                    TextBlock("Hello")
                }
            }
            
        let content () =
            TextBlock("World")

        View.SplitView(pane(), content())
            .compactPaneLength(0)
            .displayMode(Avalonia.Controls.SplitViewDisplayMode.CompactOverlay)
            .isPaneOpen(true)
            .openPaneLength(316.)
            .useLightDismissOverlayMode(true)

