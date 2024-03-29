namespace CounterApp

open Avalonia
open Fabulous
open Fabulous.Avalonia
open Fabulous.Avalonia.SukiUI.Theme
open Fabulous.SukiUI.Controls
open Fabulous.Avalonia;

open type Fabulous.Avalonia.View

module App =
    type Model =
        { Count: int; Step: int; TimerOn: bool }

    type Msg =
        | Increment
        | Decrement
        | Reset
        | SetStep of float
        | TimerToggled of bool
        | TimedTick

    let initModel = { Count = 1674; Step = 1; TimerOn = false }

    let timerCmd () =
        async {
            do! Async.Sleep 200
            return TimedTick
        }
        |> Cmd.ofAsyncMsg

    let init () = initModel, Cmd.none

    let update msg model =
        match msg with
        | Increment ->
            if model.Count % 2 = 0 then ColorTheme.LoadDarkTheme(Application.Current) else ColorTheme.LoadLightTheme(Application.Current)
            { model with Count = model.Count + model.Step }, Cmd.none
        | Decrement -> { model with Count = model.Count - model.Step }, Cmd.none
        | Reset -> initModel, Cmd.none
        | SetStep n -> { model with Step = int (n + 0.5) }, Cmd.none
        | TimerToggled on -> { model with TimerOn = on }, (if on then timerCmd () else Cmd.none)
        | TimedTick ->
            if model.TimerOn then
                { model with Count = model.Count + model.Step }, timerCmd ()
            else
                model, Cmd.none

    let view model =
        let x = MobileMenuPage model.Count Increment
        x

#if MOBILE
    let app model = SingleViewApplication(view model)
#else
    let app model = DesktopApplication(Window(view model))
#endif

    let program = Program.statefulWithCmd init update app
