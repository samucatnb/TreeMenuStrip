namespace TreeMenuStrip
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNodeName = new System.Windows.Forms.TextBox();
      this.txtNodeText = new System.Windows.Forms.TextBox();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.button1 = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tributosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.subOutrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nivel3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.pagamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.remotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.anyDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.txtNodeName);
      this.panel1.Controls.Add(this.txtNodeText);
      this.panel1.Controls.Add(this.treeView1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.menuStrip1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 450);
      this.panel1.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(496, 117);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(138, 15);
      this.label2.TabIndex = 6;
      this.label2.Text = "Node Selecionado Name";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(496, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(127, 15);
      this.label1.TabIndex = 5;
      this.label1.Text = "Node Selecionado Text";
      // 
      // txtNodeName
      // 
      this.txtNodeName.Location = new System.Drawing.Point(492, 135);
      this.txtNodeName.Name = "txtNodeName";
      this.txtNodeName.Size = new System.Drawing.Size(253, 23);
      this.txtNodeName.TabIndex = 4;
      // 
      // txtNodeText
      // 
      this.txtNodeText.Location = new System.Drawing.Point(492, 69);
      this.txtNodeText.Name = "txtNodeText";
      this.txtNodeText.Size = new System.Drawing.Size(253, 23);
      this.txtNodeText.TabIndex = 3;
      // 
      // treeView1
      // 
      this.treeView1.Location = new System.Drawing.Point(0, 27);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(451, 420);
      this.treeView1.TabIndex = 2;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(571, 342);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(204, 45);
      this.button1.TabIndex = 1;
      this.button1.Text = "Ler Menu";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // cadastroToolStripMenuItem
      // 
      this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.outrosToolStripMenuItem});
      this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
      this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.cadastroToolStripMenuItem.Tag = "1";
      this.cadastroToolStripMenuItem.Text = "Cadastro";
      // 
      // produtosToolStripMenuItem
      // 
      this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
      this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.produtosToolStripMenuItem.Tag = "11";
      this.produtosToolStripMenuItem.Text = "Produtos";
      this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
      // 
      // gruposToolStripMenuItem
      // 
      this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
      this.gruposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.gruposToolStripMenuItem.Tag = "12";
      this.gruposToolStripMenuItem.Text = "Grupos";
      // 
      // clientesToolStripMenuItem
      // 
      this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
      this.clientesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.clientesToolStripMenuItem.Tag = "13";
      this.clientesToolStripMenuItem.Text = "Clientes";
      // 
      // outrosToolStripMenuItem
      // 
      this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentosToolStripMenuItem,
            this.tributosToolStripMenuItem,
            this.subOutrosToolStripMenuItem});
      this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
      this.outrosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.outrosToolStripMenuItem.Tag = "14";
      this.outrosToolStripMenuItem.Text = "Outros";
      // 
      // pagamentosToolStripMenuItem
      // 
      this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
      this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.pagamentosToolStripMenuItem.Tag = "111";
      this.pagamentosToolStripMenuItem.Text = "Pagamentos";
      // 
      // tributosToolStripMenuItem
      // 
      this.tributosToolStripMenuItem.Name = "tributosToolStripMenuItem";
      this.tributosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.tributosToolStripMenuItem.Tag = "112";
      this.tributosToolStripMenuItem.Text = "Tributos";
      // 
      // subOutrosToolStripMenuItem
      // 
      this.subOutrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivel3ToolStripMenuItem});
      this.subOutrosToolStripMenuItem.Name = "subOutrosToolStripMenuItem";
      this.subOutrosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.subOutrosToolStripMenuItem.Tag = "113";
      this.subOutrosToolStripMenuItem.Text = "Sub-Outros";
      // 
      // nivel3ToolStripMenuItem
      // 
      this.nivel3ToolStripMenuItem.Name = "nivel3ToolStripMenuItem";
      this.nivel3ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.nivel3ToolStripMenuItem.Tag = "1111";
      this.nivel3ToolStripMenuItem.Text = "Nivel 3";
      // 
      // vendasToolStripMenuItem
      // 
      this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
      this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.vendasToolStripMenuItem.Tag = "2";
      this.vendasToolStripMenuItem.Text = "Vendas";
      // 
      // relatoriosToolStripMenuItem
      // 
      this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.produtosToolStripMenuItem1,
            this.pagamentosToolStripMenuItem1});
      this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
      this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.relatoriosToolStripMenuItem.Tag = "3";
      this.relatoriosToolStripMenuItem.Text = "Relatorios";
      // 
      // clientesToolStripMenuItem1
      // 
      this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
      this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.clientesToolStripMenuItem1.Tag = "31";
      this.clientesToolStripMenuItem1.Text = "Clientes";
      // 
      // produtosToolStripMenuItem1
      // 
      this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
      this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.produtosToolStripMenuItem1.Tag = "32";
      this.produtosToolStripMenuItem1.Text = "Produtos";
      // 
      // pagamentosToolStripMenuItem1
      // 
      this.pagamentosToolStripMenuItem1.Name = "pagamentosToolStripMenuItem1";
      this.pagamentosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.pagamentosToolStripMenuItem1.Text = "Pagamentos";
      // 
      // ajudaToolStripMenuItem
      // 
      this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.remotoToolStripMenuItem});
      this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
      this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.ajudaToolStripMenuItem.Text = "Ajuda";
      // 
      // sobreToolStripMenuItem
      // 
      this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
      this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.sobreToolStripMenuItem.Text = "Sobre";
      // 
      // remotoToolStripMenuItem
      // 
      this.remotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anyDeskToolStripMenuItem});
      this.remotoToolStripMenuItem.Name = "remotoToolStripMenuItem";
      this.remotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.remotoToolStripMenuItem.Text = "Remoto";
      // 
      // anyDeskToolStripMenuItem
      // 
      this.anyDeskToolStripMenuItem.Name = "anyDeskToolStripMenuItem";
      this.anyDeskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.anyDeskToolStripMenuItem.Text = "AnyDesk";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private Panel panel1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem outrosToolStripMenuItem;
        private ToolStripMenuItem pagamentosToolStripMenuItem;
        private ToolStripMenuItem tributosToolStripMenuItem;
        private ToolStripMenuItem subOutrosToolStripMenuItem;
        private ToolStripMenuItem nivel3ToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private TreeView treeView1;
        private Label label2;
        private Label label1;
        private TextBox txtNodeName;
        private TextBox txtNodeText;
        private ToolStripMenuItem pagamentosToolStripMenuItem1;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem remotoToolStripMenuItem;
        private ToolStripMenuItem anyDeskToolStripMenuItem;
    }
}