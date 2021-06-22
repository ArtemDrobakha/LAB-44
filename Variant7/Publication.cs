using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant7
{
    [Serializable]
    public class Publication
    {
        public Student student;
        public NaukoviDosiagnennya dosiagnennya;

        public Publication()
        {
            this.student = new Student("-", "-", 2000);
            this.dosiagnennya = NaukoviDosiagnennya.Dopovid_na_mizhnarodniy_konferentsii;
        }
        public Publication(Student student, NaukoviDosiagnennya dosiagnennya)
        {
            this.student = student;
            this.dosiagnennya = dosiagnennya;
        }
        
        public override string ToString()
        {
            return student + " " + dosiagnennya;
        }
    }
}
