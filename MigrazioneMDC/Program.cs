using MigrazioneMDC.Models;
using Npoi.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace MigrazioneMDC
{
    class Program
    {
        static void Main(string[] args)
        {
            ElaboraSoci("soci.xlsx");
        }

        static void ElaboraSoci(string nomefile)
        {
            Mapper mapper = new Mapper(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Files\\" + nomefile);

            IEnumerable<SocioExcel> soci = mapper.Take<SocioExcel>("Foglio1").Select(x => x.Value);

            int i = 0;
        }

        static SocioDB MappaSocio(SocioExcel socioExcel)
        {
            return null;
        }
    }
}
