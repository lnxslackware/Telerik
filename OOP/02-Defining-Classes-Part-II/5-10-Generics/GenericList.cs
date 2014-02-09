namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GenericList<T> where T : IComparable
    {
        private T[] data;
        int marker;

        public GenericList(int capacity)
        {
            if (capacity <= 1)
            {
                throw new ArgumentOutOfRangeException("The capacity must be greater than one.");
            }

            data = new T[capacity];
            marker = 0;
        }

        //Resize data array
        private void Resize()
        {
            //create new array(size = data.Length * 2)
            T[] newData = new T[data.Length * 2];

            //copy all elements from 0 to the marker position to the new array
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }

            //set the refference of the data array to point to the new array
            data = newData;
        }

        //Indexator
        public T this[int index]
        {
            get
            {
                //checking if index is in range
                if (index < 0 || index > marker)
                {
                    throw new IndexOutOfRangeException("The index is outside the range of the current list.");
                }

                return this.data[index];
            }
            set
            {
                //checking if index is in range
                if (index < 0 || index > marker)
                {
                    throw new IndexOutOfRangeException("The index is outside the range of the current list.");
                }

                this.data[index] = value;
            }
        }

        //Adding elements
        public void Add(T element)
        {
            //Checking if the marker is at the end of the current array
            if (this.marker == this.data.Length)
            {
                Resize();
            }

            this.data[marker] = element;
            this.marker++;
        }

        //Removing element at given index
        public void Remove(int index)
        {
            //Checking if the given index is in range
            if (index < 0 || index >= this.marker)
            {
                throw new ArgumentOutOfRangeException("The index is out of range of the list");
            }

            //moving all elements after the given index back with one position
            int counter = index;
            
            for (int i = index + 1; i < marker; i++)
            {
                this.data[index] = this.data[i];
                counter++;
            }

            //moving the marker one position back
            this.marker--;
        }

        //Inserting element at given index
        public void Insert(int index, T element)
        {
            //checking if array is full and if it is - resize the array
            if (this.marker + 1 == this.data.Length)
            {
                Resize();
            }

            //copy all elements from the given index to the end of the data array in a temp array
            T[] temp = new T[marker - index];

            int counter = 0;

            for (int i = index; i < marker; i++)
            {
                temp[counter] = this.data[i];
            }

            //set the given element at the given position
            this.data[index] = element;

            //copy all elements from the temp array to the data array
            counter = index + 1;

            for (int i = 0; i < temp.Length; i++)
            {
                this.data[counter] = temp[i];
            }

            //moving the marker one position forward
            this.marker++;
        }

        //Clearing list
        public void Clear()
        {
            this.marker = 0;
        }

        //Finding element by value
        public int Find(T element)
        {
            //checking if the array is empty
            if (this.marker == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            //using binary search
            return Array.BinarySearch(this.data, element);
        }

        public T Max<K>() where K : IComparable<T>
        {
            dynamic min = this.data[0];

            for (int i = 1; i < this.marker; i++)
            {
                if (this.data[i].CompareTo(min) == 1)
                {
                    min = this.data[i];
                }
            }

            return min;
        }

        public T Min<K>() where K : IComparable<T>
        {
            dynamic max = this.data[0];

            for (int i = 1; i < this.marker; i++)
            {
                if (max.CompareTo(this.data[i]) == 1)
                {
                    max = this.data[i];
                }
            }

            return max;
        }

        //override ToString()
        public override string ToString()
        {
            //checking if the array is empty
            if (this.marker == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.marker; i++)
            {
                result.Append(string.Format("{0} ", this.data[i]));
            }

            return result.ToString();
        }
    }
}
