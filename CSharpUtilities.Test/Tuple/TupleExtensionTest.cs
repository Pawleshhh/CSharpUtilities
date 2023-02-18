using Newtonsoft.Json.Linq;
using NUnit.Framework.Internal;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;

namespace CSharpUtilities.Test;

[TestFixture]
internal class TupleExtensionTest
{

    #region AsEnumerable

    [Test]
    public void AsEnumerable_Should_Return_Expected_Values_For_Two_Item_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two");

        // Act
        var result = tuple.AsEnumerable();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.ElementAt(0), Is.EqualTo(1));
            Assert.That(result.ElementAt(1), Is.EqualTo("two"));
        });
    }

    [Test]
    public void AsEnumerableT_Should_Return_Expected_Values_For_Two_Item_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(new TestClass1() { Value = 1 }, new TestClass2() { Value = 2 });

        // Act
        var result = tuple.AsEnumerable<ITestInterface>();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.ElementAt(0).Value, Is.EqualTo(1));
            Assert.That(result.ElementAt(1).Value, Is.EqualTo(2));
        });
    }

    [Test]
    public void AsEnumerable_Should_Return_Expected_Values_For_Three_Item_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two", 3.0);

        // Act
        var result = tuple.AsEnumerable();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result.ElementAt(0), Is.EqualTo(1));
            Assert.That(result.ElementAt(1), Is.EqualTo("two"));
            Assert.That(result.ElementAt(2), Is.EqualTo(3.0));
        });
    }

    [Test]
    public void AsEnumerableT_Should_Return_Expected_Values_For_Three_Item_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(new TestClass1() { Value = 1 }, new TestClass2() { Value = 2 }, new TestClass1() { Value = 3 });

        // Act
        var result = tuple.AsEnumerable<ITestInterface>();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result.ElementAt(0).Value, Is.EqualTo(1));
            Assert.That(result.ElementAt(1).Value, Is.EqualTo(2));
            Assert.That(result.ElementAt(2).Value, Is.EqualTo(3));
        });
    }

    interface ITestInterface { public int Value { get; set; } }
    record TestClass1 : ITestInterface { public int Value { get; set; } }
    record TestClass2 : ITestInterface { public int Value { get; set; } }

    #endregion

    #region ToKeyValuePair

    [Test]
    public void ToKeyValuePair_Should_Return_Correct_KeyValuePair_For_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create("key", "value");

        // Act
        var result = tuple.ToKeyValuePair();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Key, Is.EqualTo("key"));
            Assert.That(result.Value, Is.EqualTo("value"));
        });
    }

    [Test]
    public void ToKeyValuePair_Should_Return_Correct_KeyValuePair_For_ValueTuple()
    {
        // Arrange
        var tuple = ValueTuple.Create(1, "one");

        // Act
        var result = tuple.ToKeyValuePair();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Key, Is.EqualTo(1));
            Assert.That(result.Value, Is.EqualTo("one"));
        });
    }

    #endregion

    #region ToDictionary

    [Test]
    public void ToDictionary_Should_Return_Correct_Dictionary_For_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(
            new List<int> { 1, 2, 3 }.AsEnumerable(),
            new List<string> { "one", "two", "three" }.AsEnumerable()
        );

        // Act
        var result = tuple.ToDictionary();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result[1], Is.EqualTo("one"));
            Assert.That(result[2], Is.EqualTo("two"));
            Assert.That(result[3], Is.EqualTo("three"));
        });
    }

    [Test]
    public void ToDictionary_Should_Throw_Exception_If_Key_Value_Count_Different()
    {
        // Arrange
        var tuple = Tuple.Create(
            new List<int> { 1, 2, 3 }.AsEnumerable(),
            new List<string> { "one", "two" }.AsEnumerable()
        );

        // Act & Assert
        Assert.Throws<ArgumentException>(() => tuple.ToDictionary());
    }

    #endregion

    #region At

    [Test]
    public void At_Should_Return_Correct_Object_For_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two", 3.0);

        // Act
        var result1 = tuple.At(0);
        var result2 = tuple.At(1);
        var result3 = tuple.At(2);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(1));
            Assert.That(result2, Is.EqualTo("two"));
            Assert.That(result3, Is.EqualTo(3.0));
        });
    }

    [Test]
    public void At_Should_Return_Correct_Generic_Type_For_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two", 3.0);

        // Act
        var result1 = tuple.At<int>(0);
        var result2 = tuple.At<string>(1);
        var result3 = tuple.At<double>(2);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(1));
            Assert.That(result2, Is.EqualTo("two"));
            Assert.That(result3, Is.EqualTo(3.0));
        });
    }

    #endregion

    #region GetLength

    [Test]
    public void GetLength_Should_Return_Correct_Length_For_Tuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two", 3.0);

        // Act
        var result = tuple.GetLength();

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void GetLength_Should_Return_Correct_Length_For_ValueTuple()
    {
        // Arrange
        var tuple = (1, "two", 3.0);

        // Act
        var result = tuple.GetLength();

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    #endregion

    #region Select

    [Test]
    public void Select_TupleOfTwoItems_ReturnsExpectedNewTuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two");

        // Act
        var result = tuple.Select((i, s) => (i + 1, s + "!"));

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(2));
            Assert.That(result.Item2, Is.EqualTo("two!"));
        });
    }

    [Test]
    public void Select_TupleOfThreeItems_ReturnsExpectedNewTuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two", 3.2);

        // Act
        var result = tuple.Select((i, s, d) => (i + 1, s + "!", d.ToString(CultureInfo.InvariantCulture)));

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(2));
            Assert.That(result.Item2, Is.EqualTo("two!"));
            Assert.That(result.Item3, Is.EqualTo("3.2"));
        });
    }

    [Test]
    public void Select_TupleOfFourItems_ReturnsExpectedNewTuple()
    {
        // Arrange
        var tuple = Tuple.Create(1, "two", 3.2, new int[] { 4, 5 });

        // Act
        var result = tuple.Select((i, s, d, a) => (i + 1, s + "!", d.ToString(CultureInfo.InvariantCulture), a.Sum()));

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(2));
            Assert.That(result.Item2, Is.EqualTo("two!"));
            Assert.That(result.Item3, Is.EqualTo("3.2"));
            Assert.That(result.Item4, Is.EqualTo(9));
        });
    }

    [Test]
    public void Select_ValueTupleOfTwoItems_ReturnsExpectedNewTuple()
    {
        // Arrange
        var tuple = (1, "two");

        // Act
        var result = tuple.Select((i, s) => (i + 1, s + "!"));

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(2));
            Assert.That(result.Item2, Is.EqualTo("two!"));
        });
    }

    [Test]
    public void Select_ValueTupleOfThreeItems_ReturnsExpectedNewTuple()
    {
        // Arrange
        var tuple = (1, "two", 3.2);

        // Act
        var result = tuple.Select((i, s, d) => (i + 1, s + "!", d.ToString(CultureInfo.InvariantCulture)));

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(2));
            Assert.That(result.Item2, Is.EqualTo("two!"));
            Assert.That(result.Item3, Is.EqualTo("3.2"));
        });
    }

    [Test]
    public void Select_ValueTupleOfFourItems_ReturnsExpectedNewTuple()
    {
        // Arrange
        var tuple = (1, "two", 3.2, new int[] { 4, 5 });

        // Act
        var result = tuple.Select((i, s, d, a) => (i + 1, s + "!", d.ToString(CultureInfo.InvariantCulture), a.Sum()));

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(2));
            Assert.That(result.Item2, Is.EqualTo("two!"));
            Assert.That(result.Item3, Is.EqualTo("3.2"));
            Assert.That(result.Item4, Is.EqualTo(9));
        });
    }

    #endregion

}
