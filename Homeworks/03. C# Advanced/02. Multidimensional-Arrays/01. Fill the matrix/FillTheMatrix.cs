using System;

class FillTheMatrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        int[,] numbers = new int[number, number];
        int counter = 1;
        int sizeOfCurrentDiag = 1;
        if (letter == 'a')
        {
            for (int col = 0; col < number; col++)
            {
                for (int row = 0; row < number; row++)
                {
                    numbers[row, col] = counter;
                    counter++;
                }
            }
            PrintMatrix(numbers);
        }
        else if (letter == 'b')
        {
            for (int col = 0; col < number; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < number; row++)
                    {
                        numbers[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = numbers.GetLength(0) - 1; row >= 0; row--)
                    {
                        numbers[row, col] = counter;
                        counter++;
                    }
                }

            }
            PrintMatrix(numbers);
        }
        else if (letter == 'c')
        {
            for (int i = 0; i < number; i++)
            {
                int currentStartingRow = number - 1 - i;
                int currentStartingCol = 0;
                for (int l = 0; l < sizeOfCurrentDiag; l++)
                {
                    numbers[currentStartingRow + l, currentStartingCol + l] = counter;
                    counter++;
                }
                sizeOfCurrentDiag++;
            }
            sizeOfCurrentDiag = sizeOfCurrentDiag - 2;
            for (int currentCol = 1; currentCol <= number - 1; currentCol++)
            {
                int currentStartingRow = 0;
                int currentStartingCol = currentCol;
                for (int i = 0; i < sizeOfCurrentDiag; i++)
                {
                    numbers[currentStartingRow + i, currentStartingCol + i] = counter;
                    counter++;
                }
                sizeOfCurrentDiag--;
            }
            PrintMatrix(numbers);
        }
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
        {
            for (int curruentCol = 0; curruentCol < matrix.GetLength(1); curruentCol++)
            {
                string currentBoxContent = matrix[currentRow, curruentCol] + " ";
                if (curruentCol == matrix.GetLength(1) - 1)
                {
                    currentBoxContent = currentBoxContent.Trim();
                }
                Console.Write(currentBoxContent);
            }
            Console.WriteLine();
        }
    }
}