using System;
using System.Linq;

namespace HungarianAlgorithm.Extensions;

/// <summary>
/// Array Extensions.
/// </summary>
public static class ArrayExtensions
{
    /// <summary>
    /// Creates a new <see cref="Array"/>, having equal elements for both dimensions.
    /// Rows or columns added is filled with null values.
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The <see cref="Array"/> to square.</param>
    /// <returns>The <see cref="Array"/> squared.</returns>
    public static T[,] SquareArray<T>(this T[][] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        var rows = array.Length;
        var cols = array.Select(x => x.Length).Concat(new[] { 0 }).Max();
        var loops = rows > cols ? rows : cols;
        var square = new T[loops, loops];

        for (var i = 0; i < loops; i++)
        {
            if (i > rows - 1)
            {
                break;
            }
            
            for (var j = 0; j < loops; j++)
            {
                if (j > cols - 1)
                {
                    break;
                }
                
                square[i, j] = array[i][j];
            }
        }

        return square;
    }
}