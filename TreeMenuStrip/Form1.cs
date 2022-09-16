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
      treeView1.ImageList = _images;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      treeView1.Nodes.Clear();
      foreach (ToolStripMenuItem item in menuStrip1.Items)
      {
        List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode(item.Text);
        if (item.Tag != null)
         root.Name = item.Tag.ToString();
        root.Nodes.AddRange(CreateTreeNodesMenuItens(item));
        nodes.Add(root);
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
    }



    ///// <summary>
    ///// Gets a list of all ToolStripMenuItems
    ///// </summary>
    ///// <param name="menuStrip">The menu strip control</param>
    ///// <returns>List of all ToolStripMenuItems</returns>
    //public static TreeNode[] NodeMenu(MenuStrip menuStrip)
    //{
    //  TreeNode[] _nodes;

    //  _nodes.Clear();
    //  foreach (ToolStripMenuItem i in menuStrip.Items)
    //  {
    //    NodeItensMenu(i);
    //  }
    //  return _nodes;
    //}

    ///// <summary>
    ///// Gets the menu items.
    ///// </summary>
    ///// <param name="item">The item.</param>
    ///// <param name="items">The items.</param>
    //private static void NodeItensMenu(ToolStripMenuItem item)
    //{
    //  TreeNode node = new TreeNode();
    //  _nodes.Add(new TreeNode(item.Tag.ToString(), item.Text, 0));
    //  foreach (ToolStripItem i in item.DropDownItems)
    //  {
    //    if (i is ToolStripMenuItem)
    //    {
    //      GetMenuItems((ToolStripMenuItem)i, items);
    //    }
    //  }
    //}


    ///// <summary>
    ///// Gets a list of all ToolStripMenuItems
    ///// </summary>
    ///// <param name="menuStrip">The menu strip control</param>
    ///// <returns>List of all ToolStripMenuItems</returns>
    //public static List<ToolStripMenuItem> GetItems(MenuStrip menuStrip)
    //{
    //  List<ToolStripMenuItem> myItems = new List<ToolStripMenuItem>();
    //  foreach (ToolStripMenuItem i in menuStrip.Items)
    //  {

    //    GetMenuItems(i, myItems);
    //  }
    //  return myItems;
    //}

    ///// <summary>
    ///// Gets the menu items.
    ///// </summary>
    ///// <param name="item">The item.</param>
    ///// <param name="items">The items.</param>
    //private static void GetMenuItems(ToolStripMenuItem item, List<ToolStripMenuItem> items)
    //{
    //  items.Add(item);
    //  foreach (ToolStripItem i in item.DropDownItems)
    //  {
    //    if (i is ToolStripMenuItem)
    //    {
    //      GetMenuItems((ToolStripMenuItem)i, items);
    //    }
    //  }
    //}


  }
}