namespace lab33
{
    public class App
    {
        public Matrix base_matrix;
        public int cores;


        public App()
        {
            cores = 4;
            base_matrix = new Matrix();
        }

        Matrix multiple_lines(Matrix ma, Matrix mb, Matrix result, int i_b, int i_e)
        {
            for (int i = i_b; i < i_e; i++)
            {
                for (int j = 0; j < mb.size; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < ma.size; k++)
                    {
                        temp += ma.matrix[i, k] * mb.matrix[k, j];
                    }
                    result.matrix[i, j] = temp;
                }
            }
            return result;
        }

        Matrix multiple_lines_parallel(Matrix ma, Matrix mb, Matrix result, int i_b, int i_e)
        {
            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = cores
            };

            Parallel.For(i_b, i_e, opt, i =>
            {
                for (int j = 0; j < mb.size; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < ma.size; k++)
                    {
                        temp += ma.matrix[i, k] * mb.matrix[k, j];
                    }

                    result.matrix[i, j] = temp;
                }
            });

            return result;
        }

        public Matrix multiply_matrix(Matrix ma, Matrix mb)
        {

            Matrix result = new Matrix(ma.size);


            multiple_lines(ma, mb, result, 0, ma.size);

            return result;
        }

        public Matrix multiply_matrix_parallel(Matrix ma, Matrix mb)
        {

            Matrix result = new Matrix(ma.size);


            multiple_lines_parallel(ma, mb, result, 0, ma.size);

            return result;
        }

        public Matrix thread_multiply(Matrix ma, Matrix mb)
        {
            Matrix result = new Matrix(ma.size);

            int c = ma.size / cores;
            Thread[] threads = new Thread[cores];
            for (int i = 0; i < cores; i++)
            {
                int start = i * c;
                int end = (i + 1) * c;
                threads[i] = new Thread(() =>
                {
                    multiple_lines(ma, mb, result, start, end);
                });
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Thread x in threads) x.Start();
            foreach (Thread x in threads) x.Join();

            return result;
        }
    }
}
