namespace Average.Test
{
    public class AverageTest
    {
        [Fact]
        public void TestComputeMeanOfFile()
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "numbers.txt");
            StreamWriter writer = new(tempFilePath);
            writer.WriteLine("1");
            writer.WriteLine("2");
            writer.WriteLine("3");
            writer.Close();

            double actual = Average.ComputeMeanOfFile(tempFilePath);

            Assert.Equal(2, actual);

            File.Delete(tempFilePath);
        }

        [Fact]
        public void TestComputeMedianOfFile()
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "numbers.txt");
            StreamWriter writer = new(tempFilePath);
            writer.WriteLine("23");
            writer.WriteLine("29");
            writer.WriteLine("25");
            writer.WriteLine("-142");
            writer.Close();

            double actual = Average.ComputeMedianOfFile(tempFilePath);

            Assert.Equal(24, actual);

            File.Delete(tempFilePath);
        }

        [Fact]
        public void TestComputeModeOfFile()
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "numbers.txt");
            StreamWriter writer = new(tempFilePath);
            writer.WriteLine("23");
            writer.WriteLine("29");
            writer.WriteLine("23");
            writer.Close();

            List<int> actual = Average.ComputeModeOfFile(tempFilePath);

            Assert.Equal(new[] { 23 }, actual);

            File.Delete(tempFilePath);
        }
    }
}
