using FluentAssertions;

namespace WordWrap.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(TestData.ShortText, TestData.ShortTextLength, TestData.ShortText)]
    public void ItShouldAddNewLinesSoNoLineExceedsTheColumnWidth(string input, int columnWidth, string expectedOutput)
    {
        var actual = WordWrap.Wrap(input, columnWidth);

        actual.Should().Be(expectedOutput);
    }
}