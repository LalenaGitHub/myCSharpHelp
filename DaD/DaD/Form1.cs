using System.Windows.Forms;
using System.IO;

namespace DaD
{
    public partial class FormDaD : Form
    {
        public FormDaD()
        {
            InitializeComponent();
        }

        private void LbDaD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }



        private void LbDaD_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
               string [] s = (string[]) e.Data.GetData(DataFormats.FileDrop);

                /* listBox1.Items.Clear();*/
                string[] DropPath = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                foreach (string dropfilepath in DropPath)
                {
                    string listboxitem = "";
                   // if (System.IO.Path.GetExtension(dropfilepath).Contains(".*"))
                   // {
                        listboxitem  = System.IO.Path.GetFileNameWithoutExtension(dropfilepath);
                        listboxitem += " " + dropfilepath;
                        LbDaD.Items.Add(listboxitem);
                  //  }
                }
            }
        }

        private void TBDad_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void TBDad_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                
                    /* listBox1.Items.Clear();*/
                    string[] DropPath = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                    foreach (string dropfilepath in DropPath)
                    {
                    string s;
                    s = System.IO.Path.GetFileNameWithoutExtension(dropfilepath);
                    s += " " + dropfilepath;

                    LbDaD.Items.Add(s);
                    //  }
                }
            }
        }

        private void DGVDaD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void DGVDaD_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                /* listBox1.Items.Clear();*/
                string[] DropPath = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                foreach (string dropfilepath in DropPath)
                {
                    string s = System.IO.Path.GetFileNameWithoutExtension(dropfilepath);
                    string path = System.IO.Path.GetFullPath(dropfilepath);

                 //   The FileInfo class provides the following properties that enable you to retrieve information about a file.For an example of how to use each property, see the property pages.
                 //The Directory property retrieves an object that represents the parent directory of a file.
                 //The DirectoryName property retrieves the full path of the parent directory of a file.
                 //The Exists property checks for the presence of a file before operating on it.
                 //The IsReadOnly property retrieves or sets a value that specifies whether a file can be modified.
                 //The Length retrieves the size of a file.
                 //The Name retrieves the name of a file.
                    FileInfo fi1 = new FileInfo(path);

                    DGVDaD.Rows.Add(s, path, fi1.Length);
                   
                }
            }
        }

        
    }
}
