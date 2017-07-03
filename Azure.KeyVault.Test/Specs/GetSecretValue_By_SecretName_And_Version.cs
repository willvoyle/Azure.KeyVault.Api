using TechTalk.SpecFlow;
using Azure.KeyVault.Service;
using Azure.KeyVault.Service.Helpers;
using Azure.KeyVault.Service.Interfaces;
using Azure.KeyVault.Service.Services;
using NUnit.Framework;

namespace Azure.KeyVault.Test.Specs
{
    public class GetSecretValue_By_SecretName_And_Version
    {
        private string actual;
        private string secretName;
        private string version;
        
        private readonly IKeyVaultApi _keyVaultAPi;

        public GetSecretValue_By_SecretName_And_Version()
        {
            _keyVaultAPi = new KeyVaultApi(new KeyVaultService(new ConfigHelper(), new AzureAdHelper(new ConfigHelper())));
        }

        [Given(@"I want to get a specfic version of the TestSecret02 secret")]
        public void GivenIWantToGetASpecficVersionOfTheTestSecretSecret()
        {
            secretName = $"TestSecret02";
            version = "c1ef0c2b7d1a46788882f2496c61b095";
        }

        [When(@"I call the API with Secret Name and Version")]
        public void WhenICallTheAPIWithSecretNameAndVersion()
        {
            _keyVaultAPi.GetSecretValue(secretName, version);
        }

        [Then(@"I should return the TestSecret02 Value")]
        public void ThenIShouldReturnTheTestSecretValue()
        {
            var expected = "TestSecretValue01 - 03403#3$%";
            Assert.AreEqual(expected, actual);
        }
    }
}
