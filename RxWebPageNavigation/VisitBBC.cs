﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RxWebPageNavigation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VisitBBC recording.
    /// </summary>
    [TestModule("e379dc76-48d2-41a4-9e2f-64e5d386c449", ModuleType.Recording, 1)]
    public partial class VisitBBC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RxWebPageNavigationRepository repository.
        /// </summary>
        public static RxWebPageNavigationRepository repo = RxWebPageNavigationRepository.Instance;

        static VisitBBC instance = new VisitBBC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VisitBBC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VisitBBC Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.bbc.com' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("http://www.bbc.com", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBCHomeInternetExplorer.AskMeLater' at 86;20.", repo.BBCHomeInternetExplorer.AskMeLaterInfo, new RecordItemIndex(1));
            //repo.BBCHomeInternetExplorer.AskMeLater.Click("86;20");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Welcome to the BBC') on item 'BBCHome.WelcomeToTheBBC'.", repo.BBCHome.WelcomeToTheBBCInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.BBCHome.WelcomeToTheBBCInfo, "InnerText", "Welcome to the BBC");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=1220,Height=42}) on item 'BBCHome.WelcomeToTheBBC'.", repo.BBCHome.WelcomeToTheBBCInfo, new RecordItemIndex(3));
            Validate.ContainsImage(repo.BBCHome.WelcomeToTheBBCInfo, WelcomeToTheBBC_Screenshot1, WelcomeToTheBBC_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='News') on item 'BBCHome.News'.", repo.BBCHome.NewsInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.BBCHome.NewsInfo, "InnerText", "News");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.bbc.co.uk/news') on item 'BBCHome.News'.", repo.BBCHome.NewsInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.BBCHome.NewsInfo, "Href", "https://www.bbc.co.uk/news");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=72,Height=48}) on item 'BBCHome.News'.", repo.BBCHome.NewsInfo, new RecordItemIndex(6));
            //Validate.ContainsImage(repo.BBCHome.NewsInfo, News_Screenshot1, News_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Homepage') on item 'BBCHome.Homepage'.", repo.BBCHome.HomepageInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.BBCHome.HomepageInfo, "InnerText", "Homepage");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.bbc.co.uk/') on item 'BBCHome.Homepage'.", repo.BBCHome.HomepageInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.BBCHome.HomepageInfo, "Href", "https://www.bbc.co.uk/");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=105,Height=30}) on item 'BBCHome.Homepage'.", repo.BBCHome.HomepageInfo, new RecordItemIndex(9));
            Validate.ContainsImage(repo.BBCHome.HomepageInfo, Homepage_Screenshot1, Homepage_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBCHome.Homepage' at 63;17.", repo.BBCHome.HomepageInfo, new RecordItemIndex(10));
            repo.BBCHome.Homepage.Click("63;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBCHomeInternetExplorer.ClientCaption' at 1890;18.", repo.BBCHomeInternetExplorer.ClientCaptionInfo, new RecordItemIndex(11));
            repo.BBCHomeInternetExplorer.ClientCaption.Click("1890;18");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage WelcomeToTheBBC_Screenshot1
        { get { return repo.BBCHome.WelcomeToTheBBCInfo.GetScreenshot1(new Rectangle(0, 0, 1220, 42)); } }

        Imaging.FindOptions WelcomeToTheBBC_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage News_Screenshot1
        { get { return repo.BBCHome.NewsInfo.GetScreenshot1(new Rectangle(0, 0, 72, 48)); } }

        Imaging.FindOptions News_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Homepage_Screenshot1
        { get { return repo.BBCHome.HomepageInfo.GetScreenshot1(new Rectangle(0, 0, 105, 30)); } }

        Imaging.FindOptions Homepage_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
