using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ExportView : Form
    {
        public ExportView()
        {
            InitializeComponent();
        }

        internal void SetData(string data)
        {
            txtExportData.Text = data;
        }
    }
}
