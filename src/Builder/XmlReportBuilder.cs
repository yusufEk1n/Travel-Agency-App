using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.Builder
{
    public class XmlReportBuilder : ReportBuilderBase
    {
        public XmlReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {

        }

        public override string BuildHeader()
        {
            return string.Format("<Header>{0}</Header>\n\n", base.Info.Title);
        }

        public override string BuildFooter()
        {
            return string.Format("<Footer>{0}</Footer>\n\n", base.Info.TotalCost);
        }

        public override string BuildContents()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var expense in base.Info.Expenses)
            {
                sb.Append(string.Format("<Expense name='{0}'/>\n", expense));
            }
            sb.Append(string.Format("\n"));
            return sb.ToString();
        }
    }
}
