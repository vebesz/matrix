namespace matrix
{
    public class Matrix
    {
        private double[,] values;

        public Matrix(int rows, int columns)
        {
            values = new double[rows, columns];
        }

        public int Rows
        {
            get { return values.GetLength(0); }
        }

        public int Columns
        {
            get { return values.GetLength(1); }
        }

        public double this[int row, int column]
        {
            get { return values[row, column]; }
            set { values[row, column] = value; }
        }
        public void Kiir()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write("{0}, ", values[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static Matrix CreateFromUserInput()
        {
            Console.WriteLine("Írja be a sorok számát:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Írja meg az oszlopok számát:");
            int columns = int.Parse(Console.ReadLine());

            Matrix result = new Matrix(rows, columns);

            Console.WriteLine("Enter the matrix values:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("mátrix[" + i + "," + j + "]:");
                    result[i, j] = double.Parse(Console.ReadLine());
                }
            }

            return result;
        }

        public double Minimum()
        {
            double min = values[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (values[i, j] < min)
                    {
                        min = values[i, j];
                    }
                }
            }
            return min;
        }

        public double Maximum()
        {
            double max = values[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (values[i, j] > max)
                    {
                        max = values[i, j];
                    }
                }
            }
            return max;
        }

        public double Atlag()
        {
            double sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sum += values[i, j];
                }
            }
            return sum / (Rows * Columns);
        }

        public bool VanBenne(double szam)
        {
            bool vanBenne = false;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (values[i, j] == szam)
                    {
                        vanBenne = true;
                    }
                }
            }
            return vanBenne;
        }
        public void Rendezes()
        {
            Matrix rendezett = this;
            double[] tomb = new double[Rows * Columns];
            int index = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    tomb[index] = rendezett[i, j];
                    index++;
                }
            }
            Array.Sort(tomb);
            index = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    rendezett[i, j] = tomb[index];
                    index++;
                }
            }
            rendezett.Kiir();
        }

        public void RendezesVisszafele()
        {
            Matrix rendezett = this;
            double[] tomb = new double[Rows * Columns];
            int index = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    tomb[index] = rendezett[i, j];
                    index++;
                }
            }
            Array.Sort(tomb);
            Array.Reverse(tomb);
            index = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    rendezett[i, j] = tomb[index];
                    index++;
                }
            }
            rendezett.Kiir();
        }
        public void ParosParatlan()
        {
            Matrix paros = new Matrix(Rows, Columns);
            Matrix paratlan = new Matrix(Rows, Columns);
            int parosIndex = 0;
            int paratlanIndex = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (values[i, j] % 2 == 0)
                    {
                        paros[parosIndex, 0] = values[i, j];
                        parosIndex++;
                    }
                    else
                    {
                        paratlan[paratlanIndex, 0] = values[i, j];
                        paratlanIndex++;
                    }
                }
            }
            Console.WriteLine("Páros mátrix:");
            paros.Kiir();
            Console.WriteLine("Páratlan mátrix:");
            paratlan.Kiir();
        }
    }
}

