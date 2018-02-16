using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;

using Sample;
using Vostok.Hosting;

namespace Vostok.Testing
{
    [TestFixture]
    public class TestBase
    {
        protected IVostokHost _app;
        protected Task _task;

        [OneTimeSetUp]
        public void Initialize()
        {
            _app = (IVostokHost) typeof(EntryPoint).GetMethod("BuildVostokHost", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, new object[] { new string[]{} });
            //_task = Task.Run(() => _app.Run());
            _app.RunAsync();
        }

        [OneTimeTearDown]
        public void Finish()
        {
            //_task.Wait(new CancellationToken());
            ;
        }

        [Test]
        public void TestMethod1()
        {
            var tankConfig = new TankConfig().AddConst(10, TimeSpan.MaxValue);
            TankRunner.Run(tankConfig);
            var metrics = FetchMetrics();

            AssertMetrics(metrics);
        }

        protected void AssertMetrics(List<GraphiteMetric> metrics)
        {
            Assert.Pass();
        }

        protected List<GraphiteMetric> FetchMetrics()
        {
            return new List<GraphiteMetric>();
        }
    }
}
