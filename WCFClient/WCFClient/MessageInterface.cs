using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFClient
{
    public partial class MessageInterface : Form
    {

        public MessageInterface()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (var serviceProxy = new System.ServiceModel.ChannelFactory<WcfService.IWcfService>("BasicHttpBinding_IWcfService"))
            {
                serviceProxy.Open();
                var channel = serviceProxy.CreateChannel();
                txtOutput.Text += channel.GetPing(new WcfService.Message { Identity = Guid.NewGuid(), DT = DateTime.Now, MessageBody = txtInput.Text }).MessageBody;
                txtOutput.Text += channel.GetData(new WcfService.Message { Identity = Guid.NewGuid(), DT = DateTime.Now, MessageBody = txtInput.Text }).MessageBody;
                serviceProxy.Close();
            }
        }
    }
}
