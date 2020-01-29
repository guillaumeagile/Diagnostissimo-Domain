using System;
using Doctissimo.Domain.Regles;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Doctissimo.Domain.SpecFlowNUnit
{
    [Binding]
    public class StepDefinitions
    {

        Courriel courrier;
        
        [When(@"le courrier est généré")]
        public void CourrierGeneration()
        {
             courrier = new Courriel();
           // TechTalk.SpecFlow.CurrentScenario.Add("sut", courrier);
        }

        [Then(@"le courier a pour sujet '(.*)'")]
        public void VerifCourrierSujet(string sujet)
        {
          //  var courrier = TechTalk.SpecFlow.CurrentScenario.Get<Courriel>("sut");
            Assert.AreEqual(sujet, courrier.Sujet );
        }

    }
}