class Array
{
    void Learn1DArray()
    {
        //One dimensional array
        int[] ages1 = new int[10];
        double[] ages2 = new double[10];

        ages1[0] = 32;
        ages1[5] = 12;

        float[] numbers = new float[] { 234.34f, 23.654f, 23234.43f };

    }

    void LearnMulDArray()
    {
        //Multi-dimensional array
        int[,] agesMatrix = new int[10, 12];
        agesMatrix[0, 0] = 5543;

        int[,,] ages3D = new int[12, 123, 3];
        string[,] nameWithAddress = new string[,] { { "Bruce", "Lee" }, { "Tony", "Jha" } };


    }
    void LearnJaggedArray()
    {
        byte[][] personAges = new byte[3][];
        personAges[0] = new byte[] { 34,43 };
        personAges[1] = new byte[] {12,45,23,54};

    }
}