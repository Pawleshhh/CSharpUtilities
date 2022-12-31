namespace CSharpUtilities.Test;

internal class EnumerableExtensionTest
{


    [Test]
    public void IsNullOrEmpty_ProvideNullEnumerable_ReturnsTrue()
    {
        IEnumerable<object>? enumerable = null;

        Assert.That(enumerable!.IsNullOrEmpty(), Is.True);
    }

    [Test]
    public void IsNullOrEmpty_ProvideEmptyEnumerable_ReturnsTrue()
    {
        IEnumerable<object> enumerable = Enumerable.Empty<object>();

        Assert.That(enumerable.IsNullOrEmpty(), Is.True);
    }

    [Test]
    public void IsNullOrEmpty_ProvideNotEmptyEnumerable_ReturnsFalse()
    {
        IEnumerable<object> enumerable = Enumerable.Range(0, 10).Cast<object>();

        Assert.That(enumerable.IsNullOrEmpty(), Is.False);
    }

    [Test]
    public void IsNotNullAndExactCount_ProvideNullEnumerable_ReturnsFalse()
    {
        IEnumerable<object>? enumerable = null;

        Assert.That(enumerable!.IsNotNullAndExactCount(10), Is.False);
    }

    [Test]
    public void IsNotNullAndExactCount_ProvideEmptyEnumerableAndCheckCount_ReturnsFalse()
    {
        IEnumerable<object> enumerable = Enumerable.Empty<object>();

        Assert.That(enumerable.IsNotNullAndExactCount(Random()), Is.False);
    }

    [Test]
    public void IsNotNullAndExactCount_ProvideEnumerableAndCheckCount_ReturnsFalse()
    {
        int count1 = Random(50);
        int count2 = Random(50) + 200;
        IEnumerable<object> enumerable = Enumerable.Range(0, count1).Cast<object>();

        Assert.That(enumerable.IsNotNullAndExactCount(count2), Is.False);
    }

    [Test]
    public void IsNotNullAndExactCount_ProvideEnumerableAndCheckCount_ReturnsTrue()
    {
        int count = Random(50);
        IEnumerable<object> enumerable = Enumerable.Range(0, count).Cast<object>();

        Assert.That(enumerable.IsNotNullAndExactCount(count), Is.True);
    }

    [Test]
    public void ForEach_IterateThroughEnumerable_SumAction()
    {
        int sum = 0;
        Action<int> act = n => sum += n;
        IEnumerable<int> enumerable = Enumerable.Range(0, 10);

        enumerable.ForEach(act);

        Assert.That(sum, Is.EqualTo(45));
    }

    [Test]
    public void Iterate_IterateThroughEnumerable_SumAction()
    {
        int sum = 0;
        int index = 0;
        Action<int, int> act = (n, i) =>
        {
            sum += n;
            Assert.That(index++, Is.EqualTo(i));
        };
        IEnumerable<int> enumerable = Enumerable.Range(0, 10);

        enumerable.Iterate(act);

        Assert.That(sum, Is.EqualTo(45));
    }

    private static int Random() => new Random().Next();
    private static int Random(int c) => new Random().Next(c);

}
