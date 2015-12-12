using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SrcCode;

namespace Tests
{
    [TestFixture]
    public class DynamicTestCases
    {
        /// <summary>
        /// eg. Test that data can be upgraded from multiple versions.
        /// By using the version number from the production code, we avoid violating the DRY principle and having to maintain
        /// the current version in both the production code and TestCase attributes
        /// </summary>
        /// <param name="versionNumber">The version to upgrade from</param>
        [TestCaseSource(nameof(GetSupportedVersions))]
        public void DataCanBeUpgraded(int versionNumber)
        {            
            LoadTestDataForVersion(versionNumber);

            // upgrade data and assert ....
        }

        /// <summary>
        /// Returns the input values for the above test based on the value in the production code
        /// </summary>
        /// <returns>The supported versions.</returns>
        public static IEnumerable GetSupportedVersions()
        {
            return Enumerable.Range(0, Constants.CurrentVersionNumber);
        }

        private void LoadTestDataForVersion(int versionNumber)
        {
            var dataLoaded = false;

            // ..... try to load test data corresponding to versionNumber ......

            if (!dataLoaded) {
                Assert.Fail($"Could not find test data to load for version {versionNumber}. Did you increase the current version? If so, you need to add sample test data.");
            }
        }
    }
}

