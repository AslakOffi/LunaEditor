using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunaEditor.Controls;

namespace LunaEditor
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      MainMenuStrip menuStrip = new MainMenuStrip();
      Controls.Add(menuStrip);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
