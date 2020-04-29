// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CoronaBunker
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel numDays { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider peopleInHome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel peopleInHomeLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel peopleInHomeNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider rollsInStorage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel rollsInStorageLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel rollsInStorageNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sheetsPerRoll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sheetsPerRollLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sheetsPerRollNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sheetsPerWipe { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sheetsPerWipeLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sheetsPerWipeNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider visitsPerDay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel visitsPerDayLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel visitsPerDayNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider wipesPerTrip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel wipesPerTripLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel wipesPerTripNum { get; set; }

        [Action ("peopleInHome_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void peopleInHome_Changed (UIKit.UISlider sender);

        [Action ("rollsInStorage_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void rollsInStorage_Changed (UIKit.UISlider sender);

        [Action ("sheetsPerRoll_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void sheetsPerRoll_Changed (UIKit.UISlider sender);

        [Action ("sheetsPerWipe_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void sheetsPerWipe_Changed (UIKit.UISlider sender);

        [Action ("visitsPerDay_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void visitsPerDay_Changed (UIKit.UISlider sender);

        [Action ("wipesPerTrip_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void wipesPerTrip_Changed (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (numDays != null) {
                numDays.Dispose ();
                numDays = null;
            }

            if (peopleInHome != null) {
                peopleInHome.Dispose ();
                peopleInHome = null;
            }

            if (peopleInHomeLbl != null) {
                peopleInHomeLbl.Dispose ();
                peopleInHomeLbl = null;
            }

            if (peopleInHomeNum != null) {
                peopleInHomeNum.Dispose ();
                peopleInHomeNum = null;
            }

            if (rollsInStorage != null) {
                rollsInStorage.Dispose ();
                rollsInStorage = null;
            }

            if (rollsInStorageLbl != null) {
                rollsInStorageLbl.Dispose ();
                rollsInStorageLbl = null;
            }

            if (rollsInStorageNum != null) {
                rollsInStorageNum.Dispose ();
                rollsInStorageNum = null;
            }

            if (sheetsPerRoll != null) {
                sheetsPerRoll.Dispose ();
                sheetsPerRoll = null;
            }

            if (sheetsPerRollLbl != null) {
                sheetsPerRollLbl.Dispose ();
                sheetsPerRollLbl = null;
            }

            if (sheetsPerRollNum != null) {
                sheetsPerRollNum.Dispose ();
                sheetsPerRollNum = null;
            }

            if (sheetsPerWipe != null) {
                sheetsPerWipe.Dispose ();
                sheetsPerWipe = null;
            }

            if (sheetsPerWipeLbl != null) {
                sheetsPerWipeLbl.Dispose ();
                sheetsPerWipeLbl = null;
            }

            if (sheetsPerWipeNum != null) {
                sheetsPerWipeNum.Dispose ();
                sheetsPerWipeNum = null;
            }

            if (visitsPerDay != null) {
                visitsPerDay.Dispose ();
                visitsPerDay = null;
            }

            if (visitsPerDayLbl != null) {
                visitsPerDayLbl.Dispose ();
                visitsPerDayLbl = null;
            }

            if (visitsPerDayNum != null) {
                visitsPerDayNum.Dispose ();
                visitsPerDayNum = null;
            }

            if (wipesPerTrip != null) {
                wipesPerTrip.Dispose ();
                wipesPerTrip = null;
            }

            if (wipesPerTripLbl != null) {
                wipesPerTripLbl.Dispose ();
                wipesPerTripLbl = null;
            }

            if (wipesPerTripNum != null) {
                wipesPerTripNum.Dispose ();
                wipesPerTripNum = null;
            }
        }
    }
}