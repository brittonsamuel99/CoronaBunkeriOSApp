using Foundation;
using System;
using UIKit;

namespace CoronaBunker
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void sheetsPerRoll_Changed(UISlider sender)
        {
            var temp = Convert.ToUInt32(sheetsPerRoll.Value);
            sheetsPerRollNum.Text = temp.ToString();
            Updater();
        }

        partial void rollsInStorage_Changed(UISlider sender)
        {
            var temp = Convert.ToInt32(rollsInStorage.Value);
            rollsInStorageNum.Text = temp.ToString();
            Updater();
        }

        partial void visitsPerDay_Changed(UISlider sender)
        {
            var temp = Convert.ToInt32(visitsPerDay.Value);
            visitsPerDayNum.Text = temp.ToString();
            Updater();
        }

        partial void sheetsPerWipe_Changed(UISlider sender)
        {
            var temp = Convert.ToInt32(sheetsPerWipe.Value);
            sheetsPerWipeNum.Text = temp.ToString();
            Updater();
        }

        partial void wipesPerTrip_Changed(UISlider sender)
        {
            var temp = Convert.ToInt32(wipesPerTrip.Value);
            wipesPerTripNum.Text = temp.ToString();
            Updater();
        }

        partial void peopleInHome_Changed(UISlider sender)
        {
            var temp = Convert.ToInt32(peopleInHome.Value);
            peopleInHomeNum.Text = temp.ToString();
            Updater();
        }

        void Updater()
        {
            var spr = Convert.ToUInt32(sheetsPerRoll.Value);
            var ris = Convert.ToInt32(rollsInStorage.Value);
            var vpd = Convert.ToInt32(visitsPerDay.Value);
            var spw = Convert.ToInt32(sheetsPerWipe.Value);
            var wpt = Convert.ToInt32(wipesPerTrip.Value);
            var pih = Convert.ToInt32(peopleInHome.Value);

            var sheetsPerDay = vpd * spw * wpt * pih;
            var sheetsInStorage = spr * ris;

            var days = sheetsInStorage / sheetsPerDay;

            numDays.Text = days.ToString();
        }

    }
}