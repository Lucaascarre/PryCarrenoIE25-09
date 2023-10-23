//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace PryCarrenoIE
//{
//    public partial class Proveedores : Form
//    {
//        public Proveedores()
//        {
//            InitializeComponent();
//            ingresarNodoTreeView();
//            this.treeView1.NodeMouseClick +=
//                new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
//        }
//        public string ruta = "";

//        public void ingresarNodoTreeView()
//        {
//            TreeNode Nodoraiz;
//            //string rutaDirectorio = Path.Combine(Application.StartupPath, "Resources");
//            //DirectoryInfo info = new DirectoryInfo(rutaDirectorio);

//            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources 2");
//            if (info.Exists )
//            {
//                Nodoraiz = new TreeNode(info.Name);
//                Nodoraiz.Tag = info;
//                GetDirectories(info.GetDirectories(), Nodoraiz);
//                treeView1.Nodes.Add(Nodoraiz);
//            }
//        }
//        private void GetDirectories(DirectoryInfo[] subDirs,
//    TreeNode nodeToAddTo)
//        {
//            TreeNode aNode;
//            DirectoryInfo[] subSubDirs;
//            foreach (DirectoryInfo subDir in subDirs)
//            {
//                aNode = new TreeNode(subDir.Name, 0, 0);
//                aNode.Tag = subDir;
//                aNode.ImageKey = "folder";
//                subSubDirs = subDir.GetDirectories();
//                if (subSubDirs.Length != 0)
//                {
//                    GetDirectories(subSubDirs, aNode);
//                }
//                nodeToAddTo.Nodes.Add(aNode);
//            }
//        }
//        void treeView1_NodeMouseClick(object sender,
//    TreeNodeMouseClickEventArgs e)
//        {
//            TreeNode newSelected = e.Node;
//            listView1.Items.Clear();
//            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
//            ListViewItem.ListViewSubItem[] subItems;
//            ListViewItem item = null;

//            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
//            {
//                item = new ListViewItem(dir.Name, 0);
//                subItems = new ListViewItem.ListViewSubItem[]
//                    {new ListViewItem.ListViewSubItem(item, "Directory"),
//             new ListViewItem.ListViewSubItem(item,
//                dir.LastAccessTime.ToShortDateString())};
//                item.SubItems.AddRange(subItems);
//                listView1.Items.Add(item);
//            }
//            foreach (FileInfo file in nodeDirInfo.GetFiles())
//            {
//                item = new ListViewItem(file.Name, 1);
//                subItems = new ListViewItem.ListViewSubItem[]
//                    { new ListViewItem.ListViewSubItem(item, "File"),
//             new ListViewItem.ListViewSubItem(item,
//                file.LastAccessTime.ToShortDateString())};

//                item.SubItems.AddRange(subItems);
//                listView1.Items.Add(item);
//            }

//            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
//        }

//        private void Proveedores_Load(object sender, EventArgs e)
//        {

//        }

//        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
//        {
//            string i = listView1.SelectedItems[0].Text.ToString();


//            string rutaArchivoParcial = Path.Combine(ruta, i);


//            string rutaArchivoFinal = Path.Combine(@"../../" + "Resources 2 ", rutaArchivoParcial);


//            GrlProveedores frmdatosgrilla = new GrlProveedores();


//            using (StreamReader reader = new StreamReader(rutaArchivoFinal))
//            {

//                reader.ReadLine();


//                string linea;
//                while ((linea = reader.ReadLine()) != null)
//                {

//                    string[] parametros = linea.Split(';');

//                    frmdatosgrilla.dataGridView1.Rows.Add(parametros);
//                }
//            }
//            GrlProveedores.rutaArchivoGrilla = rutaArchivoFinal;

//            frmdatosgrilla.Show();
//            this.Hide();
//        }



//    }
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryCarrenoIE
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            ingresarNodoTreeView();
            this.treeView1.NodeMouseClick +=
                new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        public string ruta = "";

        public void ingresarNodoTreeView()
        {
            TreeNode Nodoraiz;
            DirectoryInfo info = new DirectoryInfo(@"../../Resources");
            if (info.Exists)
            {
                Nodoraiz = new TreeNode(info.Name);
                Nodoraiz.Tag = info;
                GetDirectories(info.GetDirectories(), Nodoraiz);
                treeView1.Nodes.Add(Nodoraiz);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Directory"),
                      new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
                      new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string i = listView1.SelectedItems[0].Text.ToString();
            string rutaArchivoParcial = Path.Combine(ruta, i);
            string rutaArchivoFinal = Path.Combine(@"../../Resources", rutaArchivoParcial);

            GrlProveedores frmdatosgrilla = new GrlProveedores();

            using (StreamReader reader = new StreamReader(rutaArchivoFinal))
            {
                reader.ReadLine();
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] parametros = linea.Split(';');
                    frmdatosgrilla.dataGridView1.Rows.Add(parametros);
                }
            }

            // Establece la propiedad rutaArchivoGrilla en la clase GrlProveedores
            GrlProveedores.rutaArchivoGrilla = rutaArchivoFinal;

            frmdatosgrilla.Show();
            this.Hide();
        }
        

           

    }
}
