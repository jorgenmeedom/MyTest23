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

namespace MyTest23
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenBrowser recording.
    /// </summary>
    [TestModule("779835c7-e0e8-4d4e-b1ea-f6c59f268722", ModuleType.Recording, 1)]
    public partial class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest23Repository repository.
        /// </summary>
        public static MyTest23Repository repo = MyTest23Repository.Instance;

        static OpenBrowser instance = new OpenBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://localhost' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://localhost", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(1));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}' with focus on 'WordPressInstallation'.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(2));
            repo.WordPressInstallation.Self.EnsureVisible();
            Keyboard.Press("{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation.LanguageContinue' at 67;21.", repo.WordPressInstallation.LanguageContinueInfo, new RecordItemIndex(3));
            repo.WordPressInstallation.LanguageContinue.Click("67;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'meedom{Tab}jmeedom{Tab}' with focus on 'WordPressInstallation'.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(4));
            repo.WordPressInstallation.Self.EnsureVisible();
            Keyboard.Press("meedom{Tab}jmeedom{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'cicero1000' with focus on 'WordPressInstallation'.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(5));
            repo.WordPressInstallation.Self.EnsureVisible();
            Keyboard.Press("cicero1000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'WordPressInstallation'.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(6));
            repo.WordPressInstallation.Self.EnsureVisible();
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation.Setup.PwWeak' at 19;10.", repo.WordPressInstallation.Setup.PwWeakInfo, new RecordItemIndex(7));
            repo.WordPressInstallation.Setup.PwWeak.Click("19;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation.AdminEmail' at 66;29.", repo.WordPressInstallation.AdminEmailInfo, new RecordItemIndex(8));
            repo.WordPressInstallation.AdminEmail.Click("66;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'jorgen' with focus on 'WordPressInstallation.AdminEmail'.", repo.WordPressInstallation.AdminEmailInfo, new RecordItemIndex(9));
            repo.WordPressInstallation.AdminEmail.PressKeys("jorgen");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{RMenu down}{D2}{LControlKey up}{RMenu up}{LControlKey up}meedom.com' with focus on 'WordPressInstallation.AdminEmail'.", repo.WordPressInstallation.AdminEmailInfo, new RecordItemIndex(10));
            repo.WordPressInstallation.AdminEmail.PressKeys("{LControlKey down}{RMenu down}{D2}{LControlKey up}{RMenu up}{LControlKey up}meedom.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation.Submit' at 112;23.", repo.WordPressInstallation.SubmitInfo, new RecordItemIndex(11));
            repo.WordPressInstallation.Submit.Click("112;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(12));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation' at 460;608.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(13));
            repo.WordPressInstallation.Self.Click("460;608");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(14));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'jmeedom' with focus on 'WordPressInstallation'.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(15));
            repo.WordPressInstallation.Self.EnsureVisible();
            Keyboard.Press("jmeedom");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation' at 817;541.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(16));
            repo.WordPressInstallation.Self.Click("817;541");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'cicero1000' with focus on 'WordPressInstallation'.", repo.WordPressInstallation.SelfInfo, new RecordItemIndex(17));
            repo.WordPressInstallation.Self.EnsureVisible();
            Keyboard.Press("cicero1000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WordPressInstallation.WpSubmit' at 38;26.", repo.WordPressInstallation.WpSubmitInfo, new RecordItemIndex(18));
            repo.WordPressInstallation.WpSubmit.Click("38;26");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
