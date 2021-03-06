﻿using CoreGraphics;
using Moespirit.Xamarin.iOSControls;
using System;
using System.Threading.Tasks;
using UIKit;

namespace App1
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
        public override async void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            await Task.Delay(500);
            CustomIOSAlertView ciav = new CustomIOSAlertView();
            ciav.ContainerView = createDemoView();
            ciav.Show();
        }

        UIView createDemoView()
        {
            UIView demoView = new UIView(new CGRect(0, 0, 290, 200));
            demoView.BackgroundColor = UIColor.Red;
            demoView.AddSubview(new UITextField() { Text = "aaa" ,BackgroundColor=UIColor.White,Frame=new CGRect(new CGPoint(10,10),new CGSize(100,50))});
    return demoView;
}
}
}