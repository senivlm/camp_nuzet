using System;
using System.Collections.Generic;
using System.IO;
namespace Vector
{
    class Vector
    {
        int[] arr;


        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        public Vector() { }

        public void RandomInitialization(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
        }

        public void InitShufle()
        {


            Random random = new Random();
            int x;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] == 0)
                {
                    x = random.Next(1, arr.Length + 1);
                    bool isExist = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (x == arr[j])
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        arr[i] = x;

                    }
                }
            }
        }
        public bool CheckForPalindrom()
        {
            if (arr.Length % 2 == 0)
            {
                int[] leftArr = new int[arr.Length / 2];
                int[] rightArr = new int[arr.Length / 2];

                for (int i = 0; i < arr.Length / 2; i++)
                {
                    leftArr[i] = arr[i];
                }

                for (int i = arr.Length - 1, j = 0; i >= (rightArr.Length / 2) && j < rightArr.Length; i--, j++)
                {
                    rightArr[j] = arr[i];
                }
                int count = 0;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    if (leftArr[i] == rightArr[i])
                    {
                        count++;
                    }
                }
                if (count == arr.Length / 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                int[] leftArr = new int[arr.Length / 2];
                int[] rightArr = new int[arr.Length / 2];

                for (int i = 0; i < arr.Length / 2; i++)
                {
                    leftArr[i] = arr[i];
                }

                for (int i = arr.Length - 1, j = 0; i >= ((rightArr.Length / 2) + 1) && j < rightArr.Length; i--, j++)
                {
                    rightArr[j] = arr[i];
                }
                int count = 0;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    if (leftArr[i] == rightArr[i])
                    {
                        count++;
                    }
                }
                if (count == arr.Length / 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Reverse()
        {
            int[] arrReverse = new int[arr.Length];

            for (int j = 0, i = arr.Length - 1; j < arrReverse.Length && i >= 0; j++, i--)
            {
                arrReverse[j] = arr[i];
            }

            for (int j = 0, i = 0; j < arrReverse.Length; j++, i++)
            {
                arr[i] = arrReverse[j];
            }


        }
        public void LongestSequenseFind()
        {
            int count = 0;
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        if (num < count)
                        {
                            num = count;
                        }
                    }
                    if (arr[i] != arr[j])
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine($"the longest sequence all of numbers: {num}");
        }
        public void LongestSequenseFind(int findNumber)
        {
            int count = 0;
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == findNumber)
                {
                    count++;
                    if (num < count)
                    {
                        num = count;
                    }
                }
                if (arr[i] != findNumber)
                {
                    count = 0;
                }

            }
            Console.WriteLine($"the longest sequence number {findNumber} : {num}");
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }


        public Pair[] CalculateFreq()
        {

            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pairs[i] = new Pair(0, 0);

            }
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if (arr[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = arr[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public void BubbleSort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void CauutingSort()
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int[] temp = new int[max - min + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[arr[i] - min]++;

            }
            int k = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i]; j++)
                {
                    arr[k] = i + min;
                    k++;
                }
            }
        }
        public int[] QuickSort()
        {
            return Quicksort(0, arr.Length - 1);

        }
        public int[] Quicksort(int minIndex, int maxIndex)
        {


            if (minIndex >= maxIndex)
            {
                return arr;
            }
            int pivotIndex = GetPivotIndex(minIndex, maxIndex);
            Quicksort(minIndex, pivotIndex - 1);
            Quicksort(pivotIndex + 1, maxIndex);


            return arr;
        }

        private int GetPivotIndex(int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (arr[i] < arr[maxIndex])
                {
                    pivot++;
                    int temp = arr[pivot];
                    arr[pivot] = arr[i];
                    arr[i] = temp;

                }
            }
            pivot++;
            int temp2 = arr[pivot];
            arr[pivot] = arr[maxIndex];
            arr[maxIndex] = temp2;
            return pivot;
        }

         private void Merge( int lowIndex, int middleIndex, int highIndex)
         {
            int left = lowIndex;
            int right = middleIndex + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            int k = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (arr[left] < arr[right])
                {
                    tempArray[k] = arr[left];
                    left++;
                }
                else
                {
                    tempArray[k] = arr[right];
                    right++;
                }

                k++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[k] = arr[i];
                k++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[k] = arr[i];
                k++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                arr[lowIndex + i] = tempArray[i];
            }
         }

        public void SplitMergeSort( int lowIndex, int highIndex)
       {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                SplitMergeSort(lowIndex, middleIndex);
                SplitMergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
        }

        public void SplitMergeSort()
        {
            SplitMergeSort(0,arr.Length-1);
        }

        public void HeapySort()
        {
            int n = arr.Length;


            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }
           
            for (int i = n - 1; i >= 0; i--)
            {
                
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                
                Heapify( i, 0);
            }
        }

        private void Heapify( int n, int i)
        {
            int largest = i;
            
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

            
            if (l < n && arr[l] > arr[largest])
                largest = l;

         
            if (r < n && arr[r] > arr[largest])
                largest = r;

           
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

       
                Heapify( n, largest);
            }
        }
        public int  Length()
        {
            return arr.Length;
        }
        public void ReadFromFile(string fileName)
        {
            string line = null;
            try
            {
                StreamReader reader = new StreamReader(fileName);

                line = reader.ReadLine();
                reader.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file is not found");
            }
            
       
        }
        // При виклику Ви змушені мати одночасно 2 масиви, а вони не поміщаються за умовою задачі в оперативку
        public void MergeWriteToFile(Vector firstArr, Vector secondArr, Trend trend, string fileName)
        {
            int i = 0;
            int j = 0;
            using (StreamWriter reader = new StreamWriter(fileName))
            {

                while (i < firstArr.arr.Length && j < secondArr.arr.Length)
                {
                    if (trend is Trend.increase)
                    {
                        if (firstArr[i] < secondArr[j])
                        {
                            reader.Write(firstArr[i++] + " ");
                        }
                        else
                        {
                            reader.Write(secondArr[j++] + " ");
                        }
                    }
                    else
                    {
                        if (firstArr[i] > secondArr[j])
                        {
                            reader.Write(firstArr[i++] + " ");
                        }
                        else
                        {
                            reader.Write(secondArr[j++] + " ");
                        }
                    }
                }
                if (i == firstArr.arr.Length)
                {
                    while (j < secondArr.arr.Length)
                    {
                        reader.Write(secondArr[j++] + " ");
                    }
                }
                else
                {
                    while (i < firstArr.arr.Length)
                    {
                        reader.Write(firstArr[i++] + " ");
                    }
                }
            }

        }
        public enum Trend
        {
            decrease,
            increase
        }
    }

}
