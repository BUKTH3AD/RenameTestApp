TestApp test = new TestApp();

test.Make1();
test.Make2();
test.Make1(2, 6);


List<string> users = new List<string>();
users.Add("Alex");
users.Add("Bob");
users.Add("Charlie");

class TestApp : ITestApp
{
    public void Make1()
    {
        
    }
    public int Make1(int a,int b)
    {
        return a + b;
    }
    public void @Make2()
    {
        Make1();
        Make1(4,6);
    }
}
interface ITestApp
{
    void Make1();
}