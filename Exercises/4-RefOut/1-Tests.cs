using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.RefOut
{
    [TestFixture]
    public class TestsPart1
    {
        [Test]
        public async Task OutParameter()
        {
            // TODO: Refactor out to be async
            // TODO: How can you deal with out params

            Assert.Inconclusive(nameof(OutParameter));
        }

        static void Out(string content, out string parameter)
        {
            var randomFileName = Path.GetTempFileName();
            using (var writer = new StreamWriter(randomFileName))
            {
                writer.WriteLine(content);
            }
            parameter = randomFileName;
        }

        [Test]
        public async Task RefParameter()
        {
            // TODO: Refactor Ref to be async
            // TODO: How can you deal with ref params?

            Assert.Inconclusive(nameof(RefParameter));
        }

        static void Ref(string content, ref int fileNameLength)
        {
            var randomFileName = Path.GetTempFileName();
            using (var writer = new StreamWriter(randomFileName))
            {
                writer.WriteLine(content);
            }
            fileNameLength = randomFileName.Length;
        }
    }
}
