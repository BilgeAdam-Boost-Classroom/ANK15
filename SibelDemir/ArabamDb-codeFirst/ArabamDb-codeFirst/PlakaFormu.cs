using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabamDb_codeFirst
{
    public partial class PlakaFormu : Form
    {
        ArabamDbContext _db=new ArabamDbContext();
        Plaka secilenPlaka;
        public PlakaFormu()
        {
            InitializeComponent();
            Goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
