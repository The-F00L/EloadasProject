using NUnit.Framework;

[TestFixture]

class eladasCtorTest
{
    [TestCase]
    public void ctorTest() {
        Eloadas e = new Eloadas(5,5);

    }

    [TestCase]
    public void Fogtest() {
        Eloadas e = new Eloadas(5, 5);
        Assert.AreEqual(true, e.Lefoglal());
    }

    [TestCase]
    public void SzabadHelyTest()
    {
        Eloadas e = new Eloadas(5, 5);
        Assert.AreEqual(25,e.SzabadHelyek);
    }

    [TestCase]
    public void teli()
    {
        Eloadas e = new Eloadas(5, 5);
        Assert.AreEqual(false,e.Teli());
    }

    [TestCase]
    public void Foglalttest()
    {
        Eloadas e = new Eloadas(5, 5);
        Assert.AreEqual(false, e.Foglalt(2,2));

    }

    [TestCase]
    public void test()
    {
        Eloadas e = new Eloadas(5, 5);
        Assert.AreEqual(true, e.Lefoglal());
        Assert.AreEqual(25, e.SzabadHelyek);
        Assert.AreEqual(false, e.Teli());
        Assert.AreEqual(true, e.Foglalt(2,2));
       

    }

}
