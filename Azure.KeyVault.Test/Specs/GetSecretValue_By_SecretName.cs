using TechTalk.SpecFlow;
using Azure.KeyVault.Service;
using Azure.KeyVault.Service.Helpers;
using Azure.KeyVault.Service.Interfaces;
using Azure.KeyVault.Service.Services;
using NUnit.Framework;

namespace Azure.KeyVault.Test.Specs
{

    [Binding]
    public class GetSecretValue_By_SecretName
    {
        private string actual;
        private string secretName;

        private readonly IKeyVaultApi _keyVaultAPi;

        public GetSecretValue_By_SecretName()
        {
            _keyVaultAPi = new KeyVaultApi(new KeyVaultService(new ConfigHelper(), new AzureAdHelper(new ConfigHelper())));
        }

        [Given(@"I want to get the latest version of the TestSecret01 secret")]
        public void GivenIWantToGetTheLatestVersionOfTheTestSecret01Secret()
        {
            secretName = $"TestSecret01";
        }

        [When(@"I call the API with Secret Name")]
        public void WhenICallTheAPIWithSecretName()
        {
            actual = _keyVaultAPi.GetSecretValue(secretName);
        }


        [Then(@"I should return the TestSecret01 Value")]
        public void ThenIShouldReturnTheTestSecret01Value()
        {
            var expected = "TestSecretValue01 - LKHpqIukA1jFco5";
            Assert.AreEqual(expected, actual);
        }
    }
}
