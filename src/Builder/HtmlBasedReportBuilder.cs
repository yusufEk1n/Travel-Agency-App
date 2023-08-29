using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.Builder
{
    public class HtmlBasedReportBuilder : ReportBuilderBase
    {
        public HtmlBasedReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {

        }
        public override string BuildHeader()
        {
            return string.Format("<h1>{0}</h1>\n\n", base.Info.Title);
        }

        public override string BuildFooter()
        {
            return string.Format("<h5>{0}</h5>\n\n", base.Info.TotalCost);
        }

        public override string BuildContents()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var expense in base.Info.Expenses)
            {
                sb.Append(string.Format("<div class='contentItem'>{0}</div>\n", expense));
            }
            sb.Append(string.Format("\n"));
            return sb.ToString();
        }
    }
}
