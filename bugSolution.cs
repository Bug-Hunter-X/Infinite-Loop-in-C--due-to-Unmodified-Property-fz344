public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int i = 0;
        while (i < 10)
        {
            // Some code here...
            MyProperty = i; // Update MyProperty within loop
            if (MyProperty == 5)
            {
                break; // Exit the loop if MyProperty is 5
            }
            i++;
        }
    }
}