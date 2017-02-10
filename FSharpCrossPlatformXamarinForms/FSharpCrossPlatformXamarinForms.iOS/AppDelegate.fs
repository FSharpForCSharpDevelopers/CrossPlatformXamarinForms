namespace FSharpCrossPlatformXamarinForms.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    let window = new UIWindow (UIScreen.MainScreen.Bounds)

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching (app, options) =
        // If you have defined a root view controller, set it here:
        // window.RootViewController <- new MyViewController ()
       do Forms.Init()

       base.FinishedLaunching(app, options)