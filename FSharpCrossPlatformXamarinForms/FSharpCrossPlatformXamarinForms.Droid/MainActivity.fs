namespace FSharpCrossPlatformXamarinForms.Droid

open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget
open Xamarin.Forms
open Xamarin.Forms.Platform.Android
open FSharpCrossPlatformXamarinForms

type Resources = FSharpCrossPlatformXamarinForms.Droid.Resource

[<Activity(Label = "XamarinFormsFSharpDemo.Droid", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type MainActivity () =
    inherit FormsAppCompatActivity()

    override this.OnCreate (bundle) =

        FormsAppCompatActivity.TabLayoutResource <- Resources.Layout.Tabbar

        FormsAppCompatActivity.ToolbarResource <- Resources.Layout.Toolbar

        base.OnCreate (bundle)

        Forms.Init(this,bundle)

        base.LoadApplication(new App())