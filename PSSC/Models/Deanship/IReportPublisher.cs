using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Deanship
{
    //interfata pentru generarea si publicarea de rapoarte

    //Strategy Signature
    public interface IReportStrategy
    {
        PlainText GenerateReport(List<Student.Student> students);
    }

    //Strategy Context
    public interface IReportPublisher
    {
        void Publish(IReportStrategy strategy);
    }

}
