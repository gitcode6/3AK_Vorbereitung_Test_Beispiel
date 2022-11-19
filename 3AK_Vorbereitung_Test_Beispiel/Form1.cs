using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using System.Diagnostics;

namespace _3AK_Vorbereitung_Test_Beispiel
{
    public partial class Form1 : Form
    {
        BindingList<ToDo> toDos = null;
        Frm_Eingabe_ToDo eingabe_todo = new Frm_Eingabe_ToDo();
        ITodoService todoService = null;

        public static int items_in_listbox = 0;



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ToDos aus File laden


            //DataSource der ListBox festlegen

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            eingabe_todo.ShowDialog();

            if (eingabe_todo.hinzufuegen == true)
            {
                //Kunde aus Frm_Eingabe_ToDo in Liste einfügen

            }
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Speichere ToDos in File
           
        }

        private void lstBx_todos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
