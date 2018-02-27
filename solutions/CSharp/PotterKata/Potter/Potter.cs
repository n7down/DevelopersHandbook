using System;

namespace Potter
{
    public class Potter
    {
        private double price;

        private bool IsEmpty(int[] array)
        {
            if(array[0] == 0 && array[1] == 0 && array[2] == 0 && array[3] == 0 && array[4] == 0)
            {
                return true;
            }
            return false;
        }

        public Potter(int[] bookArray) 
        {
            double result = 0;
            foreach(int book in bookArray)
            {
                result += 8 * book;
            }

            // apply discount
            while(!IsEmpty(bookArray))
            {
                int bookSeriesCount = 0;
                if(bookArray[0] != 0)
                {
                    bookSeriesCount++;
                    bookArray[0]--;
                }

                if(bookArray[1] != 0)
                {
                    bookSeriesCount++;
                    bookArray[1]--;
                }

                if(bookArray[2] != 0)
                {
                    bookSeriesCount++;
                    bookArray[2]--;
                }

                if(bookArray[3] != 0)
                {
                    bookSeriesCount++;
                    bookArray[3]--;
                }

                if(bookArray[4] != 0)
                {
                    bookSeriesCount++;
                    bookArray[4]--;
                }

                if(bookSeriesCount == 5)
                {
                    result -= result * 0.25;
                }
                else if(bookSeriesCount == 4)
                {
                    result -= result * 0.2;
                }
                else if(bookSeriesCount == 3) 
                {
                    result -= result * 0.1;
                }
                else if(bookSeriesCount == 2)
                {
                    result -= result * 0.05;
                }
            }

            price = result;
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public static void Main(string[] args)
        {}
    }
}
