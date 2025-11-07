using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuorumAPI;

namespace CheeksExec
{
    public partial class Form1 : Form
    {
        private QuorumModule quorum;
        public Form1()
        {
            InitializeComponent();
            quorum = new QuorumModule();
            quorum.StartCommunication();
        }
        private void AttachBTN_Click(object sender, EventArgs e)
        {
            quorum.AttachAPI();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            quorum.StopCommunication();
        }
        private void InfYeildBTN_Click(object sender, EventArgs e)
        {
            quorum.Execute("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }
        private async void ExecuteBTN_Click(object sender, EventArgs e)
        {
            string script = await QuorumMonaco.CoreFunctions.GetText();
            quorum.ExecuteScript(script);
        }

        private void isattached_Click(object sender, EventArgs e)
        {
            bool isAttached = quorum.IsAttached();
            MessageBox.Show(isAttached ? "Attached" : "Not attached");
        }
    }
}
