module Main

// Entry point must be in a separate file
// for Vite Hot Reload to work

open Feliz
open Browser
open Fable.React
open Fable.Core.JsInterop

importSideEffects "./styles.css"

ReactDomClient.createRoot(document.getElementById("root")).render(
    React.StrictMode [
        App.AppComponent()
        |> Util.toReact
    ]
)
