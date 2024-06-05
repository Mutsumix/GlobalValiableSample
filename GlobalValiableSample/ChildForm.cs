using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Disposables;
using Reactive.Bindings.Extensions;

namespace GlobalValiableSample
{
    public partial class ChildForm : Form
    {
        private CompositeDisposable disposables = new CompositeDisposable();


        public ChildForm()
        {
            InitializeComponent();
            GlobalValiable.Factory.Subscribe(factory => sampleLabel.Text = factory).AddTo(disposables);
            sampleLabel.Text = "グローバル変数";
            label1.Text = "子";
        }

        private void btnUpdateFactory_Click(object sender, EventArgs e)
        {
            GlobalValiable.Factory.Value = txtFactory.Text;

        }
    }
}
