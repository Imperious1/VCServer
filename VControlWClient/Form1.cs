using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VControlWClient
{
    public partial class Form1 : Form, OnUpdateListener
    {

        private List<ListViewItem> connections = new List<ListViewItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private delegate void InsertIntoListDelegate(int port, string ipAddr);
        private delegate void RemoveFromListDelegate(int index);

        public void onNewConnection(int port, string ipAddr)
        {
            if (InvokeRequired)Invoke(new InsertIntoListDelegate(onNewConnection), port, ipAddr);
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = port.ToString();
                item.SubItems.Add(ipAddr);
                connections.Add(item);
                connectedDevices.Items.Add(item);
            }
        }

        public void onConnectionClosed(int index)
        {
            if (InvokeRequired) Invoke(new RemoveFromListDelegate(onConnectionClosed), index);
            else
            {
                connectedDevices.Items.RemoveAt(index); 
            }
        }


    }
}
