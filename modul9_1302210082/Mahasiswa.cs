namespace modul9_1302210082
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            Name = name;
            Nim = nim;
            Course = course;
            Year = year;
        }
    }
}