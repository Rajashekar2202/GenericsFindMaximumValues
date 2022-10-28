namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Find Maximum Values");
            int[] intArray = { 112, 344, 432, 555, 678 };
            MaximumInArrayGenerics<int> genericsint = new MaximumInArrayGenerics<int>(intArray);
            genericsint.PrintMaxValue();
            float[] floatArray = { 1.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            MaximumInArrayGenerics<float> genericsfloat = new MaximumInArrayGenerics<float>(floatArray);
            genericsfloat.PrintMaxValue();
            string[] stringArray = { "Red", "Blue", "Orange", "Green", "Yellow" };
            MaximumInArrayGenerics<string> genericsstring = new MaximumInArrayGenerics<string>(stringArray);
            genericsstring.PrintMaxValue();

        }
    
    }
}