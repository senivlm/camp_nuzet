using System;

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
                while (arr[i]==0)
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
        public bool CheckForPalindrom ()
        {
            if (arr.Length % 2 == 0)
            {
                int[] leftArr = new int[arr.Length / 2];
                int[] rightArr = new int[arr.Length / 2];

                for (int i = 0; i < arr.Length / 2; i++)
                {
                    leftArr [i] = arr [i];
                }
               
                for(int i = arr.Length-1,  j=0 ; i >= (rightArr.Length/2)&& j<rightArr.Length ; i--, j++)
                {
                    rightArr[j] = arr[i];
                }
                int count = 0;
                for (int i = 0; i < arr.Length/2; i++)
                { 
                    if (leftArr[i]==rightArr[i])
                    {
                        count++;
                    } 
                }
                if(count == arr.Length/2)
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

                for (int i = arr.Length - 1, j = 0; i >= ((rightArr.Length / 2)+1) && j < rightArr.Length; i--, j++)
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
            int [] arrReverse = new int[arr.Length];
            
                for(int j = 0,  i = arr.Length-1; j < arrReverse.Length && i>=0; j++, i--)
                {
                    arrReverse[j] = arr[i];
                }
                
                for(int j =0 ,  i =0; j < arrReverse.Length; j++,i++)
                {
                arr[i]=arrReverse[j];
                }
          

        }
        public void LongestSequenseFind()
        {
            int count = 0;
            int num = 0;
            for(int i =0; i < arr.Length; i++)
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


    }
}
