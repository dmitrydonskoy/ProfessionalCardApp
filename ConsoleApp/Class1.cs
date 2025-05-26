using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    using System;

    class SortingDemo
    {
        // 1. Пузырьковая сортировка
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                    if (array[j] > array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
        }

        // 2. Сортировка выбором
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[min])
                        min = j;
                (array[i], array[min]) = (array[min], array[i]);
            }
        }

        // 3. Сортировка вставками
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i], j = i - 1;
                while (j >= 0 && array[j] > key)
                    array[j + 1] = array[j--];
                array[j + 1] = key;
            }
        }

        // 4. Быстрая сортировка
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot) left++;
                while (array[right] > pivot) right--;

                if (left <= right)
                {
                    (array[left], array[right]) = (array[right], array[left]);
                    left++; right--;
                }
            }
            return left;
        }

        // 5. Сортировка слиянием
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }

        private static void Merge(int[] array, int left, int mid, int right)
        {
            int[] leftArr = array[left..(mid + 1)];
            int[] rightArr = array[(mid + 1)..(right + 1)];

            int i = 0, j = 0, k = left;

            while (i < leftArr.Length && j < rightArr.Length)
                array[k++] = (leftArr[i] <= rightArr[j]) ? leftArr[i++] : rightArr[j++];

            while (i < leftArr.Length) array[k++] = leftArr[i++];
            while (j < rightArr.Length) array[k++] = rightArr[j++];
        }

        // 6. Сортировка Шелла
        public static void ShellSort(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i], j = i;
                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }
        }

        // 7. Сортировка кучей
        public static void HeapSort(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                (array[0], array[i]) = (array[i], array[0]);
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int size, int i)
        {
            int largest = i, left = 2 * i + 1, right = 2 * i + 2;

            if (left < size && array[left] > array[largest]) largest = left;
            if (right < size && array[right] > array[largest]) largest = right;

            if (largest != i)
            {
                (array[i], array[largest]) = (array[largest], array[i]);
                Heapify(array, size, largest);
            }
        }

        // Метод для печати массива
        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        // Главный метод
        public static void Main()
        {
            int[] original = { 9, 5, 1, 4, 3, 8, 2, 7, 6 };

            Console.WriteLine("Выберите алгоритм сортировки:");
            Console.WriteLine("1 - Bubble Sort");
            Console.WriteLine("2 - Selection Sort");
            Console.WriteLine("3 - Insertion Sort");
            Console.WriteLine("4 - Quick Sort");
            Console.WriteLine("5 - Merge Sort");
            Console.WriteLine("6 - Shell Sort");
            Console.WriteLine("7 - Heap Sort");
            Console.Write("Ваш выбор: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 7)
            {
                Console.WriteLine("Некорректный выбор.");
                return;
            }

            int[] array = (int[])original.Clone();
            Console.WriteLine("\nИсходный массив:");
            PrintArray(array);

            switch (choice)
            {
                case 1: BubbleSort(array); break;
                case 2: SelectionSort(array); break;
                case 3: InsertionSort(array); break;
                case 4: QuickSort(array, 0, array.Length - 1); break;
                case 5: MergeSort(array, 0, array.Length - 1); break;
                case 6: ShellSort(array); break;
                case 7: HeapSort(array); break;
            }

            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(array);
        }
    }

}
