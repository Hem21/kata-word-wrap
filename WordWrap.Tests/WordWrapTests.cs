using FluentAssertions;
using NUnit.Framework.Internal;

namespace WordWrap;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(TestData.ShortText, TestData.ShortTextLength, TestData.ShortText)]
    [TestCase(TestData.ShortText, 6, TestData.ShortTextWrappedAtColumnWidthOf6)]
    public void ItShouldAddNewLinesSoNoLineExceedsTheColumnWidth(string input, int columnWidth, string expectedOutput)
    {
        var actual = WordWrap.Wrap(input, columnWidth);

        actual.Should().Be(expectedOutput);
    }
}