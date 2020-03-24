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

namespace RxDatabase
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RanorexSiteVisit recording.
    /// </summary>
    [TestModule("39a2b104-3a0e-4999-be86-20cfec731dac", ModuleType.Recording, 1)]
    public partial class RanorexSiteVisit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RxDatabaseRepository repository.
        /// </summary>
        public static RxDatabaseRepository repo = RxDatabaseRepository.Instance;

        static RanorexSiteVisit instance = new RanorexSiteVisit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RanorexSiteVisit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RanorexSiteVisit Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.ranorex.com' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("http://www.ranorex.com", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://www.ranorex.com/app/themes/rx-sage/dist/images/logos/rx-header-logo-desktop_5e6a8079.svg') on item 'TestAutomationForGUITestingRanore.RanorexLogo'.", repo.TestAutomationForGUITestingRanore.RanorexLogoInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.TestAutomationForGUITestingRanore.RanorexLogoInfo, "Src", "https://www.ranorex.com/app/themes/rx-sage/dist/images/logos/rx-header-logo-desktop_5e6a8079.svg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Test Automation for All') on item 'TestAutomationForGUITestingRanore.TestAutomationForAll'.", repo.TestAutomationForGUITestingRanore.TestAutomationForAllInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.TestAutomationForGUITestingRanore.TestAutomationForAllInfo, "InnerText", "Test Automation for All");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TestAutomationForGUITestingRanore.PRODUCTS'.", repo.TestAutomationForGUITestingRanore.PRODUCTSInfo, new RecordItemIndex(3));
            Validate.Exists(repo.TestAutomationForGUITestingRanore.PRODUCTSInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='SOLUTIONS') on item 'TestAutomationForGUITestingRanore.SOLUTIONS'.", repo.TestAutomationForGUITestingRanore.SOLUTIONSInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.TestAutomationForGUITestingRanore.SOLUTIONSInfo, "InnerText", "SOLUTIONS");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
