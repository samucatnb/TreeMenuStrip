namespace TreeMenuStrip
{
  public partial class Form1 : Form
  {
    ImageList _images;

    public Form1()
    {
      InitializeComponent();
      _images = new ImageList();
      _images.Images.Add("liberado", Image.FromFile(@"C:\\WorkspaceGit\\praticsistemastanabi\\OfficeManager\\OfficeManager\\img\\confirm.png"));
      _images.Images.Add("bloqueado", Image.FromFile(@"C:\WorkspaceGit\praticsistemastanabi\OfficeManager\OfficeManager\img\cancel.png"));
      _images.Images.Add("menu", Image.FromFile(@"C:\WorkspaceGit\praticsistemastanabi\OfficeManager\OfficeManager\img\Menu16x16.png"));
      treeView1.ImageList = _images;

    }

    private void button1_Click(object sender, EventArgs e)
    {
      treeView1.Nodes.Clear();
      //vamos rodar cada menu raiz e pegar todos os itens e submenus...
      foreach (ToolStripMenuItem item in menuStrip1.Items)
      {
        //lista de TreeNode para armazenar a estrutura de nodes e inserir no TreeView
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);
        if (item.Tag != null)
          root.Name = item.Tag.ToString();
        root.ImageIndex = _images.Images.IndexOfKey("menu");
        root.SelectedImageIndex = _images.Images.IndexOfKey("menu");
        root.Tag = "menu";
        //após criar Node raiz - criamos toda estrutura dele
        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        //adicionamos ao nosso list nodes
        nodes.Add(root);
        //inserimos nossa lista de nodes ao treeview1
        treeView1.Nodes.AddRange(nodes.ToArray());
      }
    }

    private TreeNode[] CreateTreeNodesMenuItens(ToolStripMenuItem menuItem)
    {
      List<TreeNode> nodes = new List<TreeNode>();

      foreach (ToolStripMenuItem item in menuItem.DropDownItems)
      {
        TreeNode node = new TreeNode(item.Text);
        if (item.Tag != null)
          node.Name = item.Tag.ToString();
        if (item.DropDownItems.Count > 0) // ´e um submenu 
        {
          node.ImageIndex = _images.Images.IndexOfKey("menu");
          node.SelectedImageIndex = _images.Images.IndexOfKey("menu");
          node.Tag = "submenu";
            
        }
        else
        {
          node.ImageIndex = _images.Images.IndexOfKey("liberado");
          node.SelectedImageIndex = _images.Images.IndexOfKey("liberado");
          node.Tag = "item";
        }
        node.Checked = true; //para teste vou inicializar com essa propriedade igual a true (signfica liberado)
        node.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        nodes.Add(node);
      }
      return nodes.ToArray();

    }

    private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      txtNodeText.Text = e.Node.Text;
      txtNodeName.Text = e.Node.Name;
      txtNodeTag.Text = e.Node.Tag.ToString();
    }

    private void treeView1_DoubleClick(object sender, EventArgs e)
    {
      if (sender is TreeView tr)
      {
        //se foi identificado como item então altera 
        if (tr.SelectedNode.Tag == "item")
        {
          if (tr.SelectedNode.Checked == true)
          {
            tr.SelectedNode.Checked = false;
            tr.SelectedNode.ImageIndex = _images.Images.IndexOfKey("bloqueado");
            tr.SelectedNode.SelectedImageIndex = _images.Images.IndexOfKey("bloqueado");
          }
          else
          {
            tr.SelectedNode.Checked = true;
            tr.SelectedNode.ImageIndex = _images.Images.IndexOfKey("liberado");
            tr.SelectedNode.SelectedImageIndex = _images.Images.IndexOfKey("liberado");

          }
        }
      }
    }

  }
}