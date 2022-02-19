using NUnit.Framework;
using Sentence;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        private CommandContext _context;
        private const string ID_COMMAND_1 = "1";
        private const string ID_COMMAND_2 = "2";
        private string _expectedOutput;
        private string _actualOutput;

        [SetUp]
        public void Setup()
        {
            _context = CommandContext.GetCommands;
            _expectedOutput = string.Empty;
        }

        [TestCase("Hi, how are you?")]
        public void TestSetence(string sentence)
        {
            _expectedOutput = "you? are how Hi,";

            _actualOutput = _context.GetCommand(ID_COMMAND_1).GetOutput(sentence);

            Assert.AreEqual(_expectedOutput, _actualOutput);
        }

        [TestCase("Fayçal")]
        public void TestWord(string word)
        {
            _expectedOutput = "laçyaF";

            _actualOutput = _context.GetCommand(ID_COMMAND_2).GetOutput(word);

            Assert.AreEqual(_expectedOutput, _actualOutput);
        }
    }
}