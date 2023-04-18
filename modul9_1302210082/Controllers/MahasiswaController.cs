using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210082.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<string> courses = new List<string>
        {
            "KPL", "BD", "PBO"
        };

        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Alif Rasyid Ramdhani", "1302210098", courses, 2023),
            new Mahasiswa("Muhammad Zaidan Rafif", "1302213072", courses, 2023),
            new Mahasiswa("Zakkiya Hakkem Kamaruzaman", "1302210135", courses, 2023),
            new Mahasiswa("Aryasatya Pratama", "1302210082", courses, 2023)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}