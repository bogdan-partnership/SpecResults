﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

#pragma warning disable

namespace SpecFlow.Reporting.ApprovalTestSuite
{
	using TechTalk.SpecFlow;

	[System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[NUnit.Framework.TestFixtureAttribute()]
	[NUnit.Framework.DescriptionAttribute("Generate reports")]
	public partial class GenerateReportsFeature
	{
		private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "Reporting.feature"
#line hidden

		[NUnit.Framework.TestFixtureSetUpAttribute()]
		public virtual void FeatureSetup()
		{
			testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
			TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Generate reports", "In order to get information about test results\r\nAs a developer\r\nI want to generat" +
					"e reports", ProgrammingLanguage.CSharp, ((string[])(null)));
			testRunner.OnFeatureStart(featureInfo);
		}

		[NUnit.Framework.TestFixtureTearDownAttribute()]
		public virtual void FeatureTearDown()
		{
			testRunner.OnFeatureEnd();
			testRunner = null;
		}

		[NUnit.Framework.SetUpAttribute()]
		public virtual void TestInitialize()
		{
		}

		[NUnit.Framework.TearDownAttribute()]
		public virtual void ScenarioTearDown()
		{
			testRunner.OnScenarioEnd();
		}

		public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
		{
			testRunner.OnScenarioStart(scenarioInfo);
		}

		public virtual void ScenarioCleanup()
		{
			testRunner.CollectScenarioErrors();
		}

		[NUnit.Framework.TestAttribute()]
		[NUnit.Framework.DescriptionAttribute("Single scenario")]
		public virtual void SingleScenario()
		{
			TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single scenario", ((string[])(null)));
#line 6
			this.ScenarioSetup(scenarioInfo);
#line 7
			testRunner.Given("a scenario is specified", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
			testRunner.When("the tests run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
			testRunner.Then("a report is generated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
			this.ScenarioCleanup();
		}
	}
}

#pragma warning restore

#endregion Designer generated code