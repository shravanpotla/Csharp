class ArrayRotation
{
    static void ShiftRight(int[] values, int steps)
    {
        int size = values.Length;
        steps %= size;

        int[] rotated = new int[size];

        for (int pos = 0; pos < size; pos++)
        {
            rotated[(pos + steps) % size] = values[pos];
        }

        for (int pos = 0; pos < size; pos++)
        {
            values[pos] = rotated[pos];
        }
    }
}