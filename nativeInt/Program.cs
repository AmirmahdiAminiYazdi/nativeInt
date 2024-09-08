
// Define a nint variable
nint nativeInt;

// Assign a value to nint based on the native system
if (IntPtr.Size == 8) // Check if the system is 64-bit
{
    nativeInt = nint.MaxValue;

    Console.WriteLine("The system is 64-bit and the nint value: " + nativeInt);
}
else // If the system is 32-bit
{
    nativeInt = nint.MaxValue;
    Console.WriteLine("The system is 32-bit and the nint value: " + nativeInt);
}

// Perform arithmetic operation with nint
nativeInt += 10;
Console.WriteLine("After adding 10 to nint: " + nativeInt);

// Using pointers and nint
int[] array = { 10, 20, 30, 40, 50 };
unsafe
{
    fixed(int * ptr = array)
    {
        nint index = 2; // Using nint for array indexing

        Console.WriteLine("Value at index 2 (using nint): " + *(ptr + index));
    }
}