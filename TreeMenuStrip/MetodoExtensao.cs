using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeMenuStrip
{
  internal static class MetodoExtensao
  {
    /// <summary>
    /// Metodo Adiciona um item ao ContextMenuStripEdit
    /// </summary>
    /// <param name="descricao">Descrição que será mostrada (Text)</param>
    /// <param name="imagem">Defina uma imagem para o item (Image)</param>
    /// <param name="indice">defina um indice, será usado para identificar a ação, pode repetir (MergeIndex)</param>
    /// <param name="teclaAtalho">Defina uma tecla de atalho para o item (ShortcutKeys)</param>
    /// <param name="altura">defina a altura da caixa do Item (Height)</param>
    /// <param name="largura">defina a largura da caixa do Item (Width)</param>
    public static  void AddItem(this ContextMenuStrip obj, string descricao, Image imagem, int indice, Keys teclaAtalho = Keys.None, int altura = 40, int largura = 200)
    {
      try
      {
        ToolStripMenuItem item = new ToolStripMenuItem();
        // item.AutoSize = false;
        // item.Height = altura;
        // item.Width = largura;
        item.Text = descricao;
        item.Image = imagem;
        item.ShortcutKeys = teclaAtalho;
        item.MergeIndex = indice;
        obj.Items.Add(item);

      }
      catch
      {

        throw;
      }
    }

    /// <summary>
    /// Metodo possibilita personalizar nosso ContextMenuStrip alterando fonte e mantendo as imagens no tamanho original.
    /// </summary>
    /// <param name="fontFamily">parametro do tipo FontFamily</param>
    /// <param name="tamanhoFont">parametro define o tamanho da font</param>
    public static void PersonalizarContextMenu(this ContextMenuStrip obj, FontFamily fontFamily, float tamanhoFont)
    {
      obj.Font = new Font(fontFamily, tamanhoFont);
      for (int i = 0; i < obj.Items.Count; i++)
      {
        // this.Items[i].AutoSize = false;
        obj.Items[i].ImageScaling = ToolStripItemImageScaling.None;
      }
    }

  }
}
