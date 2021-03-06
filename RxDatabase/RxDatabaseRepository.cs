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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RxDatabase
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RxDatabaseRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
    [RepositoryFolder("089d70a2-1de7-4a76-aa26-3b3526e92fdc")]
    public partial class RxDatabaseRepository : RepoGenBaseFolder
    {
        static RxDatabaseRepository instance = new RxDatabaseRepository();
        RxDatabaseRepositoryFolders.ExplorerAppFolder _explorer;
        RxDatabaseRepositoryFolders.MicrosoftEdgeAppFolder _microsoftedge;
        RxDatabaseRepositoryFolders.GmailAppFolder _gmail;
        RxDatabaseRepositoryFolders.GmailInternetExplorerAppFolder _gmailinternetexplorer;
        RxDatabaseRepositoryFolders.TestAutomationForGUITestingRanoreAppFolder _testautomationforguitestingranore;
        RxDatabaseRepositoryFolders.TestAutomationForGUITestingRanore1AppFolder _testautomationforguitestingranore1;

        /// <summary>
        /// Gets the singleton class instance representing the RxDatabaseRepository element repository.
        /// </summary>
        [RepositoryFolder("089d70a2-1de7-4a76-aa26-3b3526e92fdc")]
        public static RxDatabaseRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RxDatabaseRepository() 
            : base("RxDatabaseRepository", "/", null, 0, false, "089d70a2-1de7-4a76-aa26-3b3526e92fdc", ".\\RepositoryImages\\RxDatabaseRepository089d70a2.rximgres")
        {
            _explorer = new RxDatabaseRepositoryFolders.ExplorerAppFolder(this);
            _microsoftedge = new RxDatabaseRepositoryFolders.MicrosoftEdgeAppFolder(this);
            _gmail = new RxDatabaseRepositoryFolders.GmailAppFolder(this);
            _gmailinternetexplorer = new RxDatabaseRepositoryFolders.GmailInternetExplorerAppFolder(this);
            _testautomationforguitestingranore = new RxDatabaseRepositoryFolders.TestAutomationForGUITestingRanoreAppFolder(this);
            _testautomationforguitestingranore1 = new RxDatabaseRepositoryFolders.TestAutomationForGUITestingRanore1AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("089d70a2-1de7-4a76-aa26-3b3526e92fdc")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("fd2f9a4d-a8e3-41a0-8cc9-acec5d1b6c1e")]
        public virtual RxDatabaseRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The MicrosoftEdge folder.
        /// </summary>
        [RepositoryFolder("2b209ab6-7d6d-4d6d-91a4-7be781f759e8")]
        public virtual RxDatabaseRepositoryFolders.MicrosoftEdgeAppFolder MicrosoftEdge
        {
            get { return _microsoftedge; }
        }

        /// <summary>
        /// The Gmail folder.
        /// </summary>
        [RepositoryFolder("7c09c86d-dd84-446b-9ec9-7d4581139632")]
        public virtual RxDatabaseRepositoryFolders.GmailAppFolder Gmail
        {
            get { return _gmail; }
        }

        /// <summary>
        /// The GmailInternetExplorer folder.
        /// </summary>
        [RepositoryFolder("88ac63a2-9c6d-4ca8-a965-748ae63e5ca7")]
        public virtual RxDatabaseRepositoryFolders.GmailInternetExplorerAppFolder GmailInternetExplorer
        {
            get { return _gmailinternetexplorer; }
        }

        /// <summary>
        /// The TestAutomationForGUITestingRanore folder.
        /// </summary>
        [RepositoryFolder("df4b791d-6644-4d05-b297-0b8f692e81e1")]
        public virtual RxDatabaseRepositoryFolders.TestAutomationForGUITestingRanoreAppFolder TestAutomationForGUITestingRanore
        {
            get { return _testautomationforguitestingranore; }
        }

        /// <summary>
        /// The TestAutomationForGUITestingRanore1 folder.
        /// </summary>
        [RepositoryFolder("56e22e21-4297-4d29-aad3-8729ad41d9bc")]
        public virtual RxDatabaseRepositoryFolders.TestAutomationForGUITestingRanore1AppFolder TestAutomationForGUITestingRanore1
        {
            get { return _testautomationforguitestingranore1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
    public partial class RxDatabaseRepositoryFolders
    {
        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("fd2f9a4d-a8e3-41a0-8cc9-acec5d1b6c1e")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _microsoftedge1runningwindowInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "fd2f9a4d-a8e3-41a0-8cc9-acec5d1b6c1e", "")
            {
                _microsoftedge1runningwindowInfo = new RepoItemInfo(this, "MicrosoftEdge1RunningWindow", "container[@controlid='40965']//toolbar[@accessiblename='Running applications']/button[12]", 30000, null, "70c0aca9-e2f7-4cb0-8c4b-bf808008cf68");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fd2f9a4d-a8e3-41a0-8cc9-acec5d1b6c1e")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("fd2f9a4d-a8e3-41a0-8cc9-acec5d1b6c1e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MicrosoftEdge1RunningWindow item.
            /// </summary>
            [RepositoryItem("70c0aca9-e2f7-4cb0-8c4b-bf808008cf68")]
            public virtual Ranorex.Button MicrosoftEdge1RunningWindow
            {
                get
                {
                    return _microsoftedge1runningwindowInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MicrosoftEdge1RunningWindow item info.
            /// </summary>
            [RepositoryItemInfo("70c0aca9-e2f7-4cb0-8c4b-bf808008cf68")]
            public virtual RepoItemInfo MicrosoftEdge1RunningWindowInfo
            {
                get
                {
                    return _microsoftedge1runningwindowInfo;
                }
            }
        }

        /// <summary>
        /// The MicrosoftEdgeAppFolder folder.
        /// </summary>
        [RepositoryFolder("2b209ab6-7d6d-4d6d-91a4-7be781f759e8")]
        public partial class MicrosoftEdgeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _minimizeInfo;

            /// <summary>
            /// Creates a new MicrosoftEdge  folder.
            /// </summary>
            public MicrosoftEdgeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MicrosoftEdge", "/winapp[@appid='MicrosoftEdge' and @name='Microsoft Edge']", parentFolder, 30000, null, true, "2b209ab6-7d6d-4d6d-91a4-7be781f759e8", "")
            {
                _minimizeInfo = new RepoItemInfo(this, "Minimize", "?/?/button[@automationid='Minimize']", 30000, null, "37cf9151-3fc0-4893-84b6-cd1130ab4296");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2b209ab6-7d6d-4d6d-91a4-7be781f759e8")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2b209ab6-7d6d-4d6d-91a4-7be781f759e8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Minimize item.
            /// </summary>
            [RepositoryItem("37cf9151-3fc0-4893-84b6-cd1130ab4296")]
            public virtual Ranorex.Button Minimize
            {
                get
                {
                    return _minimizeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Minimize item info.
            /// </summary>
            [RepositoryItemInfo("37cf9151-3fc0-4893-84b6-cd1130ab4296")]
            public virtual RepoItemInfo MinimizeInfo
            {
                get
                {
                    return _minimizeInfo;
                }
            }
        }

        /// <summary>
        /// The GmailAppFolder folder.
        /// </summary>
        [RepositoryFolder("7c09c86d-dd84-446b-9ec9-7d4581139632")]
        public partial class GmailAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _identifieridInfo;
            RepoItemInfo _zfr60dceorycInfo;
            RepoItemInfo _nextInfo;
            RepoItemInfo _passwordInfo;

            /// <summary>
            /// Creates a new Gmail  folder.
            /// </summary>
            public GmailAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Gmail", "/dom[@domain='accounts.google.com']", parentFolder, 30000, null, false, "7c09c86d-dd84-446b-9ec9-7d4581139632", "")
            {
                _identifieridInfo = new RepoItemInfo(this, "IdentifierId", ".//input[#'identifierId']", 30000, null, "13ee4911-b41b-4503-9aff-50208004bc03");
                _zfr60dceorycInfo = new RepoItemInfo(this, "ZFr60dCeoRYc", ".//div[#'identifierNext']/div[2]", 30000, null, "5ad804b7-8a2f-4e34-a0eb-85c4bb4296fc");
                _nextInfo = new RepoItemInfo(this, "Next", ".//div[#'identifierNext']/?/?/span[@innertext='Next']", 30000, null, "ebb71b99-c7db-422d-b8bf-87639345a762");
                _passwordInfo = new RepoItemInfo(this, "Password", ".//div[#'password']/div[1]/div/div[1]/input[@name='password']", 30000, null, "f1ea55fe-b920-49af-8956-594bf5f4eb84");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7c09c86d-dd84-446b-9ec9-7d4581139632")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7c09c86d-dd84-446b-9ec9-7d4581139632")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The IdentifierId item.
            /// </summary>
            [RepositoryItem("13ee4911-b41b-4503-9aff-50208004bc03")]
            public virtual Ranorex.InputTag IdentifierId
            {
                get
                {
                    return _identifieridInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The IdentifierId item info.
            /// </summary>
            [RepositoryItemInfo("13ee4911-b41b-4503-9aff-50208004bc03")]
            public virtual RepoItemInfo IdentifierIdInfo
            {
                get
                {
                    return _identifieridInfo;
                }
            }

            /// <summary>
            /// The ZFr60dCeoRYc item.
            /// </summary>
            [RepositoryItem("5ad804b7-8a2f-4e34-a0eb-85c4bb4296fc")]
            public virtual Ranorex.DivTag ZFr60dCeoRYc
            {
                get
                {
                    return _zfr60dceorycInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The ZFr60dCeoRYc item info.
            /// </summary>
            [RepositoryItemInfo("5ad804b7-8a2f-4e34-a0eb-85c4bb4296fc")]
            public virtual RepoItemInfo ZFr60dCeoRYcInfo
            {
                get
                {
                    return _zfr60dceorycInfo;
                }
            }

            /// <summary>
            /// The Next item.
            /// </summary>
            [RepositoryItem("ebb71b99-c7db-422d-b8bf-87639345a762")]
            public virtual Ranorex.SpanTag Next
            {
                get
                {
                    return _nextInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Next item info.
            /// </summary>
            [RepositoryItemInfo("ebb71b99-c7db-422d-b8bf-87639345a762")]
            public virtual RepoItemInfo NextInfo
            {
                get
                {
                    return _nextInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("f1ea55fe-b920-49af-8956-594bf5f4eb84")]
            public virtual Ranorex.InputTag Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("f1ea55fe-b920-49af-8956-594bf5f4eb84")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }
        }

        /// <summary>
        /// The GmailInternetExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("88ac63a2-9c6d-4ca8-a965-748ae63e5ca7")]
        public partial class GmailInternetExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _askmelaterInfo;

            /// <summary>
            /// Creates a new GmailInternetExplorer  folder.
            /// </summary>
            public GmailInternetExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("GmailInternetExplorer", "/form[@title='Gmail - Internet Explorer']", parentFolder, 30000, null, true, "88ac63a2-9c6d-4ca8-a965-748ae63e5ca7", "")
            {
                _askmelaterInfo = new RepoItemInfo(this, "AskMeLater", ".//toolbar[@accessiblename='Notification']/button[@accessiblename='Ask me later']", 30000, null, "0a478991-bd62-4931-be24-d87f7f5d80ab");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("88ac63a2-9c6d-4ca8-a965-748ae63e5ca7")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("88ac63a2-9c6d-4ca8-a965-748ae63e5ca7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AskMeLater item.
            /// </summary>
            [RepositoryItem("0a478991-bd62-4931-be24-d87f7f5d80ab")]
            public virtual Ranorex.Button AskMeLater
            {
                get
                {
                    return _askmelaterInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The AskMeLater item info.
            /// </summary>
            [RepositoryItemInfo("0a478991-bd62-4931-be24-d87f7f5d80ab")]
            public virtual RepoItemInfo AskMeLaterInfo
            {
                get
                {
                    return _askmelaterInfo;
                }
            }
        }

        /// <summary>
        /// The TestAutomationForGUITestingRanoreAppFolder folder.
        /// </summary>
        [RepositoryFolder("df4b791d-6644-4d05-b297-0b8f692e81e1")]
        public partial class TestAutomationForGUITestingRanoreAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _ranorexlogoInfo;
            RepoItemInfo _testautomationforallInfo;
            RepoItemInfo _productsInfo;
            RepoItemInfo _solutionsInfo;
            RepoItemInfo _supportInfo;
            RepoItemInfo _companyInfo;
            WhatsNewInfoClass _whatsnewInfo;

            /// <summary>
            /// Creates a new TestAutomationForGUITestingRanore  folder.
            /// </summary>
            public TestAutomationForGUITestingRanoreAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TestAutomationForGUITestingRanore", "/dom[@caption~'^Test\\ Automation\\ for\\ GUI\\ T']", parentFolder, 30000, null, false, "df4b791d-6644-4d05-b297-0b8f692e81e1", "")
            {
                _ranorexlogoInfo = new RepoItemInfo(this, "RanorexLogo", ".//div[#'rx-header-sticky-content-wrapper']//img[@alt='Ranorex Logo']", 30000, null, "2352a1c6-0568-497c-b74a-978bc53004ae");
                _testautomationforallInfo = new RepoItemInfo(this, "TestAutomationForAll", ".//div[#'et_builder_outer_content']/div/div[1]/div/div/div/?/?/h1[@innertext='Test Automation for All']", 30000, null, "7331b024-1501-4ffd-954e-905b06b104f7");
                _productsInfo = new RepoItemInfo(this, "PRODUCTS", ".//li[#'productMenuButton']/span[@innertext='PRODUCTS']", 30000, null, "de0a6c2f-dd78-420e-9cfe-abf140c8d574");
                _solutionsInfo = new RepoItemInfo(this, "SOLUTIONS", ".//li[#'solutionMenuButton']/span[@innertext='SOLUTIONS']", 30000, null, "0c8bc087-f051-4e5d-97b2-60fcc11cf22b");
                _supportInfo = new RepoItemInfo(this, "SUPPORT", ".//div[#'rx-header-sticky-content-wrapper']//ul/?/?/span[@innertext='SUPPORT']", 30000, null, "60c7ef72-b9b0-4393-b395-a63dd6291ef2");
                _companyInfo = new RepoItemInfo(this, "COMPANY", ".//div[#'rx-header-sticky-content-wrapper']//ul/?/?/span[@innertext='COMPANY']", 30000, null, "8a4cbe68-99cb-40c0-b25c-87ea1a71b07a");
                _whatsnewInfo = new WhatsNewInfoClass(this);
            }

            /// <summary>
            /// The WhatsNewInfoClass folder.
            /// </summary>
            [RepositoryItemInfo("4caef4a8-8ef7-4775-bf39-cddd040d1939")]
            public class WhatsNewInfoClass : RepoItemInfo
            {
                /// <summary>
                /// WhatsNewInfoClass class constructor.
                /// </summary>
                public WhatsNewInfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "WhatsNew", ".//div[#'et_builder_outer_content']/div/div[2]/div/div/div[2]/a[@innertext='What''s new']", 30000, null, "4caef4a8-8ef7-4775-bf39-cddd040d1939")
                { }

                /// <summary>
                /// Gets the Screenshot1 item image.
                /// </summary>
                /// <returns>The Screenshot1 image.</returns>
                [RepositoryImage("f9ba5ba5-8321-433d-8f19-65382e0389a4")]
                public CompressedImage GetScreenshot1()
                {
                    return GetImage("f9ba5ba5-8321-433d-8f19-65382e0389a4");
                }

                /// <summary>
                /// Gets the Screenshot1 item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("f9ba5ba5-8321-433d-8f19-65382e0389a4")]
                public CompressedImage GetScreenshot1(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("f9ba5ba5-8321-433d-8f19-65382e0389a4", cropRect);
                }
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("df4b791d-6644-4d05-b297-0b8f692e81e1")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("df4b791d-6644-4d05-b297-0b8f692e81e1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RanorexLogo item.
            /// </summary>
            [RepositoryItem("2352a1c6-0568-497c-b74a-978bc53004ae")]
            public virtual Ranorex.ImgTag RanorexLogo
            {
                get
                {
                    return _ranorexlogoInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The RanorexLogo item info.
            /// </summary>
            [RepositoryItemInfo("2352a1c6-0568-497c-b74a-978bc53004ae")]
            public virtual RepoItemInfo RanorexLogoInfo
            {
                get
                {
                    return _ranorexlogoInfo;
                }
            }

            /// <summary>
            /// The TestAutomationForAll item.
            /// </summary>
            [RepositoryItem("7331b024-1501-4ffd-954e-905b06b104f7")]
            public virtual Ranorex.H1Tag TestAutomationForAll
            {
                get
                {
                    return _testautomationforallInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The TestAutomationForAll item info.
            /// </summary>
            [RepositoryItemInfo("7331b024-1501-4ffd-954e-905b06b104f7")]
            public virtual RepoItemInfo TestAutomationForAllInfo
            {
                get
                {
                    return _testautomationforallInfo;
                }
            }

            /// <summary>
            /// The PRODUCTS item.
            /// </summary>
            [RepositoryItem("de0a6c2f-dd78-420e-9cfe-abf140c8d574")]
            public virtual Ranorex.SpanTag PRODUCTS
            {
                get
                {
                    return _productsInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The PRODUCTS item info.
            /// </summary>
            [RepositoryItemInfo("de0a6c2f-dd78-420e-9cfe-abf140c8d574")]
            public virtual RepoItemInfo PRODUCTSInfo
            {
                get
                {
                    return _productsInfo;
                }
            }

            /// <summary>
            /// The SOLUTIONS item.
            /// </summary>
            [RepositoryItem("0c8bc087-f051-4e5d-97b2-60fcc11cf22b")]
            public virtual Ranorex.SpanTag SOLUTIONS
            {
                get
                {
                    return _solutionsInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SOLUTIONS item info.
            /// </summary>
            [RepositoryItemInfo("0c8bc087-f051-4e5d-97b2-60fcc11cf22b")]
            public virtual RepoItemInfo SOLUTIONSInfo
            {
                get
                {
                    return _solutionsInfo;
                }
            }

            /// <summary>
            /// The SUPPORT item.
            /// </summary>
            [RepositoryItem("60c7ef72-b9b0-4393-b395-a63dd6291ef2")]
            public virtual Ranorex.SpanTag SUPPORT
            {
                get
                {
                    return _supportInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SUPPORT item info.
            /// </summary>
            [RepositoryItemInfo("60c7ef72-b9b0-4393-b395-a63dd6291ef2")]
            public virtual RepoItemInfo SUPPORTInfo
            {
                get
                {
                    return _supportInfo;
                }
            }

            /// <summary>
            /// The COMPANY item.
            /// </summary>
            [RepositoryItem("8a4cbe68-99cb-40c0-b25c-87ea1a71b07a")]
            public virtual Ranorex.SpanTag COMPANY
            {
                get
                {
                    return _companyInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The COMPANY item info.
            /// </summary>
            [RepositoryItemInfo("8a4cbe68-99cb-40c0-b25c-87ea1a71b07a")]
            public virtual RepoItemInfo COMPANYInfo
            {
                get
                {
                    return _companyInfo;
                }
            }

            /// <summary>
            /// The WhatsNew item.
            /// </summary>
            [RepositoryItem("4caef4a8-8ef7-4775-bf39-cddd040d1939")]
            public virtual Ranorex.ATag WhatsNew
            {
                get
                {
                    return _whatsnewInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The WhatsNew item info.
            /// </summary>
            [RepositoryItemInfo("4caef4a8-8ef7-4775-bf39-cddd040d1939")]
            public virtual WhatsNewInfoClass WhatsNewInfo
            {
                get
                {
                    return _whatsnewInfo;
                }
            }
        }

        /// <summary>
        /// The TestAutomationForGUITestingRanore1AppFolder folder.
        /// </summary>
        [RepositoryFolder("56e22e21-4297-4d29-aad3-8729ad41d9bc")]
        public partial class TestAutomationForGUITestingRanore1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _clientcaptionInfo;

            /// <summary>
            /// Creates a new TestAutomationForGUITestingRanore1  folder.
            /// </summary>
            public TestAutomationForGUITestingRanore1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("TestAutomationForGUITestingRanore1", "/form[@processname='iexplore' and @class='IEFrame' and @instance='1']", parentFolder, 30000, null, true, "56e22e21-4297-4d29-aad3-8729ad41d9bc", "")
            {
                _clientcaptionInfo = new RepoItemInfo(this, "ClientCaption", "element[@class='Client Caption']", 30000, null, "ead21a1d-c5a3-453b-9519-259c8d4c48d5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("56e22e21-4297-4d29-aad3-8729ad41d9bc")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("56e22e21-4297-4d29-aad3-8729ad41d9bc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ClientCaption item.
            /// </summary>
            [RepositoryItem("ead21a1d-c5a3-453b-9519-259c8d4c48d5")]
            public virtual Ranorex.Unknown ClientCaption
            {
                get
                {
                    return _clientcaptionInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The ClientCaption item info.
            /// </summary>
            [RepositoryItemInfo("ead21a1d-c5a3-453b-9519-259c8d4c48d5")]
            public virtual RepoItemInfo ClientCaptionInfo
            {
                get
                {
                    return _clientcaptionInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}