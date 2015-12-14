using NUnit.Framework;


namespace Tests
{
    public class DataUpgradeTestsWithoutTestCaseSource
    {
        /// <summary>
        /// Without the ability to automatically generate unit test cases, we have to maintain this list of
        /// TestCase attributes in line with the version number in the production code
        /// </summary>
        /// <param name="versionNumber">The version to upgrade from</param>
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void DataCanBeUpgraded(int versionNumber)
        {            
            LoadTestDataForVersion(versionNumber);

            // upgrade data and assert ....
        }

        private void LoadTestDataForVersion(int versionNumber)
        {
            // ..... load test data corresponding to versionNumber ......
        }
    }
}

