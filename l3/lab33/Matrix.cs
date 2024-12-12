namespace lab33
{
    public class Matrix
    {
        volatile public int[,] matrix;
        public int size = 0;
        Random rnd = new Random();

        public void fill_matrix(int size_ = 20, int seed_ = 10)
        {
            size = size_;
            matrix = new int[size, size];

            rnd = new Random(seed_);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                }
            }
        }

        public Matrix(int size_ = 20, int seed_ = 10)
        {
            fill_matrix(size_, seed_);
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    str += $"{matrix[i, j]}, ";
                }

                str += "\n";

            }
            return str;
        }


    }
}
