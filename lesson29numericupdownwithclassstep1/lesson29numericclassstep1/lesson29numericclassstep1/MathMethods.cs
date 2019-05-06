namespace lesson29numericclassstep1
{
    //static classes are used as contains to hold methods
    //methods in these kinds of classes are actions that can be performed
    static class MathMethods
    {
        //public so it can be reached inside Form1.cs
        //static means we can call it by typing MathMethods.Add
        //the method Add is a member of the class MathMethods
        //this method takes two values x, y, each of which is of type decimal
        //method returns a value back to calling code
        //this is the called code
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
    }
}
